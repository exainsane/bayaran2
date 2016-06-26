using Bayaran_2._0.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MRG.Controls.UI;
using Exainsane.Lib;
using Bayaran_2._0.Model;
using Bayaran_2._0.Library;
namespace Bayaran_2._0.Forms
{
    public partial class Transaksi : Form
    {
        ControllerTransaksi Controller;           
        bool isControllerReady = false;
        public Transaksi()
        {
            InitializeComponent();

            Controller = new ControllerTransaksi();
            Controller.MainDataLoaded += Controller_MainDataLoaded;

            panelloader.Visible = true;

           
        }
        void InstallAutoComplete()
        {
            tbnim.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbnim.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbnim.AutoCompleteCustomSource = Controller.GetMhsAutoCompleteStrings();
        }
        void Controller_MainDataLoaded()
        {
            //disable loading            
            Invoke(new Action(() =>
            {
                loadingCircle1.Enabled = false;
                loadingCircle1.Active = false;
                panelloader.Visible = false;
            }));

            //Install autocomplete
            Invoke(new Action(() =>
            {
                InstallAutoComplete();
            }));
            isControllerReady = true;
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    CreatePayment("newobj" + i, "Test new" + i);
            //}
            Controller.FirstLoad();

            printInvoiceToolStripMenuItem.Click += printInvoiceToolStripMenuItem_Click;
            bclear.Click += (s, ev) => { ClearForm(); };

            dlog.AutoGenerateColumns = false;

            ClearForm(false);
        }

        void printInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rindex = dlog.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (rindex < 0) return;
            var data = dlog.DataSource as List<ControllerTransaksi.TransactionLogModel>;

            if (data.Count < 1) return;

            var selected = data.First();

            var invdata = (from dt in Controller.DataTransaksi
                           where dt.invcode == selected.invcode
                           select dt).ToList();

