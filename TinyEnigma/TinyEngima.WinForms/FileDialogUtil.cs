/*
 */
using System;
using System.Windows.Forms;

namespace TinyEngima.WinForms
{
	public class FileDialogUtil
	{
		public static string BrowseForSaveFile(string filter, string title)
        {
            var sfd = new SaveFileDialog
            {
                Filter = filter,
                Title = title
            };
            var showDialog = sfd.ShowDialog();
            if (showDialog == DialogResult.OK)
            {
                return sfd.FileName;
            }
            return null;
        }

        public static string BrowseForOpenFile(string filter, string title)
        {
            var ofd = new OpenFileDialog
            {
                Filter = filter,
                Title = title,
                Multiselect = false
            };
            var showDialog = ofd.ShowDialog();
            if (showDialog == DialogResult.OK)
            {
                return ofd.FileName;
            }
            return null;
        }
	}
}
