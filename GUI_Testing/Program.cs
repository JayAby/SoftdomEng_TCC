﻿using System;
using System.Windows.Forms;

namespace GUI_Testing
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home()); // Set the Home form as the startup form
        }
    }
}
