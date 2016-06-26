using Bayaran_2._0.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Inventory.Model;
namespace Bayaran_2._0.Controller
{
    public class ControllerTransaksi : BaseController
    {
        #region Declarations
        public event ControllerDataLoaded MainDataLoaded;
        public event ControllerDataLoaded MhsDataLoaded;
        public List<DataStructure.ms_mhs> _datamhs;  //Requires Setter for event      
        public List<DataStructure.ms_nominal_umum> _datanominalumum;
        public List<DataStructure.ms_type_transaksi> _datatipetransaksi;
        public List<DataStructure.as_mhs_golongan> _dataassigngolongan;
        public List<DataStructure.as_nominal_khusus> _datanominalkhusus;
        public List<DataStructure.ms_golongan> _datagolongan;
        public List<DataStructure.tr_bayar> _datatransaksi; //Requires Setter for event
        public class TransactionTypeList //Class to be used in transaction type list
        {
            public int transid { get; set; }
            public decimal nominal { get; set; }
            public bool beasiswa { get; set; }
            public string transname { get; set; }
            public bool otp { get; set; }
        }
        public class TransactionLogModel
        {
            public string invcode { get; set; }
            public DateTime tanggal { get; set; }
            public decimal nominal { get; set; }
        }
        public class AccumulatedData
        {
            public DataStructure.ms_mhs mhs;
            public DataStructure.ms_golongan gol;
            public List<TransactionLogModel> paid;
            public List<TransactionTypeList> transactions;
            public string kode_golongan
            {
                get
                {
                    return gol == null ? "Null" : gol.kode_golongan;
                }
            }
            public string nominal
            {
                get
                {
                    if (transactions == null) return "Null";
                    var q = (from d in transactions
                             where d.beasiswa == true
                             select d).Count();
                    if (q == transactions.Count)
                        return "Khusus";
                    else if (q < transactions.Count && q != 0)
                        return "Non-Regular/Semi-Khusus";
                    else if (q == 0)
                        return "Reguler";
                    return "Null";
                }
            }
            public string beasiswa
            {
                get
                {
                    if (transactions == null) return "Null";
                    var q = (from d in transactions
                             where d.beasiswa == true
                             select d).Count();
                    if (q == transactions.Count)
                        return "Beasiswa penuh";
                    else if (q < transactions.Count && q != 0)
                        return "Beasiswa sebagian";
                    else if (q == 0)
                        return "Tidak";
                    return "Null";
                }
            }
        }
        #endregion
        #region Get/Setter
        public List<DataStructure.ms_mhs> DataMhs
        {
            get
            {
                return _datamhs;
            }
            set
            {
                _datamhs = value;
                NotifyMhsDataUpdated();
            }
        }
        public List<DataStructure.tr_bayar> DataTransaksi
        {
            get
            {
                return _datatransaksi;
            }
            set
            {
                _datatransaksi = value;
                NotifyMainDataUpdated();
            }
        }
        #endregion
        #region EventCaller
        public void NotifyMhsDataUpdated()
        {
            if (MhsDataLoaded != null)
                MhsDataLoaded();
        }
        public void NotifyMainDataUpdated()
        {
            if (MainDataLoaded != null)
                MainDataLoaded();
        }
        #endregion
        #region DataLoaderMethod
        public void LoadMhs()
        {
            DataMhs = PullAllDataFrom<DataStructure.ms_mhs>("ms_mhs");
        }
        public void LoadNomUmum()
        {
            _datanominalumum = PullAllDataFrom<DataStructure.ms_nominal_umum>("ms_nominal_umum");
        }
        public void LoadNomKhusus()
        {
            _datanominalkhusus = PullAllDataFrom<DataStructure.as_nominal_khusus>();
        }
        public void LoadAssignGolongan()
        {
            _dataassigngolongan = PullAllDataFrom<DataStructure.as_mhs_golongan>();
        }
        public void LoadTipeTransaksi()
        {
            _datatipetransaksi = PullAllDataFrom<DataStructure.ms_type_transaksi>();
        }
        public void LoadGolongan()
        {
            _datagolongan = PullAllDataFrom<DataStructure.ms_golongan>();
        }
        public void LoadDataTransaksi()
        {
            DataTransaksi = PullAllDataFrom<DataStructure.tr_bayar>();
        }
        public void FirstLoad()
        {
            Thread T = new Thread(_ThreadLoader);
            T.Start();
        }
        private void _ThreadLoader()
        {
            LoadMhs();
            LoadNomUmum();
            LoadNomKhusus();
            LoadAssignGolongan();
            LoadTipeTransaksi();
            LoadGolongan();
            LoadDataTransaksi();
        }
        #endregion
        #region TransactionMethod
        public string RequestInvoice()
        {
            string inv = "";
            DataSet ds = null;
            int todaytranscount = NewConnection().setQuery("select cast(timestamp as date) from tr_bayar where cast(timestamp as date)=date(now()) group by cast(timestamp as date), invcode", out ds);
            inv += DateTime.Now.Year.ToString();
            inv += DateTime.Now.Month.ToString("0#");
            inv += DateTime.Now.Day.ToString("0#");
            inv += todaytranscount.ToString("0000#");
            return inv;
        }
        public int InputTransaction(List<DataStructure.tr_bayar> data)
        {            
            if(data.Count == 0)
                return 0;
            int success = 0;
            foreach (var i in data)
            {
                success += Query.Insert<DataStructure.tr_bayar>(i, true);
            }
            return success;
        }
        #endregion
        #region DataPullerMethod
        public AutoCompleteStringCollection GetMhsAutoCompleteStrings()
        {
            var atcstrs = new AutoCompleteStringCollection();
            if (DataMhs == null) return atcstrs;
            foreach (var i in DataMhs)
            {
                atcstrs.Add(i.nim);
            }
            return atcstrs;
        }
        public DataStructure.ms_mhs SearchMhs(string nim)
        {
            if (DataMhs == null) return null;
            var q = (from d in DataMhs
                     where d.nim == nim
                     select d).ToList();
            if (q.Count != 1) return null;
            return q.First();
        }
        public AccumulatedData GetDataDetail(int mhsid)
        {
            AccumulatedData data = new AccumulatedData();
            data.paid = new List<TransactionLogModel>();
            data.transactions = new List<TransactionTypeList>();
            var mhsdata = (from d in DataMhs
                           where d.id == mhsid
                           select d).ToList();
            if (mhsdata.Count != 1) return null;

            data.mhs = mhsdata.First();

            var assigned = (from d in _dataassigngolongan
                                where d.id_mhs.value == mhsdata.First().id
                                select d).ToList();
            if (assigned.Count != 1) return null;

            var golongan = (from d in _datagolongan
                            where d.id == assigned.First().golongan.value
                            select d).ToList();
            if (golongan.Count != 1) return null;

            data.gol = golongan.First();

            var nom = (from d in _datanominalumum
                       join e in _datatipetransaksi
                           on d.tipetrans.value equals e.id
                       where d.golongan.value == assigned.First().golongan.value
                       select new { d, e }).ToList();
            AppCentre.Log(nom.Count);
            foreach (var i in nom)
            {
                AppCentre.Log(i.e.tipe_transaksi);
                //Check if there is an overrided value
                var chk = (from d in _datanominalkhusus
                           join e in _datatipetransaksi
                           on d.tipe_transaksi.value equals e.id
                           where d.tipe_transaksi.value == i.e.id
                           && d.id_mhs.value == mhsdata.First().id
                           select new { d, e}).ToList();
                if (chk.Count == 1) //Override value found, add overrided value to transaction list
                {
                    data.transactions.Add(new TransactionTypeList()
                    {
                        beasiswa = chk.First().d.beasiswa,
                        nominal = chk.First().d.nominal,
                        transid = chk.First().e.id,
                        otp = chk.First().e.otp,
                        transname = chk.First().e.tipe_transaksi
                    });
                }
                else //Overrided value not found. Add common value
                {
                    data.transactions.Add(new TransactionTypeList()
                    {
                        beasiswa = false,
                        nominal = i.d.nominal,
                        transid = i.d.tipetrans.value,
                        otp = i.e.otp,
                        transname = i.e.tipe_transaksi
                    });
                }
            }

            var byr = (from d in _datatransaksi
                       where d.id_mhs.value == mhsdata.First().id
                       group d by d.invcode
                           into g
                           select new
                           {
                               tgl = g.First().timestamp,
                               inv = g.Key,
                               total = g.Sum(x => x.nominal)
                           }).ToList();

            foreach (var i in byr)
            {
                data.paid.Add(new TransactionLogModel()
                {
                    invcode = i.inv,
                    nominal = i.total,
                    tanggal = i.tgl
                });
            }
            for (int i = 0; i < data.transactions.Count; i++)
            {
                if (data.transactions[i].otp) continue; //Don't continue if its an one-time-payment
                if (_datatransaksi == null || _datatransaksi.Count < 1) break;
                decimal paid = (from d in _datatransaksi
                                where d.id_mhs.value == mhsdata.First().id
                                && d.tipe_transaksi == data.transactions[i].transname
                                select d.nominal).Sum();
                data.transactions[i].nominal -= paid;
            }
            return data;
        }
        #endregion
    }
}
