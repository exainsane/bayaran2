using Bayaran_2._0.Model;
using Exainsane.Lib;
using Inventory.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bayaran_2._0.Forms
{
    public partial class inputform : Form
    {
        bool isnew = true;
        private string[] lockedcontrols = { "id", "timestamp", "_unique_field" };
        public event FormFinishEditing OnFinishEditing;
        private string title;
        private Type frmtype;
        object refobj;
        public inputform(object t, string title, bool isupdate = false)
        {
            InitializeComponent();
            frmtype = t.GetType();
            refobj = t;
            this.title = title;
            this.Text = this.title;
            lbttl.Text = this.title;
            this.isnew = !isupdate;
        }
        public void Fill<T>(T t)
        {
            Manipulator.FetchClassTo<T, FlowLayoutPanel>(t, ref FormFlow);
            isnew = false;
        }
        public void Render()
        {             
            var props = this.frmtype.GetProperties().ToList();
            foreach (var prop in props)
            {
                if ((from l in lockedcontrols.ToList() where l == prop.Name select l).Count() > 0)
                {
                    if (!isnew)
                    {
                        TextBox ctr = new TextBox();
                        ctr.Width = 230;
                        ctr.Name = prop.Name;
                        ctr.Text = "";
                        ctr.Visible = false;

                        FormFlow.Controls.Add(ctr);
                    }
                    continue;
                }                
                Label L = new Label();
                L.AutoSize = true;
                L.Font = new Font(FontFamily.GenericSansSerif, 11.0f);
                L.Text = prop.Name.ToUpper().Replace('_',' ');
                FormFlow.Controls.Add(L);
                if (prop.PropertyType == typeof(int))
                {
                    NumericUpDown ctr = new NumericUpDown();
                    ctr.Width = FormFlow.Width - 35;
                    ctr.Name = prop.Name;
                    ctr.Maximum = int.MaxValue;

                    FormFlow.Controls.Add(ctr);
                }
                else if (prop.PropertyType == typeof(long))
                {
                    NumericUpDown ctr = new NumericUpDown();
                    ctr.Width = FormFlow.Width - 35;
                    ctr.Name = prop.Name;
                    ctr.Maximum = long.MaxValue;

                    FormFlow.Controls.Add(ctr);
                }
                else if (prop.PropertyType == typeof(double))
                {
                    NumericUpDown ctr = new NumericUpDown();
                    ctr.Width = FormFlow.Width - 35;
                    ctr.Name = prop.Name;
                    ctr.Maximum = long.MaxValue;

                    FormFlow.Controls.Add(ctr);
                }
                else if (prop.PropertyType == typeof(decimal))
                {
                    NumericUpDown ctr = new NumericUpDown();
                    ctr.Width = FormFlow.Width - 35;
                    ctr.Name = prop.Name;
                    ctr.Maximum = long.MaxValue;

                    FormFlow.Controls.Add(ctr);
                }
                else if (prop.PropertyType == typeof(DateTime))
                {
                    DateTimePicker ctr = new DateTimePicker();
                    ctr.Width = FormFlow.Width - 35;
                    ctr.Name = prop.Name;
                    ctr.Value = DateTime.Now;                    

                    FormFlow.Controls.Add(ctr);
                }
                else if (prop.PropertyType == typeof(string))
                {
                    TextBox ctr = new TextBox();
                    ctr.Width = FormFlow.Width - 35;
                    ctr.Name = prop.Name;
                    ctr.Text = "";

                    FormFlow.Controls.Add(ctr);
                }
                else if (prop.PropertyType == typeof(ReferencedValue))
                {
                    ComboBox ctr = new ComboBox();                    
                    ReferencedValue p = (ReferencedValue)prop.GetValue(this.refobj, null);

                    ctr.Width = 230;
                    ctr.Name = prop.Name;
                    Query.LoadReference(p.tname, p.keycol, p.valuecol, ref ctr);                   

                    FormFlow.Controls.Add(ctr);
                }
                else if (prop.PropertyType == typeof(bool))
                {
                    CheckBox ctr = new CheckBox();
                    
                    ctr.Width = 230;
                    ctr.Name = prop.Name;                    

                    FormFlow.Controls.Add(ctr);
                }
            }

        }
        private void inputform_Load(object sender, EventArgs e)
        {
            Render();
            AppCentre.Translator.TranslateControl(this.Controls);

            AppCentre.SetButtonIcon(Properties.Resources.ic_ok, ref bfinish);
            AppCentre.SetButtonIcon(Properties.Resources.ic_cancel, ref bcancel);
        }
        private void FinishForm(){
            if (!Exainsane.Lib.Manipulator.FormValidator.AutoValidate(FormFlow.Controls)) return;
                        
            if (OnFinishEditing != null)
            {
                OnFinishEditing(FormFlow, isnew);                
            }
        }
        private void bfinish_Click(object sender, EventArgs e)
        {
            FinishForm();            
        }

        private void bcancel_Click(object sender, EventArgs e)
        {
            Hide();
            Dispose();
        }
    }
}
