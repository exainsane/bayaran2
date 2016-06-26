using Bayaran_2._0.Model;
using Exainsane.Lib;
using Inventory.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;

namespace Bayaran_2._0.Controller
{
    public class ControllerMhs : BaseController
    {
        public event ControllerDataLoaded DataLoaded;
        private List<DataStructure.ms_mhs> _data;
        private List<DataStructure.ms_mhs> _filtered = null;
        public List<DataStructure.ms_mhs> Data
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
        private void NotifyDataLoaded(){
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
                         Like(data.jurusan, q) ||
                         Like(data.nama, q) ||
                         Like(data.nim, q) ||
                         Like(data.prodi, q) ||
                         Like(data.angkatan, q) ||
                         Like(data.fakultas, q)
                         select data).ToList();
            NotifyDataLoaded();
        }
        public void ClearFilter()
        {
            this._filtered = null;
            NotifyDataLoaded();
        }
        public void Load()
        {
            Thread T = new Thread((ThreadStart)delegate
            {
                string query = "SELECT * FROM ms_mhs order by nama";
                var adapter = NewConnection();

                DataSet ds = null;
                adapter.setQuery(query, out ds);
                if (ds.Tables[0] == null) AppCentre.Log("Unable to load data");

                _data = ListCreator.CreateList<DataStructure.ms_mhs>(ds.Tables[0]);

                NotifyDataLoaded();
            });
            T.Start();
        }
        public bool Update(DataStructure.ms_mhs data)
        {
            return Query.Update<DataStructure.ms_mhs>(data) > 0;
        }
        public bool Insert(DataStructure.ms_mhs data)
        {
            return Query.Insert<DataStructure.ms_mhs>(data) > 0;
        }
        public bool Delete(DataStructure.ms_mhs data)
        {
            return Query.Delete<DataStructure.ms_mhs>(data.id) > 0;
        }
    }
}