            printInvoiceToolStripMenuItem.Text = "Print : " + selected.invcode;
        }
        void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in (sender as DataGridView).Rows)
            {
                r.Cells["_numcolumn"].Value = r.Index + 1;
            }
        }
        void dataGridView1_DataBindingComplete_a(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in (sender as DataGridView).Rows)
            {
                r.Cells["_numcolumn_a"].Value = r.Index + 1;
            }
        }
        #region TransactionListGenerator
        private void ClearPayment()
        {
            flowLayoutPanel1.Controls.Clear();
        }
        private void CreatePayment(string name, string title,  bool otp, decimal price)
        {
            Panel _cpanel = new Panel();
            Label _lbprice = new Label();
            Label _lbqty = new Label();
            Label _clabel = new Label();
            NumericUpDown _cnumeric = new NumericUpDown();
            CheckBox _cenabler = new CheckBox();
            
            _cpanel.Location = new System.Drawing.Point(4, 4);
            _cpanel.Name = "_cpanel"+title;
            _cpanel.Size = new System.Drawing.Size(292, 74);
            _cpanel.TabIndex = 0;
            
            _clabel.AutoSize = true;
            _clabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            _clabel.Location = new System.Drawing.Point(3, 3);
            _clabel.Name = "_helper_l_" + name;
            _clabel.Size = new System.Drawing.Size(31, 15);
            _clabel.TabIndex = 0;
            _clabel.Text = title;
            
            _cnumeric.Location = new System.Drawing.Point(6, 23);
            _cnumeric.Name = name;
            _cnumeric.Size = new System.Drawing.Size(283, 20);
            _cnumeric.TabIndex = 1;
            _cnumeric.Maximum = (otp?decimal.MaxValue:price);
            _cnumeric.Enabled = false;
            _cnumeric.KeyUp += (e, f) =>
            {
                if (!otp)
                {
                    _lbqty.Text = "Rp. " + _cnumeric.Value.ToString("#,##0");                    
                }
                else
                {
                    _lbqty.Text = "(" + (Math.Round(_cnumeric.Value / price)).ToString() + ") " + title;
                }
            };

            _cenabler.AutoSize = true;
            _cenabler.Location = new System.Drawing.Point(274, 5);
            _cenabler.Name = "_toggle_c_" + name;
            _cenabler.Size = new System.Drawing.Size(15, 14);
            _cenabler.TabIndex = 2;
            _cenabler.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            _cenabler.UseVisualStyleBackColor = true;
            _cenabler.Click += (sender, e) =>
            {                
                _cnumeric.Enabled = _cenabler.Checked;
            };

            _lbprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            _lbprice.Location = new System.Drawing.Point(164, 49);
            _lbprice.Name = "lbprice";
            _lbprice.Size = new System.Drawing.Size(125, 15);
            _lbprice.TabIndex = 0;
            _lbprice.Text = "Rp. " + price.ToString("#,##0");
            _lbprice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            _lbqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            _lbqty.Location = new System.Drawing.Point(3, 49);
            _lbqty.Name = "lbqty";
            _lbqty.Size = new System.Drawing.Size(133, 15);
            _lbqty.TabIndex = 0;
            _lbqty.Text = "-";
            _lbqty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;


            _cpanel.Controls.Add(_cenabler);
            _cpanel.Controls.Add(_cnumeric);
            _cpanel.Controls.Add(_clabel);
            _cpanel.Controls.Add(_lbprice);
            _cpanel.Controls.Add(_lbqty);
            

            flowLayoutPanel1.Controls.Add(_cpanel);
        }
        #endregion 
        private void tbnim_KeyUp(object sender, KeyEventArgs e)
        {
            if (!isControllerReady) return;
            if (e.KeyCode != Keys.Enter) return;
            string sval = (sender as TextBox).Text;

            var mhs = Controller.SearchMhs(sval);
            if (mhs == null) return;

            PrepareFormForTransaction(Controller.GetDataDetail(mhs.id));
        }
        private void ClearForm(bool forcerefresh = true)
        {
            Manipulator.FetchClassTo<DataStructure.ms_mhs, GroupBox>(new DataStructure.ms_mhs(), ref gb_dtmhs);
            Manipulator.FetchClassTo<ControllerTransaksi.AccumulatedData, GroupBox>(new ControllerTransaksi.AccumulatedData(), ref gb_goldetail);

            ClearPayment();

            dlog.DataSource = null;
            dgdetail.DataSource = null;

            if(forcerefresh)
            Controller.LoadDataTransaksi(); //Refresh data transaksi

            nbayar.Value = 0;
        }
        private void PrepareFormForTransaction(ControllerTransaksi.AccumulatedData data)
        {
            ClearForm();
            if (data == null)
            {
                
                return;
            }

            Manipulator.FetchClassTo<DataStructure.ms_mhs, GroupBox>(data.mhs, ref gb_dtmhs);
            Manipulator.FetchClassTo<ControllerTransaksi.AccumulatedData, GroupBox>(data, ref gb_goldetail);

            foreach (var i in data.transactions)
            {
                CreatePayment(i.transid.ToString(), i.transname, i.otp, i.nominal);
            }            
            dlog.DataSource = data.paid;
        }
        private List<DataStructure.tr_bayar> FetchControls()
        {
            List<DataStructure.tr_bayar> data = new List<DataStructure.tr_bayar>();
            List<Panel> panels = (from Control c in flowLayoutPanel1.Controls
                          where (c as Panel) != null
                          select (Panel)c).ToList();

            var dtmhs = (from d in Controller.DataMhs
                         where d.nim == tbnim.Text
                         select d).ToList();
            if (dtmhs.Count != 1) return data;

            string invcode = Controller.RequestInvoice();

            foreach (Panel panel in panels)
            {
                foreach (var i in panel.Controls)
                {
                    AppCentre.Log(panel.Name + " > " + ((Control)i).Name);
                }
                List<NumericUpDown> nums = (from Control n in panel.Controls
                            where (n as NumericUpDown) != null
                            select (NumericUpDown)n).ToList();
                if (nums.Count != 1) continue;
                var trname = (from d in Controller._datatipetransaksi
                              where d.id.ToString() == nums.First().Name
                              select d).ToList();
                if (trname.Count != 1) continue;

                string auxdetail = "";
                var aux = (from Control L in panel.Controls
                           where (L as Label) != null && L.Name == "lbqty"
                           select L).ToList();
                if (aux.Count != 1) auxdetail = "";
                else auxdetail = aux.First().Text;

                DataStructure.tr_bayar dbr = new DataStructure.tr_bayar();
                dbr.id_mhs.value = dtmhs.First().id;
                dbr.invcode = invcode;
                dbr.nominal = nums.First().Value;
                dbr.tipe_transaksi = trname.First().tipe_transaksi;
                dbr.rincian = auxdetail;

                data.Add(dbr);
            }
            return data;
        }

        private void bproses_Click(object sender, EventArgs e)
        {
            var insertabledata = FetchControls();

            dgdetail.DataSource = insertabledata;

            decimal accumulate = 0;
            foreach (var i in insertabledata)
            {
                accumulate += i.nominal;
            }
            ntotalbayar.Maximum = accumulate;
            ntotalbayar.Value = accumulate;
            nbayar.Maximum = accumulate * 3;
        }

        private void nbayar_KeyUp(object sender, KeyEventArgs e)
        {            

            var k = nbayar.Value - ntotalbayar.Value;
            nkembali.Text = k.ToString();
        }

        private void bsimpan_Click(object sender, EventArgs e)
        {
            int parsed;
            if (!int.TryParse(nkembali.Text, out parsed) || parsed < 0)
            {
                AppCentre.Inform("Pembayaran Kurang!","Cek Kembali Data!");
                return;
            }
            var data = dgdetail.DataSource as List<DataStructure.tr_bayar>;
            var dresult = new Helper.TransaksiPrompt(data).ShowDialog();
            if(dresult==DialogResult.Yes)
            {
                int chkc = data.Count;
                int inserted = Controller.InputTransaction(data);
                if (inserted == chkc)
                {
                    ClearForm();
                    DialogResult rslt = MessageBox.Show("Data telah tersimpan!\nCetak struk?", "Transaksi Berhasil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);                    
                    if(rslt == DialogResult.Yes)
                    {
                        ReceiptPrinter print = new ReceiptPrinter(data);
                        print.Print();
                    }
                }
                else
                {
                    AppCentre.Inform(string.Format("{0} dari {1} data telah tersimpan!", chkc.ToString(), inserted.ToString()), "Transaksi Berhasil");
                }
            }
        }

        private void dlog_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dlog.ClearSelection();
                var row = dlog.HitTest(e.X, e.Y);
                if (row.RowIndex < 0) return;

                dlog.Rows[row.RowIndex].Selected = true;
                rmenu.Show(Cursor.Position);
            }
        }
    }
}
