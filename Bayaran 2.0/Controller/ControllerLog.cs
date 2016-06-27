using Bayaran_2._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Bayaran_2._0.Controller
{
    public class ControllerLog : BaseController
    {
        public class LogSummaryData
        {
            public string invcode { get; set; }
            public string mahasiswa { get; set; }
            public DateTime timestamp { get; set; }
            public string angkatan { get; set; }
            public string jurusan { get; set; }
            public string prodi { get; set; }
            public string fakultas { get; set; }
            public string nominal { get; set; }
        }
        public event ControllerDataLoaded DataLoaded;

        private List<LogSummaryData> datasummary;
        public List<LogSummaryData> Data
        {
            get
            {
                return datasummary;
            }
            set
            {
                datasummary = value;
            }
        }

        private List<DataStructure.ms_mhs> datamhs;

        private List<DataStructure.tr_bayar> datatransaksi;
        public List<DataStructure.tr_bayar> DataTransaksi
        {
            get
            {
                return datatransaksi;
            }
            set
            {
                datatransaksi = value;
            }
        }

        private void NotifyDataLoaded()
        {
            if (DataLoaded != null)
                DataLoaded();
        }

        public void Load()
        {
            Thread T = new Thread((ThreadStart)delegate
            {
                datamhs = PullAllDataFrom<DataStructure.ms_mhs>();
                DataTransaksi = PullAllDataFrom<DataStructure.tr_bayar>();

                var d = (from data in DataTransaksi
                         join mhs in datamhs
                         on data.id_mhs.value equals mhs.id
                         select new { data, mhs }).ToList();

                Data = (from dt in d
                         group dt by dt.data.invcode
                             into dat
                             select new LogSummaryData()
                             {
                                 angkatan = dat.First().mhs.angkatan.ToString(),
                                 fakultas = dat.First().mhs.fakultas,
                                 invcode = dat.First().data.invcode,
                                 jurusan = dat.First().mhs.jurusan,
                                 mahasiswa = dat.First().mhs.nama,
                                 nominal = dat.Sum(x => x.data.nominal).ToString(),
                                 prodi = dat.First().mhs.prodi,
                                 timestamp = dat.First().data.timestamp
                             }).ToList();
                d = null;

                NotifyDataLoaded();
            });
            T.Start();
        }
        public List<DataStructure.tr_bayar> GetDataPembayaran(string invcode)
        {
            var q = (from d in DataTransaksi
                     where d.invcode == invcode
                     select d).ToList();
            return q;
        }

    }
}
