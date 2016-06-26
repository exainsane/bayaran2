using Bayaran_2._0.Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bayaran_2._0
{
    public static class AppCentre
    {
        public static void Log(object str)
        {
            Console.WriteLine(str.ToString());
        }
        public static void Inform(string t, string c)
        {
            MessageBox.Show(t, c, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void SetButtonIcon(Bitmap icon, ref Button btn)
        {
            btn.Image = icon.GetThumbnailImage(20, 20, null, new IntPtr());
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
        }
        public static Translation Translator;
    }
}
