using Bayaran_2._0.Model;
using Exainsane.Lib;
using Inventory.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Bayaran_2._0.Controller
{
    public class ControllerTipetransaksi : BaseController
    {
        public event ControllerDataLoaded DataLoaded;
        private List<DataStructure.ms_type_transaksi> _data;
        private List<DataStructure.ms_type_transaksi> _filtered = null;
        public List<DataStructure.ms_type_transaksi> Data
        {
            get
            {
                return _filtered != null ? _filtered : _data;
            }
            set
            {
                if (_data != value)
                    _data = value;
                NotifyDataLoaded();
            }
        }
        private void NotifyDataLoaded()
        {
            if (DataLoaded != null)
                DataLoaded();
        }
        public bool Like(object o, string str)
        {
            return o.ToString().ToLower().Contains(str);
        }
        public void Filter(string q)
        {
            if (q.Length == 0)
            {
                ClearFilter();
                return;
            }
            _filtered = (from data in _data
                         where
                         Like(data.tipe_transaksi, q) 
                         select data).ToList();
            NotifyDataLoaded();
        }
        public void ClearFilter()
        {
            this._filtered = null;
        }
        public void Load()
        {
            string query = "SELECT * FROM ms_type_transaksi order by timestamp";
            var adapter = NewConnection();

            DataSet ds = null;
            adapter.setQuery(query, out ds);
            if (ds.Tables[0] == null) AppCentre.Log("Unable to load data");

            _data = ListCreator.CreateList<DataStructure.ms_type_transaksi>(ds.Tables[0]);

            NotifyDataLoaded();
        }
        public bool Update(DataStructure.ms_type_transaksi data)
        {
            return Query.Update<DataStructure.ms_type_transaksi>(data) > 0;
        }
        public bool Insert(DataStructure.ms_type_transaksi data)
        {
            return Query.Insert<DataStructure.ms_type_transaksi>(data) > 0;
        }
        public bool Delete(DataStructure.ms_type_transaksi data)
        {
            return Query.Delete<DataStructure.ms_type_transaksi>(data.id) > 0;
        }
    }
}
