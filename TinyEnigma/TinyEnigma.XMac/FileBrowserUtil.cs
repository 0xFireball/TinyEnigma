using System;
using AppKit;

namespace TinyEnigma.XMac
{
    public class FileBrowserUtil
    {
        public static string BrowseForOpenFile(string[] allowedFileTypes, string title)
        {
            string selectedPath = null;
            var dlg = NSOpenPanel.OpenPanel;
            dlg.Title = title;
            dlg.CanChooseFiles = true;
            dlg.CanChooseDirectories = false;
            if (allowedFileTypes != null)
            {
                dlg.AllowedFileTypes = allowedFileTypes;
            }
            if (dlg.RunModal() == 1)
            {
                var url = dlg.Urls[0]; //First selected file
                //No need for null check because null is failure default
                selectedPath = url.Path;
            }
            return selectedPath;
        }

        public static string BrowseForSaveFile(string[] allowedFileTypes, string title)
        {
            string selectedPath = null;
            var dlg = new NSSavePanel();
            dlg.Title = title;
            if (allowedFileTypes != null)
            {
                dlg.AllowedFileTypes = allowedFileTypes;
            }
            if (dlg.RunModal() == 1)
            {
                var url = dlg.Url;
                selectedPath = url.Path;
            }
            return selectedPath;
        }
    }
}