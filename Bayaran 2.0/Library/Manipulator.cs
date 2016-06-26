using Bayaran_2._0.Model;
using Inventory.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Exainsane.Lib
{
    public static class ListCreator
    {
        static mysqlClass database;
        public static DataTable Load(string tablename)
        {
            database = Query.NewConnection();
            DataSet ds;
            database.setQuery(string.Format("SELECT * FROM {0}", tablename), out ds);
            if (ds == null)
            {
                return null;
            }
            return ds.Tables[0];
        }
        public static List<T> CreateList<T>(DataTable table) where T : new()
        {            
            IList<PropertyInfo> properties = typeof(T).GetProperties().ToList();
            List<T> result = new List<T>();
            foreach (DataRow row in table.Rows)
            {
                result.Add(Create<T>(row, properties));
            }
            return result;
        }        
        public static T Create<T>(DataRow row, IList<PropertyInfo> properties) where T : new(){
            T item = new T();            
            foreach (var prop in properties)
            {
                if (!row.Table.Columns.Contains(prop.Name)) continue;
                if (prop.PropertyType == typeof(DateTime))
                {
                    DateTime d = DateTime.Parse(row[prop.Name].ToString());
                    prop.SetValue(item, d, null);
                }
                else if (prop.PropertyType == typeof(int))
                {
                    prop.SetValue(item, Convert.ToInt32(row[prop.Name]), null);
                }
                else if (prop.PropertyType == typeof(long))
                {
                    prop.SetValue(item, Convert.ToInt64(row[prop.Name]), null);
                }
                else if (prop.PropertyType == typeof(double))
                {
                    prop.SetValue(item, Convert.ToDouble(row[prop.Name]), null);
                }
                else if (prop.PropertyType == typeof(Single))
                {
                    prop.SetValue(item, Convert.ToSingle(row[prop.Name]), null);
                }
                else if (prop.PropertyType == typeof(decimal))
                {
                    prop.SetValue(item, Convert.ToDecimal(row[prop.Name]), null);
                }
                else if (prop.PropertyType == typeof(ReferencedValue))
                {
                    ReferencedValue rv = (ReferencedValue)typeof(T).GetProperty(prop.Name).GetValue(item, null);
                    rv.value = Convert.ToInt32(row[prop.Name]);
                    prop.SetValue(item, rv, null);
                }
                else if ((prop.PropertyType == typeof(bool)))
                {
                    prop.SetValue(item, Convert.ToSByte(row[prop.Name]) == 1, null);
                }
                else
                {
                    prop.SetValue(item, row[prop.Name], null);
                }                
            }
            return item;
        }
    }
    public class Manipulator
    {
        public static void unused_FetchClassTo<T>(T data, ref GroupBox box)
        {
            var controls = box.Controls;
            var properties = typeof(T).GetProperties().ToList();
            foreach (var property in properties)
            {
                for (int i = 0; i < controls.Count; i++)
                {
                    if (property.PropertyType == typeof(int) || property.PropertyType == typeof(long))
                    {
                        NumericUpDown n = controls[i] as NumericUpDown;
                        TextBox t = controls[i] as TextBox;
                        if (t != null && t.Name == property.Name)
                        {
                            t.Text = data.GetType().GetProperty(property.Name).GetValue(data, null).ToString();
                        }
                        else if (n != null && n.Name == property.Name)
                        {
                            n.Value = (Decimal)data.GetType().GetProperty(property.Name).GetValue(data, null);
                        }
                    }
                    else
                    {
                        TextBox t = controls[i] as TextBox;
                        if (t != null && t.Name == property.Name)
                        {
                            t.Text = data.GetType().GetProperty(property.Name).GetValue(data, null).ToString();
                        }
                    }
                }
            }
        }
        public static void FetchClassTo<T, P>(T data, ref P o)
        {
            var box = o as Control;
            var controls = box.Controls;
            var properties = typeof(T).GetProperties().ToList();
            foreach (var property in properties)
            {
                for (int i = 0; i < controls.Count; i++)
                {
                    if (property.Name == "_unique_field") continue;
                    NumericUpDown n = controls[i] as NumericUpDown;
                    TextBox t = controls[i] as TextBox;
                    Label l = controls[i] as Label; 
                    ComboBox c = controls[i] as ComboBox;
                    CheckBox chk = controls[i] as CheckBox;
                    if (t != null && t.Name == property.Name)
                    {
                        if(data.GetType().GetProperty(property.Name).GetValue(data, null) == null)
                            t.Text = "";
                        else
                            t.Text = data.GetType().GetProperty(property.Name).GetValue(data, null).ToString();
                    }
                    else if (n != null && n.Name == property.Name)
                    {
                        n.Value = Convert.ToDecimal(data.GetType().GetProperty(property.Name).GetValue(data, null));
                    }
                    else if (l != null && l.Name == property.Name)
                    {
                        if(data.GetType().GetProperty(property.Name).GetValue(data, null) == null)
                            l.Text = "";
                        else
                            l.Text = data.GetType().GetProperty(property.Name).GetValue(data, null).ToString();
                    }
                    else if (chk != null && chk.Name == property.Name)
                    {
                        chk.Checked = (bool)data.GetType().GetProperty(property.Name).GetValue(data, null);
                    }
                    else if (c != null && c.Name == property.Name && property.PropertyType == typeof(ReferencedValue))
                    {
                        ReferencedValue value = (ReferencedValue)property.GetValue(data, null);
                        c.SelectedValue = Convert.ToInt32(value.value);
                    }
                }
            }
        }
        public static T Discarded_FetchControlTo<T>(GroupBox box) where T : new()
        {
            T newt = new T();
            SetZeroValue<T>(ref newt);
            var properties = typeof(T).GetProperties().ToList();
            var controls = box.Controls;
            foreach (var item in controls)
            {
                TextBox t = item as TextBox;
                if (t != null)
                {
                    try
                    {
                        var property = (PropertyInfo)(from PropertyInfo prop in properties
                                                      where prop.Name == t.Name
                                                      select prop).ToList().First();
                        InsertProperty(ref property, ref newt, t.Text);
                        continue;
                    }
                    catch (Exception e)
                    {
                        throw new Exception("Element not Found : " + e.Message.ToString());
                    }
                }

                NumericUpDown n = item as NumericUpDown;
                if (n != null)
                {
                    var property = (PropertyInfo)(from PropertyInfo prop in properties
                                                  where prop.Name == n.Name
                                                  select prop).ToList().First();
                    InsertProperty(ref property, ref newt, n.Value.ToString());
                    continue;
                }                

                DateTimePicker dt = item as DateTimePicker;
                if (dt != null)
                {
                    var property = (PropertyInfo)(from PropertyInfo prop in properties
                                                  where prop.Name == dt.Name
                                                  select prop).ToList().First();
                    InsertProperty(ref property, ref newt, n.Value.ToString());
                    continue;
                }

            }
            return newt;
        }
        public static T FetchControlTo<T>(Control box) where T : new()
        {
            T newt = new T();
            SetZeroValue<T>(ref newt);
            var properties = typeof(T).GetProperties().ToList();
            var controls = box.Controls;
            foreach (var item in controls)
            {                
                TextBox t = item as TextBox;
                if (t != null)
                {
                    try
                    {
                        var propchk = (from PropertyInfo prop in properties
                                                      where prop.Name == t.Name
                                                      select prop).ToList();
                        if (propchk.Count < 1) continue;
                        var property = (PropertyInfo)propchk.First();
                        InsertProperty(ref property, ref newt, t.Text);
                        continue;
                    }
                    catch (Exception e)
                    {
                        throw new Exception("Element not Found : " + e.Message.ToString());
                    }
                }

                NumericUpDown n = item as NumericUpDown;
                if (n != null)
                {
                    var propchk = (from PropertyInfo prop in properties
                                   where prop.Name == n.Name
                                   select prop).ToList();
                    if (propchk.Count < 1) continue;
                    var property = (PropertyInfo)propchk.First();
                    InsertProperty(ref property, ref newt, n.Value.ToString());
                    continue;
                }

                DateTimePicker dp = item as DateTimePicker;
                if (dp != null)
                {
                    var propchk = (from PropertyInfo prop in properties
                                   where prop.Name == dp.Name
                                   select prop).ToList();
                    if (propchk.Count < 1) continue;
                    var property = (PropertyInfo)propchk.First();
                    InsertProperty(ref property, ref newt, dp.Value.ToString());
                    continue;
                }
                CheckBox chk = item as CheckBox;
                if (chk != null)
                {
                    var property = (PropertyInfo)(from PropertyInfo prop in properties
                                                  where prop.Name == chk.Name
                                                  select prop).ToList().First();
                    InsertProperty(ref property, ref newt, chk.Checked.ToString());
                    continue;
                }
                ComboBox cb = item as ComboBox;
                if (cb != null)
                {
                    var propchk = (from PropertyInfo prop in properties
                                   where prop.Name == cb.Name
                                   select prop).ToList();
                    if (propchk.Count < 1) continue;
                    var property = (PropertyInfo)propchk.First();
                    InsertProperty(ref property, ref newt, Convert.ToInt32(cb.SelectedValue).ToString());
                    continue;
                }
    

            }
            return newt;
        }
        private static void InsertProperty<T>(ref PropertyInfo prop, ref T obj, string str)
        {
            if (prop.PropertyType == typeof(string))
            {
                prop.SetValue(obj, str, null);
            }
            else if (prop.PropertyType == typeof(int))
            {
                Regex r = new Regex(@"\d+");
                Match match = r.Match(str);
                prop.SetValue(obj, Convert.ToInt32(match.Value), null);
            }
            else if (prop.PropertyType == typeof(long))
            {
                Regex r = new Regex(@"\d+");
                Match match = r.Match(str);
                prop.SetValue(obj, Convert.ToInt64(match.Value), null);
            }
            else if (prop.PropertyType == typeof(double))
            {
                prop.SetValue(obj, Convert.ToDouble(str), null);
            }
            else if (prop.PropertyType == typeof(decimal))
            {
                Regex r = new Regex(@"\d+");
                Match match = r.Match(str);
                prop.SetValue(obj, Convert.ToDecimal(match.Value), null);

            }
            else if (prop.PropertyType == typeof(DateTime))
            {
                prop.SetValue(obj, DateTime.Parse(str), null);
            }
            else if (prop.PropertyType == typeof(bool))
            {
                prop.SetValue(obj, str.ToLower() == "true", null);
            }
            else if (prop.PropertyType == typeof(ReferencedValue))
            {

                ReferencedValue R = (ReferencedValue)prop.GetValue(obj, null);
                R.value = Convert.ToInt32(str);
                DumpObject(R);
                prop.SetValue(obj, R, null);
                
            }
        }
        public static void SetZeroValue<T>(ref T obj)
        {
            var properties = typeof(T).GetProperties().ToList();
            foreach (var item in properties)
            {
                if (item.PropertyType == typeof(string)) item.SetValue(obj, string.Empty, null);
                else if (
                    item.PropertyType == typeof(int) ||
                    item.PropertyType == typeof(long) ||
                    item.PropertyType == typeof(float) ||
                    item.PropertyType == typeof(double)) item.SetValue(obj, 0, null);
                else if (item.PropertyType == typeof(DateTime)) item.SetValue(obj, DateTime.Now, null);                
            }
        }
        public static void DumpObject(object ndata)
        {
            foreach (var n in ndata.GetType().GetProperties().ToList())
            {
                if (n.PropertyType == typeof(ReferencedValue))
                {
                    Console.WriteLine(n.Name + "=>" + ((ReferencedValue)ndata.GetType().GetProperty(n.Name).GetValue(ndata, null)).value);
                    continue;
                }
                Console.WriteLine(n.Name + "=>" + ndata.GetType().GetProperty(n.Name).GetValue(ndata, null));
            }
        }
        public class FormValidator
        {
            public static bool AutoValidate(Control.ControlCollection cc)
            {
                return new FormValidator().validateform(cc);
            }
            int numnotpassed = 0;
            public bool validateform(Control.ControlCollection cc)
            {
                foreach (Control item in cc)
                {
                    TextBox t = item as TextBox;
                    ComboBox c = item as ComboBox;
                    NumericUpDown n = item as NumericUpDown;
                    if (t != null)
                    {
                        if (t.Text == "" && t.Visible == true)
                        {
                            t.Focus();
                            Console.WriteLine("Validate : fail - " + t.Name);
                            numnotpassed++;
                            continue;
                        }
                    }
                    else
                        validateform(item.Controls);

                    if (c != null)
                    {
                        if (c.SelectedIndex == -1)
                        {
                            c.Focus();
                            Console.WriteLine("Validate : fail - " + c.Name);
                            numnotpassed++;
                            continue;
                        }
                    }
                    else
                        validateform(item.Controls);

                    if (n != null)
                    {
                        if (n.Value < 0)
                        {
                            n.Focus();
                            Console.WriteLine("Validate : fail - " + n.Name);
                            numnotpassed++;
                            continue;
                        }
                    }
                    else
                        validateform(item.Controls);

                }
                return !(numnotpassed != 0);
            }
        }
        //public static void SetReportParameterValue(LocalReport rpt, string param_name, string str)
        //{
        //    var is_param_exist = (from i in rpt.GetParameters().ToList()
        //                          where i.Name == param_name
        //                          select i).Count() == 1;
        //    if (is_param_exist)
        //        rpt.SetParameters(new ReportParameter(param_name, str));
        //}
    }
}
