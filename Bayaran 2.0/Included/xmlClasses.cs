using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
namespace Project_Bayaran.datamodel
{
    static class xmlClasses
    {
        static private string settingFile = Directory.GetCurrentDirectory() + @"\settings.set";
        static public bool settingFile_exist()
        {
            return File.Exists(settingFile);
        }
        static public void writeXML(app_settings setting)
        {
            try
            {
                System.Xml.Serialization.XmlSerializer Setting = new System.Xml.Serialization.XmlSerializer(typeof(app_settings));
                System.IO.StreamWriter file = new System.IO.StreamWriter(settingFile);
                Setting.Serialize(file, setting);
                file.Close();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        static public app_settings getDefaultSettings()
        {
            app_settings setting = new app_settings();
            setting.db = "";            
            setting.dbuser = "root";
            setting.dbpass = "";
            setting.dbname = "bayaran";
            setting.ip = "localhost";
            //setting.debugmode = "0";
            return setting;
        }
        static public app_settings readXML()
        {
            System.Xml.Serialization.XmlSerializer reader;
            System.IO.StreamReader file = null; 
            app_settings se = new app_settings();
            try
            {
                reader = new System.Xml.Serialization.XmlSerializer(se.GetType());
                if (!File.Exists(settingFile))
                {
                    writeXML(xmlClasses.getDefaultSettings()); 
                }
                file = new System.IO.StreamReader(settingFile);
                se = (app_settings)reader.Deserialize(file);
                return se;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error opening settings file");
                Application.Exit();
            }
            catch (NullReferenceException) { }         
            finally
            {                
                file.Close();
            }
            return null;                               
        }
    }
    public class SettingsProvider
    {
        private app_settings Settings;
        public SettingsProvider()
        {
            load();
            
        }
        private void load()
        {
            var storedS = xmlClasses.readXML();
            for (int i = 0; i < 3; i++)
            {
                if (storedS == null)
                {
                    storedS = xmlClasses.readXML();
                    if (i == 2)
                    {
                        throw new Exception("Error reading settings!");
                    }
                }
                else break;
            }
            Settings = storedS;
        }
        public void setSettings(app_settings set)
        {
            xmlClasses.writeXML(set);
        }
        public app_settings getWholeData()
        {
            load();
            return Settings;
        }
    }
    public class app_settings
    {
        private string _db = null;
        public string db
        {
            get
            {
                return _db == null ? "" : _db;
            }
            set
            {
                _db = value;
            }
        }
        private string _ip = null;
        public string ip
        {
            get
            {
                return _ip == null ? "" : _ip;
            }
            set
            {
                _ip = value;
            }
        }
        private string _dbuser = null;
        public string dbuser
        {
            get
            {
                return _dbuser == null ? "" : _dbuser;
            }
            set
            {
                _dbuser = value;
            }
        }
        private string _dbpass = null;
        public string dbpass
        {
            get
            {
                return _dbpass == null ? "" : _dbpass;
            }
            set
            {
                _dbpass = value;
            }
        }
        private string _dbname = null;
        public string dbname
        {
            get
            {
                return _dbname == null ? "" : _dbname;
            }
            set
            {
                _dbname = value;
            }
        }
        private string _debugmode = "0";
        public string app_debug
        {
            get
            {
                return _debugmode;
            }
            set
            {
                _debugmode = value;
            }
        }
    }
}

