using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bayaran_2._0.Model;
using System.Data;
using Exainsane.Lib;
using Inventory.Model;
namespace Bayaran_2._0.Controller
{
    public class BaseController
    {
        public static mysqlClass NewConnection()
        {
            return new mysqlClass(Program._settings.ip, Program._settings.dbuser, Program._settings.dbpass, Program._settings.dbname);
        }
        protected static List<T> PullAllDataFrom<T>(string table = null) where T:new()
        {
            var adapter = NewConnection();
            DataSet ds = null;
            if (table == null)
            {
                table = Query.GetTableName(typeof(T));
            }
            string query = "SELECT * FROM " + table ;
            ds = null;
            adapter.setQuery(query, out ds);
            List<T> lst = new List<T>();
            if (ds.Tables[0] == null)
            {
                AppCentre.Log("Unable to load data");
                return lst;
            }            
                lst = ListCreator.CreateList<T>(ds.Tables[0]);
                return lst;            

        }
    }
}
