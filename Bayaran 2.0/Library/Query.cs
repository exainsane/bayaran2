
using Bayaran_2._0.Controller;
using Bayaran_2._0.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;


namespace Inventory.Model
{
    public static class Query
    {
        public static string FinalQuery = "";
        public static mysqlClass NewConnection()
        {
            
            return BaseController.NewConnection();
        }
        public static int Delete<T>(int id)
        {
            string table = typeof(T).Name.Split('.').Last();
            string q = string.Format("DELETE FROM {0} WHERE id={1}", table, id.ToString());
            return NewConnection().setQuery(q);
        }
        public static int Disable<T>(int id)
        {
            string table = typeof(T).Name.Split('.').Last();
            string q = string.Format("UPDATE {0} SET enable=0 WHERE id={1}", table, id.ToString());
            return NewConnection().setQuery(q);
        }
        public static int Update<T>(T data)
        {
            IList<PropertyInfo> properties = typeof(T).GetProperties().ToList();   
            string table = typeof(T).Name.Split('.').Last();
            string _base = "UPDATE {0} SET {1} WHERE id={2}";
            string _edit = "";
            string id = data.GetType().GetProperty("id").GetValue(data, null).ToString();
            for (int i = 0; i < properties.Count; i++)
            {
                if (properties[i].Name == "id") continue;
                if (properties[i].Name == "_unique_field") continue;
                _edit += "`" + (properties[i].Name) + "`";
                _edit += "=";
                if (properties[i].Name == "timestamp")
                {
                    _edit += "CURRENT_TIMESTAMP";                                        
                }
                else if (properties[i].PropertyType == typeof(int) || properties[i].PropertyType == typeof(long) || properties[i].PropertyType == typeof(double))
                {
                    _edit += data.GetType().GetProperty(properties[i].Name).GetValue(data, null).ToString();
                }
                else if (properties[i].PropertyType == typeof(ReferencedValue))
                {
                    _edit += ((ReferencedValue)properties[i].GetValue(data, null)).value;
                }
                else
                {
                    _edit += @"'" + data.GetType().GetProperty(properties[i].Name).GetValue(data, null).ToString() + @"'";
                }
                if (i < properties.Count - 1)
                {
                    _edit += ", ";
                }
            }
            string finalquery = string.Format(_base, table, _edit, id);
            FinalQuery = finalquery;
            return NewConnection().setQuery(finalquery);
        }
        public static string GetTableName(Type T)
        {
            return T.Name.Split('.').Last();
        }
        public static int Insert<T>(T data, bool allowduplicate = false)
        {
            IList<PropertyInfo> properties = typeof(T).GetProperties().ToList();               
            string _base = "INSERT INTO {0} ({1}) VALUES ({2})";
            string table = GetTableName(typeof(T));
            List<string> _fields = new List<string>();
            List<string> _ins = new List<string>();
            if (allowduplicate) goto startprc;
            goto skip;
            #region checkduplicate method 1
            PropertyInfo chkfld = data.GetType().GetProperty("_unique_field");
            if (chkfld != null)
            {
                string checkclm = chkfld.GetValue(data, null).ToString();

                PropertyInfo chkinf = data.GetType().GetProperty(checkclm);
                if (chkinf != null)
                {
                    string chkval;
                    if (chkinf.PropertyType == typeof(ReferencedValue))
                    {
                        chkval = ((ReferencedValue)chkinf.GetValue(data, null)).value.ToString();
                    }
                    else
                    {
                        chkval = chkinf.GetValue(data, null).ToString();
                    }

                    string chkquery = string.Format("SELECT {0} FROM {1} where {0}='{2}'", checkclm, table, chkval);
                    DataSet ds = null;
                    if (NewConnection().setQuery(chkquery, out ds) > 0)
                    {
                        return 0;
                    }
                }

            }
            #endregion
            skip:
            {
                string _basechk = "SELECT * FROM {0} where {1}";
                List<string> _flds = new List<string>();
                for (int i = 0; i < properties.Count; i++)
                {
                    if (properties[i].Name == "_unique_field") continue;
                    if (properties[i].Name == "id") continue;
                    if (properties[i].Name == "timestamp") continue;
                    if (properties[i].PropertyType == typeof(int) ||
                        properties[i].PropertyType == typeof(long) ||
                        properties[i].PropertyType == typeof(decimal))
                    {
                        _flds.Add("`" + properties[i].Name + "`=" + data.GetType().GetProperty(properties[i].Name).GetValue(data, null).ToString());
                    }

                    else if (properties[i].PropertyType == typeof(ReferencedValue))
                    {
                        _flds.Add("`" + properties[i].Name + "`=" + ((ReferencedValue)properties[i].GetValue(data, null)).value);
                    }
                    else
                    {
                        _flds.Add("`" + properties[i].Name + @"`='" + data.GetType().GetProperty(properties[i].Name).GetValue(data, null).ToString() + @"'");
                    }                    
                }
                DataSet a;                
                if (NewConnection().setQuery(string.Format(_basechk, table, string.Join(" AND ",_flds.ToArray())), out a) > 0) return 0;
            }
            startprc:
            for (int i = 0; i < properties.Count; i++)
            {
                if (properties[i].Name == "_unique_field") continue;
                if (properties[i].Name == "id") continue;
                _fields.Add("`" + (properties[i].Name) + "`");
                if (properties[i].Name == "timestamp")
                {
                    _ins.Add("CURRENT_TIMESTAMP");
                    continue;
                }
                if (properties[i].PropertyType == typeof(int) ||
                    properties[i].PropertyType == typeof(long) ||
                    properties[i].PropertyType == typeof(decimal))
                {
                    _ins.Add(data.GetType().GetProperty(properties[i].Name).GetValue(data, null).ToString());
                }
                else if (properties[i].PropertyType == typeof(bool))
                {
                    _ins.Add(((bool)properties[i].GetValue(data, null)) == true ? "1" : "0");
                }
                else if (properties[i].PropertyType == typeof(ReferencedValue))
                {
                    _ins.Add(((ReferencedValue)properties[i].GetValue(data, null)).value.ToString());
                }
                else
                {
                    _ins.Add(@"'" + data.GetType().GetProperty(properties[i].Name).GetValue(data, null).ToString() + @"'");
                }               
            }
            string finalquery = string.Format(_base, table, string.Join(",", _fields.ToArray()), string.Join(",", _ins.ToArray()));
            FinalQuery = finalquery;
            return NewConnection().setQuery(finalquery);
        }
        public static int InsertReplace<T>(T data)
        {
            IList<PropertyInfo> properties = typeof(T).GetProperties().ToList();
            string _base = "REPLACE INTO {0} ({1}) VALUES ({2})";
            string table = GetTableName(typeof(T));
            List<string> _fields = new List<string>();
            List<string> _ins = new List<string>();
            goto skip;
            #region checkduplicate method 1
            PropertyInfo chkfld = data.GetType().GetProperty("_unique_field");
            if (chkfld != null)
            {
                string checkclm = chkfld.GetValue(data, null).ToString();

                PropertyInfo chkinf = data.GetType().GetProperty(checkclm);
                if (chkinf != null)
                {
                    string chkval;
                    if (chkinf.PropertyType == typeof(ReferencedValue))
                    {
                        chkval = ((ReferencedValue)chkinf.GetValue(data, null)).value.ToString();
                    }
                    else
                    {
                        chkval = chkinf.GetValue(data, null).ToString();
                    }

                    string chkquery = string.Format("SELECT {0} FROM {1} where {0}='{2}'", checkclm, table, chkval);
                    DataSet ds = null;
                    if (NewConnection().setQuery(chkquery, out ds) > 0)
                    {
                        return 0;
                    }
                }

            }
            #endregion
        skip:
            {
                string _basechk = "SELECT * FROM {0} where {1}";
                List<string> _flds = new List<string>();
                for (int i = 0; i < properties.Count; i++)
                {
                    if (properties[i].Name == "_unique_field") continue;
                    if (properties[i].Name == "id") continue;
                    if (properties[i].Name == "timestamp") continue;
                    if (properties[i].PropertyType == typeof(int) ||
                        properties[i].PropertyType == typeof(long) ||
                        properties[i].PropertyType == typeof(decimal))
                    {
                        _flds.Add("`" + properties[i].Name + "`=" + data.GetType().GetProperty(properties[i].Name).GetValue(data, null).ToString());
                    }

                    else if (properties[i].PropertyType == typeof(ReferencedValue))
                    {
                        _flds.Add("`" + properties[i].Name + "`=" + ((ReferencedValue)properties[i].GetValue(data, null)).value);
                    }
                    else
                    {
                        _flds.Add("`" + properties[i].Name + @"`='" + data.GetType().GetProperty(properties[i].Name).GetValue(data, null).ToString() + @"'");
                    }
                }
                DataSet a;
                if (NewConnection().setQuery(string.Format(_basechk, table, string.Join(" AND ", _flds.ToArray())), out a) > 0) return 0;
            }

            for (int i = 0; i < properties.Count; i++)
            {
                if (properties[i].Name == "_unique_field") continue;
                if (properties[i].Name == "id") continue;
                _fields.Add("`" + (properties[i].Name) + "`");
                if (properties[i].Name == "timestamp")
                {
                    _ins.Add("CURRENT_TIMESTAMP");
                    continue;
                }
                if (properties[i].PropertyType == typeof(int) ||
                    properties[i].PropertyType == typeof(long) ||
                    properties[i].PropertyType == typeof(decimal))
                {
                    _ins.Add(data.GetType().GetProperty(properties[i].Name).GetValue(data, null).ToString());
                }
                else if (properties[i].PropertyType == typeof(bool))
                {
                    _ins.Add(((bool)properties[i].GetValue(data, null)) == true ? "1" : "0");
                }
                else if (properties[i].PropertyType == typeof(ReferencedValue))
                {
                    _ins.Add(((ReferencedValue)properties[i].GetValue(data, null)).value.ToString());
                }
                else
                {
                    _ins.Add(@"'" + data.GetType().GetProperty(properties[i].Name).GetValue(data, null).ToString() + @"'");
                }
            }
            string finalquery = string.Format(_base, table, string.Join(",", _fields.ToArray()), string.Join(",", _ins.ToArray()));
            FinalQuery = finalquery;
            return NewConnection().setQuery(finalquery);
        }
        public static int Insert<T>(T data, out int insert_id)
        {
            IList<PropertyInfo> properties = typeof(T).GetProperties().ToList();
            string table = typeof(T).Name.Split('.').Last();
            string _base = "INSERT INTO {0} ({1}) VALUES ({2})";
            string _fields = "";
            string _ins = "";
            for (int i = 0; i < properties.Count; i++)
            {
                if (properties[i].Name == "id") continue;
                _fields += "`" + (properties[i].Name) + "`";
                if (properties[i].Name == "timestamp")
                {
                    _ins += "CURRENT_TIMESTAMP";
                    continue;
                }
                if (properties[i].PropertyType == typeof(int))
                {
                    _ins += data.GetType().GetProperty(properties[i].Name).GetValue(data, null).ToString();
                }
                else
                {
                    _ins += @"'" + data.GetType().GetProperty(properties[i].Name).GetValue(data, null).ToString() + @"'";
                }
                if (i < properties.Count - 1)
                {
                    _ins += ",";
                    _fields += ",";
                }
            }
            string finalquery = string.Format(_base, table, _fields, _ins) + ";SELECT LAST_INSERT_ID() as inserted";
            DataSet ds;
            int queryresult = NewConnection().setQuery(finalquery, out ds);           
            try
            {
                insert_id = Convert.ToInt32(ds.Tables[0].Rows[0]["inserted"]);
            }
            catch (NullReferenceException ne)
            {
                insert_id = -1;
                Console.WriteLine(ne.ToString());
            }
            catch (IndexOutOfRangeException ior)
            {
                insert_id = -1;
                Console.WriteLine(ior);
            }
            return queryresult;
        }
        public static void LoadReference(string tablename, string key, string value, ref ComboBox cb)
        {
            var c = NewConnection();
            DataSet ds;
            try
            {
                c.setQuery(string.Format("SELECT {0},{1} FROM {2}", key, value, tablename), out ds);
                Dictionary<int, string> dct = new Dictionary<int, string>();
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    dct.Add(Convert.ToInt32(item[key]), item[value].ToString());                    
                }                
                cb.ValueMember = "Key";
                cb.DisplayMember = "Value";
                cb.DataSource = new BindingSource(dct, null);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
    }
}
