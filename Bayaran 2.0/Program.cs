using Bayaran_2._0.forms;
using Bayaran_2._0.Forms;
using Bayaran_2._0.Model;
using Project_Bayaran.datamodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Bayaran_2._0
{
    static class Program
    {
        public static void terminate()
        {
            Application.Exit();
        }
        public static SettingsProvider _sp;
        public static app_settings _settings;
        public static void LoadSettings()
        {
            _sp = new SettingsProvider();
            _settings = _sp.getWholeData();
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppCentre.Translator = new Library.Translation(Properties.Settings.Default.translation_file);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!xmlClasses.settingFile_exist())
                Application.Run(new installer());
            else
            {
                LoadSettings();
                Application.Run(new Startup());
            }

        }
    }
}
