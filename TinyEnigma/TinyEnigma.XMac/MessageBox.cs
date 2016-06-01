﻿using AppKit;

namespace TinyEnigma.XMac
{
    public class MessageBox
    {
        public static void Show(string text, string title="")
        {
            var alert = new NSAlert()
            {
                AlertStyle = NSAlertStyle.Critical,
                InformativeText = text,
                MessageText = title,
            };
            alert.RunModal();
        }
    }
}

