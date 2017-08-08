﻿using FlatRedBall.Glue.Elements;
using FlatRedBall.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatRedBall.Glue.SaveClasses;
using FlatRedBall.Glue.Plugins.ExportedImplementations;
using FlatRedBall.Glue.Managers;
using OfficialPlugins.MonoGameContent;
using FlatRedBall.Glue.VSHelpers.Projects;
using System.ComponentModel;

namespace OfficialPlugins.ContentPipelinePlugin
{
    public class ContentPipelineController
    {
        SettingsSave settings;
        ContentPipelineControl control;
        ControlViewModel viewModel;

        public SettingsSave Settings
        {
            get { return settings; }
        }

        public void LoadOrCreateSettings()
        {
            settings = SaveLoadLogic.LoadSettings();
            if(settings == null)
            {
                settings = new ContentPipelinePlugin.SettingsSave();
            }
        }

        public void SetControl(ContentPipelineControl control, ControlViewModel viewModel)
        {
            this.control = control;
            control.RefreshClicked += HandleRefreshClicked;

            this.viewModel = viewModel;
            viewModel.PropertyChanged += HandleViewModelPropertyChanged;
            if(settings != null)
            {
                viewModel.UseContentPipelineOnPngs = settings.UseContentPipelineOnAllPngs;
            }
            else
            {
                viewModel.UseContentPipelineOnPngs = false;
            }
        }

        private void HandleViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var parameterName = e.PropertyName;

            switch(parameterName)
            {
                case nameof(ControlViewModel.UseContentPipelineOnPngs):

                    settings.UseContentPipelineOnAllPngs = viewModel.UseContentPipelineOnPngs;
                    SaveLoadLogic.SaveSettings(settings);

                    RefreshProjects();
                    break;
            }
        }

        private void HandleRefreshClicked(object sender, EventArgs e)
        {
            RefreshProjects();
        }
        
        private void RefreshProjects()
        {
            // store it locally so the task has the same value when executing:
            bool useContentPipeline = settings.UseContentPipelineOnAllPngs;


            TaskManager.Self.AddSync(() =>
            {
                if (useContentPipeline)
                {
                    SetAllPngRfsesToUseContentPipeline();
                }
                else
                {
                    SetAllPngsRfsesToFromFileLoading();
                }
            }, "Changing whether all referenced file saves use content pipeline");


            // remove first:
            if (!useContentPipeline)
            {
                RemoveXnbs();
            }

            TaskManager.Self.AddSync(() =>
            {
                RefreshAllFileMembership(useContentPipeline);
            }, "Refreshing file memberships");

            if (useContentPipeline)
            {
                AddXnbs();
            }

            AddSaveTasks();
        }

        private static void AddSaveTasks()
        {
            TaskManager.Self.AddSync(() =>
            {
                GlueCommands.Self.ProjectCommands.SaveProjects();
                GlueCommands.Self.GluxCommands.SaveGlux();
            },
            "Saving due to RFS changes");
        }

        private void AddXnbs()
        {
            var referencedPngs = GetReferencedPngs();

            var mainProject = GlueState.Self.CurrentMainProject;
            ProjectBase[] syncedProjects = GlueState.Self.SyncedProjects.ToArray();

            foreach (var referencedPng in referencedPngs)
            {
                BuildLogic.Self.TryAddXnbReferencesAndBuild(referencedPng, mainProject, save: false);

                foreach (var project in syncedProjects)
                {
                    BuildLogic.Self.TryAddXnbReferencesAndBuild(referencedPng, project, save: false);
                }
            }
        }

        private void RemoveXnbs()
        {
            var referencedPngs = GetReferencedPngs();

            var mainProject = GlueState.Self.CurrentMainProject;
            ProjectBase[] syncedProjects = GlueState.Self.SyncedProjects.ToArray();

            foreach (var referencedPng in referencedPngs)
            {
                BuildLogic.Self.TryRemoveXnbReferences(mainProject, referencedPng, save: false);
                
                foreach (var project in syncedProjects)
                {
                    BuildLogic.Self.TryRemoveXnbReferences(project, referencedPng, save: false);
                }
            }
        }

        private void SetAllPngRfsesToUseContentPipeline()
        {
            var allRfses = ObjectFinder.Self
                .GetAllReferencedFiles()
                .Where(item => FileManager.GetExtension(item.Name) == "png")
                .ToArray();


            foreach (var rfs in allRfses)
            {
                rfs.UseContentPipeline = true;
            }
        }

        private void SetAllPngsRfsesToFromFileLoading()
        {
            var allRfses = ObjectFinder.Self
                .GetAllReferencedFiles()
                .Where(item => FileManager.GetExtension(item.Name) == "png")
                .ToArray();

            foreach(var rfs in allRfses)
            {
                rfs.UseContentPipeline = false;
            }
        }

        private void RefreshAllFileMembership(bool useContentPipeline)
        {
            var referencedPngs = GetReferencedPngs();

            var projectCommands = GlueCommands.Self.ProjectCommands;
            var mainProject = GlueState.Self.CurrentMainProject;

            foreach (var referencedPng in referencedPngs)
            {
                projectCommands.UpdateFileMembershipInProject(mainProject, referencedPng, useContentPipeline: useContentPipeline, shouldLink: false);

                foreach(var project in GlueState.Self.SyncedProjects)
                {
                    projectCommands.UpdateFileMembershipInProject(
                        project, referencedPng, useContentPipeline: useContentPipeline, shouldLink: true);
                }
            }

        }

        public static string[] GetReferencedPngs()
        {
            List<string> referencedFileNames = new List<string>();

            var allRfses = ObjectFinder.Self
                .GetAllReferencedFiles();

            foreach (var rfs in allRfses)
            {
                var absolute = GlueCommands.Self.GetAbsoluteFileName(rfs);

                if (referencedFileNames.Contains(absolute) == false)
                {
                    referencedFileNames.Add(absolute);
                    AddReferencedFilesRecursively(absolute, referencedFileNames);
                }
            }

            // only get the PNGs:
            var referencedPngs = referencedFileNames
                .Where(item => FileManager.GetExtension(item) == "png")
                .Distinct()
                .Select(item => FileManager.Standardize(item))
                // Alphabetize for debugging, can get rid of this once this feature works well and I don't need to look at the list anymore:
                .OrderBy(item =>item)
                .ToArray();
            return referencedPngs;
        }

        private static void AddReferencedFilesRecursively(string absoluteFileName, List<string> referencedFileNames)
        {
            var referencedFiles =
                FileReferenceManager.Self.GetFilesReferencedBy(absoluteFileName, EditorObjects.Parsing.TopLevelOrRecursive.TopLevel);
            

            foreach(var file in referencedFiles)
            {
                if (referencedFileNames.Contains(file) == false)
                {
                    referencedFileNames.Add(file);
                    AddReferencedFilesRecursively(file, referencedFileNames);
                }

            }
        }
    }
}