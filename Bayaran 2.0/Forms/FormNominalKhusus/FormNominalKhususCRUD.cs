using Bayaran_2._0.Controller;
using Bayaran_2._0.Model;
using Exainsane.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bayaran_2._0.Forms
{
    public partial class FormNominalKhususCRUD : Form
    {
        ControllerNominalKhusus Controller;
        public FormNominalKhususCRUD(ref ControllerNominalKhusus controller)
        {
            InitializeComponent();
            
            this.Controller = controller;
        }

        private void FormNominalKhususCRUD_Load(object sender, EventArgs e)
        {
            if (Controller.data_mhs == null)
            {
                Controller.LoadDataMhs();
            }

            //Reset Form
            DataStructure.ms_mhs d = new DataStructure.ms_mhs();
            SetBiodata(d);
        }

        private void tbnim_KeyUp(object sender, KeyEventArgs e)
        {
            var q = (from d in Controller.data_mhs
                     where d.nim.Equals(tbnim.Text)
                     select d).ToList();
            if (q.Count < 1)
            {
                return;
            }
            SetBiodata(q.First());
        }
        private void SetBiodata(DataStructure.ms_mhs data)
        {
            if (data.nim != null) LoadTipeTransaksi(data.angkatan);
            Manipulator.FetchClassTo<DataStructure.ms_mhs, GroupBox>(data, ref groupBox3);
        }
        private void LoadTipeTransaksi(int angkatan)
        {
            Dictionary<int, string> dct = new Dictionary<int, string>();
            //TODO : filter yang udah di assign nominal
            foreach (var i in Controller.data_transtype)
            {
                dct.Add(i.id, i.tipe_transaksi);
            }
            cbtrans.DisplayMember = "Value";
            cbtrans.ValueMember = "Key";
            cbtrans.DataSource = new BindingSource(dct, null);
        }

        private void cbtrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;
            if (cb.SelectedIndex < 0) return;

            AppCentre.Log(cb.SelectedIndex);
            var stdid = (from d in Controller.data_mhs
                         where d.nim == tbnim.Text
                         select d).ToList();
            if (stdid.Count != 1) return;
            AppCentre.Log("Selected stdid " + stdid.First().nama);

            var golid = (from d in Controller.data_assign_gol
                         where d.id_mhs.value == stdid.First().id
                         select d).ToList();
            if (golid.Count < 1) return;
            AppCentre.Log("Selected gol " + golid.First().golongan + golid.Count.ToString());

            List<DataStructure.ms_nominal_umum> nominal;
            nominal = (from d in Controller.data_nom_umum
                           where d.golongan.value == golid.First().golongan.value
                           select d).ToList();            
            foreach (var i in Controller.data_nom_umum)
            {
                AppCentre.Log(i.golongan.value + " " + i.nominal + " " + i.tipetrans.value);
            }

            var gol = (from d in Controller.data_golongan
                       where d.id == golid.First().golongan.value
                       select d).ToList();
            int selected = Convert.ToInt32(cb.SelectedValue);
            AppCentre.Log("SELECT ID " + selected);
            var nom = (from d in nominal
                       where d.tipetrans.value == selected
                       select d).ToList();
            AppCentre.Log("FOUND " + nom.Count);
            lnominal.Text = nom.Count < 1 ? "null" : "Rp. " + nom.First().nominal.ToString("#,##0");

            lgolongan.Text = gol.Count < 1 ? "-" : gol.First().kode_golongan;
        }

        private void bsimpan_Click(object sender, EventArgs e)
        {
            var data = new DataStructure.as_nominal_khusus();

            var mhs = (from d in Controller.data_mhs
                       where d.nim == tbnim.Text
                       select d).ToList();
            if (mhs.Count != 1) return;
            data.id_mhs.value = mhs.First().id;

            var trans = (from d in Controller.data_transtype
                         where d.id == Convert.ToInt32(cbtrans.SelectedValue)
                         select d).ToList();
            if (trans.Count != 1) return;
            data.tipe_transaksi.value = trans.First().id;

            data.nominal = nominal.Value;
            data.beasiswa = beasiswano.Checked ? false : beasiswayes.Checked ? true : false;

            if (Controller.Insert(data))
            {
                Controller.Load();
                Hide();                                
            }
            else
            {
                AppCentre.Inform("Kesalahan input data!\nCek input data yang diberikan!", "Error");
            }
        }
    }
}
