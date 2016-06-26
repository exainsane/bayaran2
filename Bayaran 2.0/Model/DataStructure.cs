using Bayaran_2._0.Controller;
using Exainsane.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Bayaran_2._0.Model
{
    public class DataStructure
    {        
        public class ms_type_transaksi
        {
            public string _unique_field { get { return "tipe_transaksi"; } set { } }
            public int id { get; set; }
            public string tipe_transaksi { get; set; }
            public bool otp { get; set; }
            public DateTime timestamp { get; set; }
        }
        public class ms_golongan
        {
            public int id { get; set; }
            public string kode_golongan { get; set; }
            public int angkatan { get; set; }
            public DateTime timestamp { get; set; }
            public override string ToString()
            {
                return this.kode_golongan;
            }
        }
        public class as_nominal_khusus
        {
            public string _unique_field { get { return "id_mhs"; } set { } }
            public int id { get; set; }
            private ReferencedValue _idmhs = new ReferencedValue() { keycol = "id", valuecol = "nama", tname = "ms_mhs" };
            public ReferencedValue id_mhs { get { return _idmhs; } set { _idmhs = value; } }
            private ReferencedValue _idref = new ReferencedValue() { keycol = "id", valuecol = "tipe_transaksi", tname = "ms_type_transaksi" };
            public ReferencedValue tipe_transaksi { get { return _idref; } set { _idref = value; } }
            public decimal nominal { get; set; }
            public DateTime timestamp { get; set; }
            public bool beasiswa { get; set; }
        }
        public class as_mhs_golongan
        {
            public string _unique_field { get { return "id_mhs"; } set { } }
            public int id { get; set; }
            private ReferencedValue _idmhs = new ReferencedValue() { keycol = "id", valuecol = "nama", tname = "ms_mhs" };
            public ReferencedValue id_mhs { get { return _idmhs; } set { _idmhs = value; } }
            private ReferencedValue _gol = new ReferencedValue("ms_golongan", "id", "kode_golongan");
            public ReferencedValue golongan { get { return _gol; } set { _gol = value; } }
            public DateTime timestamp { get; set; }

        }
        public class ms_mhs
        {
            public string _unique_field { get { return "nim"; } set { } }
            public int id { get; set; }
            public string nama { get; set; }
            public string nim{get;set;}
            public int angkatan { get; set; }
            public string prodi { get; set; }
            public string jurusan { get; set; }
            public string fakultas { get; set; }
            public string aux { get; set; }
            public DateTime timestamp { get; set; }
        }
        public class ms_nominal_umum
        {
            public string _unique_field { get { return "golongan"; } set { } }
            public int id { get; set; }
            private ReferencedValue _gol = new ReferencedValue("ms_golongan", "id", "kode_golongan");
            public ReferencedValue golongan { get { return _gol; } set { _gol = value; } }
            private ReferencedValue _tipetrans = new ReferencedValue("ms_type_transaksi", "id", "tipe_transaksi");
            public ReferencedValue tipetrans { get { return _tipetrans; } set { _tipetrans = value; } }
            public decimal nominal { get; set; }
            public DateTime timestamp { get; set; }
        }
        public class tr_bayar
        {

            public int id { get; set; }
            private ReferencedValue _mhs = new ReferencedValue("ms_mhs", "id", "nama");
            public ReferencedValue id_mhs { get { return _mhs; } set { _mhs = value; } }
            public string tipe_transaksi { get; set; }
            public decimal nominal { get; set; }
            public string rincian { get; set; }
            public string invcode { get; set; }
            public DateTime timestamp { get; set; }
        }
    }
    public class ReportStructure
    {
        public class ReportQuery
        {
            public string prodi { get; set; }
            public bool _prodi { get; set; }
            public string jurusan { get; set; }
            public bool _jurusan { get; set; }
            public string fakultas { get; set; }
            public bool _fakultas { get; set; }
            public int angkatan { get; set; }
            public bool _angkatan { get; set; }
            public ControllerReport.ReportType ReportType { get; set; }
            public DateTime datefrom { get; set; }
            public DateTime dateto { get; set; }
        }
        public class ReportByMhs
        {
            public string nama { get; set; }
            public string nim { get; set; }
            public string jurusan { get; set; }
            public string prodi { get; set; }
            public string fakultas { get; set; }
            public int angkatan { get; set; }
            public decimal totalbayar { get; set; }
        }
        public class ReportByTransaksi
        {
            public string nama { get; set; }
            public string jurusan { get; set; }
            public string prodi { get; set; }
            public string fakultas { get; set; }
            public int angkatan { get; set; }
            public string tipetransaksi { get; set; }
            public string nim { get; set; }
            public string detailtransaksi { get; set; }
            public decimal nominal { get; set; }
            public DateTime timestamp { get; set; }
        }
    }
    public class ReferencedValueDatabase
    {
        static private Dictionary<string, Dictionary<int, string>> data;
        static private void Initiate()
        {
            if (data == null) data = new Dictionary<string, Dictionary<int, string>>();
        }
        static public string LoadIfNotExist(ReferencedValue reference) {
            Initiate();
            if(data == null) return "NULL";
            if (reference.value == 0) { return "NULL"; }                        
            bool check = (from d in data
                         where d.Key == reference.tname
                         select d).Count() == 1;

            if (!check)
            {
                LoadReferenceData(reference.tname, reference.keycol, reference.valuecol);                                
            }

            var load = data[reference.tname][reference.value];
            if (load != null)
            {
                return load;
            }
            
            return "NULL";
            

        }
        static public void LoadReferenceData(string tname, string key, string value){
            Initiate();
            string query = "SELECT {0},{1} FROM {2}";
            query = string.Format(query,key,value,tname);            
            var adapter = BaseController.NewConnection();

            DataSet ds = null;
            adapter.setQuery(query, out ds);
            Dictionary<int, string> dct = new Dictionary<int, string>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                dct.Add(Convert.ToInt32(item[key]), item[value].ToString());
            }

            data.Add(tname, dct);

        }
    }
    public class ReferencedValue
    {
        public ReferencedValue(string tname, string key, string val){
            this.tname = tname;
            this.keycol = key;
            this.valuecol = val;
        }
        public ReferencedValue(){

        }
        public static ReferencedValue NullInstance
        {
            get
            {
                return new ReferencedValue();
            }
        }
        public override string ToString()
        {
            return ReferencedValueDatabase.LoadIfNotExist(this);
        }
        public int value { get; set; }
        public string tname { get; set; }
        public string keycol { get; set; }
        public string valuecol { get; set; }
    }
}
