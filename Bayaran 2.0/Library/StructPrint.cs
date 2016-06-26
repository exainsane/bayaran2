using Bayaran_2._0.Controller;
using Bayaran_2._0.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bayaran_2._0.Library
{        
    delegate void Drawer(string str, int x, int y);
    public class ReceiptPrinter
    {
        private List<DataStructure.tr_bayar> maindata { get; set; }
        private List<DataStructure.ms_mhs> mhsdata { get; set; }
        class DataController : BaseController
        {
            public static List<T> LoadList<T>() where T: new(){
                return PullAllDataFrom<T>();
            }
        }
        int linepos = 20, lineoffset = 20;
        int NewLine
        {
            get
            {
                int pos = linepos;
                linepos += lineoffset;
                return pos;
            }
        }
        public PrintPageEventHandler handler;
        public ReceiptPrinter(List<DataStructure.tr_bayar> data, DataStructure.ms_mhs dtmhs = null)
        {
            AppCentre.Log("Printer init");
            this.maindata = data;
            if (dtmhs != null)
            {
                mhsdata = new List<DataStructure.ms_mhs>();
                mhsdata.Add(dtmhs);
            }
            else mhsdata = DataController.LoadList<DataStructure.ms_mhs>();
            AppCentre.Log("Handler init");
            this.handler = DefaultPrintMethod;
        }
        public void Print(bool skippreview = false)
        {
            AppCentre.Log("Printer print()");
            
            PrintDialog prd = new PrintDialog();
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            PrintDocument pdoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Font font = new Font("Arial", 10, FontStyle.Regular);
            PaperSize psize = new PaperSize();

            prd.UseEXDialog = true;

            psize.RawKind = (int)PaperKind.A4;

            pdoc.PrintPage += new PrintPageEventHandler(handler);

            prd.Document = pdoc;
            prd.Document.DefaultPageSettings.PaperSize = psize;

            AppCentre.Log("Skip Preview : " + skippreview.ToString());
            if (skippreview) goto goprint;

            AppCentre.Log("Dialog : ");
            DialogResult result = prd.ShowDialog();
            AppCentre.Log("Dialog : " + result);
            if (result != DialogResult.OK) return;

            ppd.Document = pdoc;
            result = ppd.ShowDialog();
            if (result != DialogResult.OK) return;
            
            goprint:
            AppCentre.Log("Printing");
            try
            {
                pdoc.Print();
            }
            catch (Exception e)
            {
                AppCentre.Inform("Unable to print!\n" + e.Message, "ERROR");
            }
            return;
        }
        private string GetSeparator(char chr, int length){
            string str = "";
            for (int i = 0; i < length; i++)
            {
                str += chr;
            }
            return str;
        }
        public void DefaultPrintMethod(object sender, PrintPageEventArgs e){
            Graphics graphics = e.Graphics;            
            Font f = new Font("Arial", 11, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            #region InternalMethod
            Drawer Draw = (str, x, y)=>{                
                graphics.DrawString(str, f, b, new PointF(x, y));                
            };            
            VoidMethod PrintSeparator = ()=>{
                Draw(GetSeparator('=',11*100), 0, NewLine);
            };
            VoidMethod PrintSeparator2 = () =>
            {
                Draw(GetSeparator('-', 11 * 100), 0, NewLine);
            };
            #endregion
            int col1 = 10, col2 = 350;
            Draw("Bukti Pembayaran", col1, NewLine);
            Draw("Universitas Negeri Jakarta", col1, NewLine);
            Draw("Tercetak : " + DateTime.Now.ToLongDateString(), col1, linepos);
            
            //Data
            var data = (from tr in this.maindata
                        join mhs in this.mhsdata
                            on tr.id_mhs.value equals mhs.id
                        select new
                        {
                            tr,
                            mhs
                        }).ToList();

            if (data.Count < 1) return;
            DateTime trdate = data.First().tr.timestamp;
            string namamhs = data.First().mhs.nama;
            namamhs = namamhs.Length > 35 ? namamhs.Substring(0, 35) : namamhs;
            string dtlmhs = string.Format("{0}/{1}/{2}",
                data.First().mhs.prodi, data.First().mhs.jurusan, data.First().mhs.fakultas);
            string invcode = data.First().tr.invcode;

            Draw("Invoice : " + invcode, col2, NewLine);

            PrintSeparator();
            Draw("Nama Mahasiswa : ", col1, linepos);
            Draw("Prodi/Jurusan/Fakultas : ", col2, NewLine);
            Draw(namamhs, col1, linepos);
            Draw(dtlmhs, col2, NewLine);

            PrintSeparator2();

            Draw("Tipe Transaksi", col1, linepos);
            Draw("Biaya", col2, NewLine);
            PrintSeparator2();

            foreach (var i in data)
            {
                Draw(i.tr.tipe_transaksi, col1, linepos);
                Draw(i.tr.nominal.ToString(), col2, NewLine);
                Draw("Rincian : "+i.tr.rincian, col1 + 30, NewLine);                
            }

        }
        public void SetPrintHandler(PrintPageEventHandler handler = null){
            if (handler != null)
                this.handler = handler;
        }
    }
}
