#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

using System.Windows.Forms;
using ClearCanvas.Common;
using ClearCanvas.Desktop;
using ClearCanvas.Desktop.View.WinForms;
using ClearCanvas.ImageViewer.StudyManagement;
using ClearCanvas.ImageViewer.Configuration;
using System.Collections.Generic;
using System.IO;

namespace ClearCanvas.ImageViewer.Explorer.Local.View.WinForms
{
	[ExtensionOf(typeof(LocalImageExplorerComponentViewExtensionPoint))]
	public class LocalImageExplorerComponentView : WinFormsView, IApplicationComponentView
	{
		private Control _control;
		private LocalImageExplorerComponent _component;

		public LocalImageExplorerComponentView()
		{

		}

		public override object GuiElement
		{
			get
			{
				if (_control == null)
				{
					_control = new LocalImageExplorerControl(_component);
                    ((LocalImageExplorerControl)_control).DragDropGotFile += LocalImageExplorerComponentView_DragDropGotFile;
                }
				return _control;
			}
		}

        // From ClearCanvas.ImageViewer.Explorer.Local.DicomImageLoaderTool
        private string[] BuildFileList(string[] paths)
        {
            List<string> fileList = new List<string>();

            foreach (string path in paths)
            {
                if (string.IsNullOrEmpty(path))
                    continue;

                if (File.Exists(path))
                    fileList.Add(path);
                else if (Directory.Exists(path))
                    fileList.AddRange(Directory.GetFiles(path, "*.*", SearchOption.AllDirectories));
            }
            fileList.RemoveAll(f => System.IO.Path.GetExtension(f).Equals(".xml",System.StringComparison.OrdinalIgnoreCase));

            return fileList.ToArray();
        }



        private void LocalImageExplorerComponentView_DragDropGotFile(object sender, System.EventArgs e)
        {
            string[] files = (string[])((DragEventArgs)e).Data.GetData(DataFormats.FileDrop);
            files = BuildFileList(files);
            new OpenFilesHelper(files) { WindowBehaviour = ViewerLaunchSettings.WindowBehaviour }.OpenFiles();

        }


        #region IApplicationComponentView Members

        public void SetComponent(IApplicationComponent component)
		{
			_component = component as LocalImageExplorerComponent;
		}

		#endregion

	}
}
