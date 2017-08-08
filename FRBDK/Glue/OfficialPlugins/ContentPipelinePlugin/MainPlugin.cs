﻿using FlatRedBall.Glue.Plugins;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatRedBall.Glue.Plugins.Interfaces;
using FlatRedBall.Glue.VSHelpers.Projects;
using FlatRedBall.Glue.Plugins.ExportedImplementations;
using FlatRedBall.Glue.SaveClasses;
using FlatRedBall.IO;
using FlatRedBall.Glue.Managers;
using System.Diagnostics;
using OfficialPlugins.ContentPipelinePlugin;
using FlatRedBall.Glue.Parsing;
using System.ComponentModel;

namespace OfficialPlugins.MonoGameContent
{
    [Export(typeof (PluginBase))]
    public class MainPlugin : PluginBase
    {
        #region Fields/Properties

        ContentPipelineControl control;
        ControlViewModel viewModel;
        AliasCodeGenerator aliasCodeGenerator;

        ContentPipelineController controller;

        public override string FriendlyName
        {
            get
            {
                return "MonoGame Content Plugin";
            }
        }

        public override Version Version
        {
            get
            {
                return new Version(1, 0, 0);
            }
        }

        #endregion

        public override bool ShutDown(PluginShutDownReason shutDownReason)
        {
            return true;
        }

        #region Constructor/Initialize

        public MainPlugin()
        {
            viewModel = new ContentPipelinePlugin.ControlViewModel();
            viewModel.PropertyChanged += HandleViewModelPropertyChanged;
        }

        private void HandleViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var propertyName = e.PropertyName;

            switch(propertyName)
            {
                case nameof(ControlViewModel.UseContentPipelineOnPngs):
                    // so handling file changes will probably do this but let's force it so we know it happens:
                    aliasCodeGenerator.GenerateFileAliasLogicCode(controller.Settings.UseContentPipelineOnAllPngs);
                    break;
            }
        }

        public override void StartUp()
        {
            this.AddMenuItemTo("Content Pipeline Settings", HandleContentPipelineSettings, "Content");

            CreateController();

            // must come after the controller
            CreateAliasCodeGenerator();

            AssignEvents();
        }

        private void CreateAliasCodeGenerator()
        {
            aliasCodeGenerator = new AliasCodeGenerator();
            aliasCodeGenerator.Initialize(controller);
            CodeWriter.GlobalContentCodeGenerators.Add(aliasCodeGenerator);
        }

        private void CreateController()
        {
            controller = new ContentPipelineController();

        }

        private void AssignEvents()
        {
            this.ReactToFileChangeHandler += HandleFileChanged;
            this.ReactToLoadedGluxEarly += HandleLoadedGlux;
            this.ReactToUnloadedGlux += HandleGluxUnloaded;
            this.ReactToLoadedSyncedProject += HandleLoadedSyncedProject;
            this.ReactToNewFileHandler += HandleNewFile;
            this.ReactToReferencedFileChangedValueHandler += HandleReferencedFileValueChanged;
            this.GetIfUsesContentPipeline += HandleGetIfUsesContentPipeline;
        }

        #endregion

        private void HandleGluxUnloaded()
        {
            viewModel.IsProjectLoaded = false;
        }

        private bool HandleGetIfUsesContentPipeline(string absoluteFileName)
        {
            if(controller?.Settings != null)
            {
                var extension = FileManager.GetExtension(absoluteFileName);
                return extension == "png" && controller.Settings.UseContentPipelineOnAllPngs;
            }

            return false;
        }

        private void HandleContentPipelineSettings(object sender, EventArgs e)
        {
            if(control == null)
            {
                control = new ContentPipelinePlugin.ContentPipelineControl();
                control.DataContext = viewModel;
                controller.SetControl(control, viewModel);

                AddToTab(PluginManager.LeftTab, control, "Content Pipeline");

            }
            else
            {
                AddTab();
            }
        }

        private void HandleReferencedFileValueChanged(string memberName, object oldValue)
        {
            if(memberName == nameof(ReferencedFileSave.UseContentPipeline))
            {
                var rfs = GlueState.Self.CurrentReferencedFileSave;
                BuildLogic.Self.TryHandleReferencedFile(GlueState.Self.CurrentMainProject, rfs);

                foreach(var syncedProject in GlueState.Self.SyncedProjects)
                {
                    BuildLogic.Self.TryHandleReferencedFile(syncedProject, rfs);
                }
            }
        }

        private void HandleNewFile(ReferencedFileSave newFile)
        {

            if(GetIfShouldBuild( GlueState.Self.CurrentMainProject ))
            {
                BuildLogic.Self.TryHandleReferencedFile(GlueState.Self.CurrentMainProject, newFile);
            }
            foreach(var project in GlueState.Self.SyncedProjects)
            {
                if(GetIfShouldBuild( project ))
                {
                    BuildLogic.Self.TryHandleReferencedFile(project, newFile);
                }
            }
        }

        private bool GetIfShouldBuild(ProjectBase project)
        {
            return project is DesktopGlProject;
        }

        private void HandleLoadedGlux()
        {
            viewModel.IsProjectLoaded = true;
            controller.LoadOrCreateSettings();
            viewModel.UseContentPipelineOnPngs = controller.Settings.UseContentPipelineOnAllPngs;
            if(viewModel.UseContentPipelineOnPngs)
            {
                aliasCodeGenerator.GenerateFileAliasLogicCode(controller.Settings.UseContentPipelineOnAllPngs);
            }
            BuildLogic.Self.RefreshBuiltFilesFor(GlueState.Self.CurrentMainProject);
        }

        private void HandleLoadedSyncedProject(ProjectBase project)
        {
            BuildLogic.Self.RefreshBuiltFilesFor(project);
        }

        private void HandleFileChanged(string fileName)
        {
            aliasCodeGenerator.GenerateFileAliasLogicCode(controller.Settings.UseContentPipelineOnAllPngs);
        }
    }
}