using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bayaran_2._0.Model
{
    public delegate void ControllerDataLoaded();
    public delegate void FormFinishEditing(Control c, bool newdata);
    public delegate void ControllerBatchUpdated(int x);
    public delegate void DatabaseUpdated();
    public delegate string GetString(object o);
    public delegate void VoidMethod();
    public static class Notifier
    {
        public static event DatabaseUpdated DBUpdated;
        public static void NotifyDBUpdate()
        {
            if (DBUpdated != null)
                DBUpdated();
        }
    }
}