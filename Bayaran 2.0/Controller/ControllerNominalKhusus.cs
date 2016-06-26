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
    public class ControllerNominalKhusus : BaseController
    {            
        public event ControllerDataLoaded DataLoaded;                
        #region Frontend data
        private List<DataStructure.as_nominal_khusus> _data;
        private List<DataStructure.as_nominal_khusus> _filtered = null;
        public List<DataStructure.as_nominal_khusus> Data
        {
            get
            {
                return _filtered != null ? _filtered : _data;
            }
            set
            {                
                _data = value;                
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
        public void Filter(string q, int fltr=-99)
        {
            if (q.Length < 0 && fltr < 0) { ClearFilter(); goto exitq; }
            filter1:            
            _filtered = (from data in _data
                         where
                         Like(data.nominal, q) ||
                         Like(data.id_mhs.ToString(), q)
                         select data).ToList();
            filter2:
            if (fltr < 0) goto exitq;
            _filtered = (from data in _filtered
                         where
                         data.tipe_transaksi.value == fltr
                         select data).ToList();
            exitq:
            NotifyDataLoaded();
        }
        public void FilterTipeTrans(int id, string q)
        {
            if (id < 0)
            {
                ClearFilter();
                goto exitq;
            }            
            _filtered = (from data in _data
                         where
                         data.tipe_transaksi.value == id
                         select data).ToList();
            if (q.Length < 0) goto exitq;
            _filtered = (from data in _filtered
                         where
                         Like(data.nominal, q) ||
                         Like(data.id_mhs.ToString(), q)
                         select data).ToList();
            exitq:
            NotifyDataLoaded();
        }
        public void ClearFilter()
        {
            this._filtered = null;
        }
        public void Load()
        {
            ClearFilter();
            LoadDataMhs();
            LoadDataAssign();
            LoadDataGolongan();
            LoadDataNominal();
            LoadDataNominalUmum();

            string query = "SELECT * FROM as_nominal_khusus order by timestamp";
            var adapter = NewConnection();

            DataSet ds = null;
            adapter.setQuery(query, out ds);
            if (ds.Tables[0] == null) AppCentre.Log("Unable to load data");

            Data = ListCreator.CreateList<DataStructure.as_nominal_khusus>(ds.Tables[0]);
            AppCentre.Log("Event fired");
            NotifyDataLoaded();
            //Load supplementary data
            //Thread T = new Thread((ThreadStart)delegate
            //{
                
            //});
            //T.Start();
        }
        #endregion
        #region Backend data operation
        public bool isDataMhsLoaded { get { return data_mhs != null; } }

        public List<DataStructure.ms_mhs> data_mhs = null;        
        public void LoadDataMhs()
        {
            data_mhs = PullAllDataFrom<DataStructure.ms_mhs>("ms_mhs");
        }

        public List<DataStructure.ms_golongan> data_golongan = null;
        public void LoadDataGolongan()
        {
            data_golongan = PullAllDataFrom<DataStructure.ms_golongan>("ms_golongan");
        }
        public List<DataStructure.ms_type_transaksi> data_transtype = null;
        public void LoadDataNominal()
        {
            data_transtype = PullAllDataFrom<DataStructure.ms_type_transaksi>("ms_type_transaksi");
        }
        public List<DataStructure.as_mhs_golongan> data_assign_gol = null;
        public void LoadDataAssign()
        {
            data_assign_gol = PullAllDataFrom<DataStructure.as_mhs_golongan>("as_mhs_golongan");
        }
        public List<DataStructure.ms_nominal_umum> data_nom_umum = null;
        public void LoadDataNominalUmum()
        {
            data_nom_umum = PullAllDataFrom<DataStructure.ms_nominal_umum>("ms_nominal_umum");
        }
        #endregion
        public bool Update(DataStructure.as_nominal_khusus data)
        {
            return Query.Update<DataStructure.as_nominal_khusus>(data) > 0;
        }
        public bool Insert(DataStructure.as_nominal_khusus data)
        {
            return Query.Insert<DataStructure.as_nominal_khusus>(data) > 0;
        }
        public bool Delete(DataStructure.as_nominal_khusus data)
        {
            return Query.Delete<DataStructure.as_nominal_khusus>(data.id) > 0;
        }
    }    
}
