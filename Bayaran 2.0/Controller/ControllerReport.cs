using Bayaran_2._0.Model;
using Exainsane.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bayaran_2._0.Controller
{
    public class ControllerReport : BaseController
    {
        #region hardcode data
        public enum ReportType
        {
           ReportByMahasiswa = 0,
           ReportByTransaksi = 1
        }
        public Dictionary<ReportType, string> ReportTypeList = new Dictionary<ReportType, string>();
        private void _createdictionary(){
            ReportTypeList.Add(ReportType.ReportByMahasiswa, "Report per Mahasiswa");
            ReportTypeList.Add(ReportType.ReportByTransaksi, "Report per Transaksi");
        }
        #endregion
        #region Reflected Data
        private List<DataStructure.ms_mhs> _datamhs = null;
        public List<DataStructure.ms_mhs> GetDataMhs()
        {
            if (_datamhs == null)
                _datamhs = PullAllDataFrom<DataStructure.ms_mhs>();

            return _datamhs;
        }
        private List<DataStructure.tr_bayar> _datatransaksi = null;
        public List<DataStructure.tr_bayar> GetDataTransaksi()
        {
            if (_datatransaksi == null)
                _datatransaksi = PullAllDataFrom<DataStructure.tr_bayar>();

            return _datatransaksi;
        }
        public List<ReportStructure.ReportByMhs> GetReportDataMahasiswa(ReportStructure.ReportQuery qdata)
        {
            //Manipulator.DumpObject(qdata);
            var q = (from tr in GetDataTransaksi()
                     join mhs in GetDataMhs()
                         on tr.id_mhs.value equals mhs.id
                     select new
                     {
                         mhs.id,
                         mhs.angkatan,
                         mhs.jurusan,
                         mhs.prodi,
                         mhs.nim,
                         mhs.fakultas,
                         mhs.nama,
                         tr.timestamp,
                         tr.nominal
                     }).ToList();

            q = (from dq in q
                 where dq.timestamp >= qdata.datefrom
                 && dq.timestamp <= qdata.dateto
                 select dq).ToList();
            #region Filtering

            if (qdata._angkatan)
            {
                q = (from dq in q
                     where dq.angkatan == qdata.angkatan
                     select dq).ToList();
                AppCentre.Log("Filtering angkatan" + q.Count());
            }
            if (qdata._fakultas)
            {
                q = (from dq in q
                     where dq.fakultas == qdata.fakultas
                     select dq).ToList();
                AppCentre.Log("Filtering fakultas" + q.Count());
            }
            if (qdata._jurusan)
            {
                q = (from dq in q
                     where dq.jurusan == qdata.jurusan
                     select dq).ToList();
                AppCentre.Log("Filtering jurusan" + q.Count());
            }
            if (qdata._prodi)
            {
                q = (from dq in q
                     where dq.prodi == qdata.prodi
                     select dq).ToList();
                AppCentre.Log("Filtering prodi" + q.Count());
            }
            #endregion
            #region Grouping
            var gq = (from dq in q
                      group dq by dq.id
                          into g
                          select new
                          {
                              id = g.Key,
                              jurusan = g.First().jurusan,
                              prodi = g.First().prodi,
                              angkatan = g.First().angkatan,
                              fakultas = g.First().fakultas,
                              nama = g.First().nama,
                              nim = g.First().nim,
                              nominal = g.Sum(x => x.nominal)
                          });
            #endregion



            List<ReportStructure.ReportByMhs> rptdt = new List<ReportStructure.ReportByMhs>();
            foreach (var i in gq)
            {
                rptdt.Add(new ReportStructure.ReportByMhs()
                {
                    fakultas = i.fakultas,
                    jurusan = i.jurusan,
                    nama = i.nama,
                    nim = i.nim,
                    prodi = i.prodi,
                    totalbayar = i.nominal,
                    angkatan = i.angkatan
                });
            }
            return rptdt;
        }
        public List<ReportStructure.ReportByTransaksi> GetReportDataTransaksi(ReportStructure.ReportQuery qdata)
        {            
            var q = (from tr in GetDataTransaksi()
                     join mhs in GetDataMhs()
                         on tr.id_mhs.value equals mhs.id
                         where tr.nominal > 0 //Select ONLY paid, not unpaid-entry
                     select new
                     {
                         mhs.id,
                         mhs.angkatan,
                         mhs.jurusan,
                         mhs.prodi,
                         mhs.fakultas,
                         mhs.nama,
                         mhs.nim,
                         tr.timestamp,
                         tr.nominal,
                         tr.rincian,
                         tr.tipe_transaksi
                     }).ToList();

            q = (from dq in q
                 where dq.timestamp >= qdata.datefrom
                 && dq.timestamp <= qdata.dateto
                 select dq).ToList();
            #region Filtering

            if (qdata._angkatan)
            {
                q = (from dq in q
                     where dq.angkatan == qdata.angkatan
                     select dq).ToList();
            }
            if (qdata._fakultas)
            {
                q = (from dq in q
                     where dq.fakultas == qdata.fakultas
                     select dq).ToList();
            }
            if (qdata._jurusan)
            {
                q = (from dq in q
                     where dq.jurusan == qdata.jurusan
                     select dq).ToList();
            }
            if (qdata._prodi)
            {
                q = (from dq in q
                     where dq.prodi == qdata.prodi
                     select dq).ToList();
            }
            #endregion           
            List<ReportStructure.ReportByTransaksi> rptdt = new List<ReportStructure.ReportByTransaksi>();
            foreach (var i in q)
            {
                rptdt.Add(new ReportStructure.ReportByTransaksi()
                {
                    fakultas = i.fakultas,
                    jurusan = i.jurusan,
                    nama = i.nama,                    
                    prodi = i.prodi,
                    nominal = i.nominal,
                    angkatan = i.angkatan,
                    detailtransaksi = i.rincian,
                    tipetransaksi = i.tipe_transaksi,
                    nim = i.nim,
                    timestamp = i.timestamp
                });
            }
            return rptdt;
        }
        #endregion
        #region Data Manipulator
        public List<string> GetProdi()
        {
            List<string> query = (from d in GetDataMhs()
                         group d by d.prodi
                             into g
                             select g.Key).ToList();
            return query;
        }
        public List<string> GetJurusan()
        {
            List<string> query = (from d in GetDataMhs()
                                  group d by d.jurusan
                                      into g
                                      select g.Key).ToList();
            return query;
        }
        public List<string> GetFakultas()
        {
            List<string> query = (from d in GetDataMhs()
                                  group d by d.fakultas
                                      into g
                                      select g.Key).ToList();
            return query;
        }
        public List<int> GetAngkatan()
        {
            List<int> query = (from d in GetDataMhs()
                                  group d by d.angkatan
                                      into g
                                      select g.Key).ToList();
            return query;
        }
        #endregion
        public ControllerReport()
        {
            _createdictionary();
        }
    }
}
