using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bayaran_2._0.Library
{
    public class Translation
    {                
        Dictionary<string, string> dict;
        void _instantiate()
        {
            dict = new Dictionary<string, string>();
        }
        public Translation(string translationtext)
        {
            _instantiate();
            SetTranslationFile(translationtext);
        }
        public Translation()
        {
            _instantiate();
        }
        public void SetTranslationFile(string translationtext){
            try
            {
                
                using (StreamReader reader = new StreamReader(translationtext))
                {
                    while (!reader.EndOfStream)
                    {
                        string readed = reader.ReadLine();
                        //AppCentre.Log("Read : " + readed);
                        string[] readedarr = readed.Split(':');
                        //AppCentre.Log(readedarr.ToString());
                        if (readedarr.Count() == 2) //Format : <string>:<translated>
                        {
                            dict.Add(readedarr[0], readedarr[1]);
                        }
                    }                    
                }
            }
            catch (FileNotFoundException)
            {
                AppCentre.Log("file not found");
                return;
            }
            catch (DirectoryNotFoundException)
            {
                AppCentre.Log("dir not found");
                return;
            }
        }
        public string Translate(string str)
        {
            List<string> translated = (from i in dict
                                 where i.Key == str
                                 select i.Value).ToList();
            if (translated.Count() > 0)
                return translated.First().Replace('_',' ');
            else return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
        }
        public void TranslateControl(System.Windows.Forms.Control.ControlCollection control, bool ignorecase = true){
            foreach (Control c in control)
            {
                Label L = c as Label;
                if (L != null)
                {                    
                    string t = ignorecase ? c.Text.ToLower() : c.Text;
                    c.Text = Translate(t);                   
                }
                else
                    TranslateControl(c.Controls, ignorecase);
            }
        }
    }
}
