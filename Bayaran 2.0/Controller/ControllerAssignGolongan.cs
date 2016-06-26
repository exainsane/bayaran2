using Bayaran_2._0.Model;
using Exainsane.Lib;
using Inventory.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Bayaran_2._0.Controller
{
    public class ControllerAssignGolongan : BaseController
    {
        public class vw_assign_golongan : DataStructure.ms_mhs
        {            
            public DataStructure.ms_golongan data_golongan{get;set;}
            public int assignid { get; set; }
            public vw_assign_golongan(int aid)
            {
                this.assignid = aid;
            }
            public DataStructure.as_mhs_golongan ToBasicAssign(){
                DataStructure.as_mhs_golongan d = new DataStructure.as_mhs_golongan();
                d.id = this.assignid;
                d.id_mhs.value = this.id;
                d.golongan.value = this.data_golongan.id;
                return d;

            }
            public void Fill(DataStructure.ms_mhs mhs)
            {
                this.id = mhs.id;
                this.nama = mhs.nama;
                this.nim = mhs.nim;
                this.angkatan = mhs.angkatan;
                this.prodi = mhs.prodi;
                this.jurusan = mhs.jurusan;
                this.fakultas = mhs.fakultas;
                this.aux = mhs.aux;                
            }
            public void Fill(DataStructure.ms_golongan gol)
            {                
                this.data_golongan = gol;
            }
            public void Fill(DataStructure.ms_mhs mhs, DataStructure.ms_golongan gol)
            {
                this.id = mhs.id;
                this.nama = mhs.nama;
                this.nim = mhs.nim;
                this.angkatan = mhs.angkatan;
                this.prodi = mhs.prodi;
                this.jurusan = mhs.jurusan;
                this.fakultas = mhs.fakultas;
                this.aux = mhs.aux;
                this.data_golongan = gol;
            }
            
        }
        public event ControllerDataLoaded DataLoaded;
        public List<DataStructure.ms_mhs> _datamhs;
        public List<DataStructure.ms_golongan> _datagol;
        public List<DataStructure.as_mhs_golongan> _dataassign;
        public List<vw_assign_golongan> _filtered = null;
        public List<DataStructure.ms_nominal_umum> _datanomumum;
        public List<DataStructure.ms_type_transaksi> _datatipetrans;
        private List<vw_assign_golongan> _data;
        public List<vw_assign_golongan> Data
        {
            get
            {
                return _filtered==null?_data:_filtered;
            }
            set
            {
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
        public AutoCompleteStringCollection GetMhsAutoCompleteStrings()
        {
            var atcstrs = new AutoCompleteStringCollection();
            if (_datamhs == null) return atcstrs;
            foreach (var i in _datamhs)
            {
                atcstrs.Add(i.nim);
            }
            return atcstrs;
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
                         Like(data.nama,q) ||
                         Like(data.nim,q) ||
                         Like(data.prodi,q) ||
                         Like(data.fakultas,q) ||
                         Like(data.data_golongan.kode_golongan,q) 
                         select data).ToList();
            NotifyDataLoaded();
        }
        public void ClearFilter()
        {
            this._filtered = null;
        }
        public void Load()
        {
            Thread T = new Thread((ThreadStart)delegate
            {
                string query = "SELECT * FROM as_mhs_golongan order by timestamp";
                var adapter = NewConnection();

                //Main assign data
                _dataassign = PullAllDataFrom<DataStructure.as_mhs_golongan>("as_mhs_golongan");

                //Data Mahasiswa                
                _datamhs = PullAllDataFrom<DataStructure.ms_mhs>("ms_mhs");

                //Data Golongan
                _datagol = PullAllDataFrom<DataStructure.ms_golongan>("ms_golongan");

                //Data Nominal Umum
                _datanomumum = PullAllDataFrom<DataStructure.ms_nominal_umum>("ms_nominal_umum");

                //Data tipe transaksi
                _datatipetrans = PullAllDataFrom<DataStructure.ms_type_transaksi>("ms_type_transaksi");

                List<vw_assign_golongan> _view = new List<vw_assign_golongan>() ;
                if (_datamhs.Count < 1 && _datagol.Count < 1) return;
                foreach (var i in _dataassign)
                {

                    DataStructure.ms_mhs vwmhs;
                    DataStructure.ms_golongan vwgol;
                    vw_assign_golongan view_item = new vw_assign_golongan(i.id);
                    var mhs_q = (from mhs in _datamhs
                                 where mhs.id == i.id_mhs.value
                                 select mhs).ToList();

                    if (mhs_q.Count > 0) view_item.Fill(mhs_q.First());

                    var gol_q = (from gol in _datagol
                                 where gol.id == i.golongan.value
                                 select gol).ToList();

                    if (gol_q.Count > 0) view_item.Fill(gol_q.First());

                    _view.Add(view_item);
                    

                }
                this.Data = _view;
            });
            T.Start();
        }
        public bool Update(DataStructure.as_mhs_golongan data)
        {
            return Query.Update<DataStructure.as_mhs_golongan>(data) > 0;
        }
        public event ControllerBatchUpdated BatchDataInserted;
        public void BatchInsert(List<DataStructure.as_mhs_golongan> data)
        {
            Thread T = new Thread((ThreadStart)delegate
            {
                int pos = 1;
                foreach (var i in data)
                {
                    if (this.Insert(i))
                    {
                        if (BatchDataInserted != null)
                            BatchDataInserted(pos);
                        pos++;
                    }
                }
                if (BatchDataInserted != null)
                    BatchDataInserted(-99891);
            });
            T.Start();
        }
        public bool Insert(DataStructure.as_mhs_golongan data)
        {
            return Query.Insert<DataStructure.as_mhs_golongan>(data) > 0;
        }
        public bool Delete(DataStructure.as_mhs_golongan data)
        {
            return Query.Delete<DataStructure.as_mhs_golongan>(data.id) > 0;
        }
    }
}
