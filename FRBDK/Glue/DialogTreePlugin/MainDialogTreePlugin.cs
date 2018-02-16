﻿using System;
using FlatRedBall.Glue.Plugins.Interfaces;
using FlatRedBall.Glue.Plugins;
using System.Windows.Forms;
using FlatRedBall.Glue.Plugins.ExportedImplementations;
using DialogTreePlugin.Views;
using DialogTreePlugin.Controllers;
using FlatRedBall.Glue.SaveClasses;
using DialogTreePlugin.Generators;
using EditorObjects.Parsing;
using System.Collections.Generic;
using System.Linq;
using FlatRedBall.IO;

namespace DialogTreePlugin
{
    [System.ComponentModel.Composition.Export(typeof(PluginBase))]
    public class MainDialogTreePlugin : PluginBase
    {
        MainControl mainControl;

        public override string FriendlyName => "Dialog Tree Plugin";

        //v1.1.0 The string keys are no longer editable.
        // - We can now dynamically size the columns for any number of languages.
        //v1.2.0 removed unused files and general code cleanup.
        // - Removed the extra blank line from the data grid.
        // - Implemented code-gen for the dialog tree files so Design can use DialogTrees.FileName
        public override Version Version => new Version(1, 2, 0);

        const string fileType = "json";

        public override bool ShutDown(PluginShutDownReason shutDownReason)
        {
            var toReturn = true;

            return toReturn;
        }

        public override void StartUp()
        {
            this.ReactToLoadedGlux += GetJsonRefs;
            this.ReactToItemSelectHandler += HandleItemSelected;
            this.ReactToFileChangeHandler += HandleFileChanged;
            this.ReactToNewFileHandler += HandleNewFile;
            
        }

        private void GetJsonRefs()
        {
            //Generate the dialog tree file constants.
            var jsonRefs = GlueState.Self.CurrentGlueProject.GetAllReferencedFiles().Where(item => FileManager.GetExtension(item.Name) == fileType);
            if(jsonRefs.Count() > 0)
            {
                CodeGenerator.Self.UpdateTrackedDialogTreeFiles(jsonRefs.Select(item => item.Name));
            }
        }

        private void HandleItemSelected(TreeNode selectedTreeNode)
        {
            bool shouldShow = GlueState.Self.CurrentReferencedFileSave != null && 
                selectedTreeNode?.Tag == GlueState.Self.CurrentReferencedFileSave &&
                GlueState.Self.CurrentReferencedFileSave.Name.EndsWith(fileType);

            if(shouldShow)
            {
                if(mainControl == null)
                {
                    mainControl = MainController.Self.GetControl();
                    this.AddToTab(PluginManager.CenterTab, mainControl, "Dialog Tree");
                }
                else
                {
                    this.AddTab();
                }

                MainController.Self.UpdateTo(GlueState.Self.CurrentReferencedFileSave);
            }
            else
            {
                this.RemoveTab();
            }
        }
        private void HandleNewFile(ReferencedFileSave newFile)
        {
            //If the new file is a .json, add it to the dialog tree constants.
            if(newFile.Name.EndsWith(fileType))
            {
                CodeGenerator.Self.AddNewTrackedFile(newFile.Name);
            }
        }

        private void HandleFileChanged(string fileName)
        {
            if (fileName.EndsWith(MainController.RelativeToGlobalContentLocalizationDbCsvFile))
            {
                MainController.Self.ReactToLocalizationDbChange(fileName);
            }
        }
    }
}
