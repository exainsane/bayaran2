using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Project_Bayaran.classes
{
    static public class locker
    {
        public static void lockform(Control.ControlCollection cc, bool locked)
        {
            foreach (Control item in cc)
            {
                TextBox t = item as TextBox;
                if (t != null)
                    t.Enabled = !locked;
                else
                    lockform(item.Controls, locked);

                ComboBox c = item as ComboBox;
                if (c != null)
                    c.Enabled = !locked;
                else
                    lockform(item.Controls, locked);

                Button b = item as Button;
                if (b != null)
                    b.Enabled = !locked;
                else
                    lockform(item.Controls, locked);

                NumericUpDown n = item as NumericUpDown;
                if (n != null)
                    n.Enabled = !locked;
                else
                    lockform(item.Controls, locked);
            }
        }
        public static void clearform(Control.ControlCollection cc)
        {
            foreach (Control item in cc)
            {
                TextBox t = item as TextBox;
                if (t != null)
                    t.Text = "";
                else
                    clearform(item.Controls);

                ComboBox c = item as ComboBox;
                if (c != null)
                    c.SelectedIndex = -1;
                else
                    clearform(item.Controls);
                
            }
        }
        
        private static void message(string str)
        {
            MessageBox.Show(str, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void setTimeout(int time, Action action)
        {
            Timer timer = new Timer();
            int tick = 0;
            timer.Interval = time;
            timer.Tick += new EventHandler((sender, e) =>
            {
                action();
                tick++;
                if (tick > 0) timer.Stop();
            });
            timer.Start();
        }
    }
    public class FormValidator
    {
        int numnotpassed = 0;
        public bool validateform(Control.ControlCollection cc)
        {            
            foreach (Control item in cc)
            {
                TextBox t = item as TextBox;
                ComboBox c = item as ComboBox;
                if (t != null)
                {
                    if (t.Text == "")
                    {
                        t.BackColor = System.Drawing.Color.Red;
                        locker.setTimeout(3000, () =>
                        {
                            t.BackColor = System.Drawing.Color.White;
                        });
                        t.Focus();
                        numnotpassed++;
                    }
                }
                else
                    validateform(item.Controls);

                if (c != null)
                {
                    if (c.SelectedIndex == -1)
                    {
                        c.Focus();
                        numnotpassed++;
                    }
                }
                else
                    validateform(item.Controls);

            }            
            return (numnotpassed == 0);
        }
    }
}
