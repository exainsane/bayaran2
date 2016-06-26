using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OfficeOpenXml;
using System.Threading;
using Bayaran_2._0.Model;
using Inventory.Model;
namespace Bayaran_2._0.Forms
{
    public partial class Importer : Form
    {
        const int maxcolnumber = 6;
        private Font basicfont = null;
        public Importer()
        {
            InitializeComponent();
        }
        #region UI Change
        void ShowPanel(ref Panel p)
        {
            p.Size = new Size(776, 449);
            p.Location = new Point(3, 3);
            p.Visible = true;
        }
        void HidePanel(ref Panel p)
        {
            p.Visible = false;
        }
        void SetMode(int mode)
        {
            ClearMode();
            ClearPanel();
            switch (mode)
            {
                case 1:
                    lpr1.Font = new Font(basicfont.FontFamily,basicfont.Size,FontStyle.Bold);
                    ShowPanel(ref p_overview);
                    break;
                case 2:
                    lpr2.Font = new Font(basicfont.FontFamily,basicfont.Size,FontStyle.Bold);
                    ShowPanel(ref p_selectfile);
                    break;
                case 3:
                    lpr3.Font = new Font(basicfont.FontFamily,basicfont.Size,FontStyle.Bold);
                    ShowPanel(ref p_checkcolumn);
                    break;
                case 4:                    
                    lpr4.Font = new Font(basicfont.FontFamily,basicfont.Size,FontStyle.Bold);
                    ShowPanel(ref p_final_progress);
                    StartImportProcess();
                    break;
            }
        }
        void ClearPanel()
        {
            HidePanel(ref p_overview);
            HidePanel(ref p_selectfile);
            HidePanel(ref p_checkcolumn);
            HidePanel(ref p_final_progress);
        }
        void ClearMode()
        {
            if (basicfont == null)
                basicfont = lpr1.Font;

            lpr1.Font = basicfont;
            lpr2.Font = basicfont;
            lpr3.Font = basicfont;
            lpr4.Font = basicfont;


        }
        #endregion
        #region UI Setup
        void SetupIcon()
        {
            AppCentre.SetButtonIcon(Properties.Resources.ic_ok, ref this.blanjutkan);
            AppCentre.SetButtonIcon(Properties.Resources.ic_ok, ref this.b_usefile);
            AppCentre.SetButtonIcon(Properties.Resources.ic_ok, ref this.b_startimport);
            AppCentre.SetButtonIcon(Properties.Resources.ic_cancel, ref this.b_cancelimport);
            AppCentre.SetButtonIcon(Properties.Resources.ic_ok, ref this.b_end_close);
        }
        #endregion
        #region Event Listener Setup
        void SetupEventListener()
        {
            blanjutkan.Click += (sender, e) =>
            {
                SetMode(2);
            };

            b_openfileselect.Click += (sender, e) =>
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Excel 2007 File|*.xlsx";
                dialog.FilterIndex = 1;
                dialog.Multiselect = false;
                DialogResult res = dialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    t_filename.Text = dialog.FileName;
                }
            };

            t_filename.TextChanged += file_check_read;

            b_usefile.Click += (sender, e) =>
            {
                SetMode(3);
                FileColumnCheck();
            };

            b_startimport.Click += (sender, e) =>
            {
                SetMode(4);
            };

            b_cancelimport.Click += (sender, e) =>
            {
                SetMode(2);
            };

            b_end_close.Click += (sender, e) =>
            {
                Hide();
                Dispose();
            };
            
        }
        void FileColumnCheck()
        {
            loader_checkcolumn.Visible = true;
            DataTable dt = new DataTable();

            string file = t_filename.Text;
            bool _columnmode = cb_containheader.Checked;

            ExcelPackage xlsfile = new ExcelPackage(new System.IO.FileInfo(file));
            ExcelWorksheet sheet = xlsfile.Workbook.Worksheets.First();
            //Urutan : nama 1, nim 2, prodi 3, jurusan 4, fakultas 5, angkatan 6 
            dt.Columns.Add("Nama");
            dt.Columns.Add("NIM");
            dt.Columns.Add("Prodi");
            dt.Columns.Add("Jurusan");
            dt.Columns.Add("Fakultas");
            dt.Columns.Add("Angkatan");

            Thread T = new Thread((ThreadStart)delegate
            {
                GetString GetStr = (object obj) =>
                 {
                     return obj == null ? "null" : obj.ToString();
                 };
                int rowlimit = sheet.Dimension.End.Row;
                try
                {
                    for (int i = (_columnmode ? 2 : 1); i <= rowlimit; i++)
                    {
                        //Urutan : nama 1, nim 2, prodi 3, jurusan 4, fakultas 5, angkatan 6 
                        object cnim = sheet.Cells[i, 2].Value;    //nim
                        //NIM ada di posisi kedua
                        if (cnim == null) continue; //tidak ada nim = tidak di input

                        DataRow r = dt.NewRow();                    
                        r["Nama"] = GetStr(sheet.Cells[i, 1].Value); //nama di posisi 1
                        r["NIM"] = cnim.ToString();
                        r["Prodi"] = GetStr(sheet.Cells[i, 3].Value);
                        r["Jurusan"] = GetStr(sheet.Cells[i, 4].Value);
                        r["Fakultas"] = GetStr(sheet.Cells[i, 5].Value);
                        r["Angkatan"] = Convert.ToInt32(sheet.Cells[i, 6].Value);
                    

                        dt.Rows.Add(r);
                    }
                }
                catch (Exception ec)
                {
                    AppCentre.Inform("Kesalahan pada file input!\nCek kembali struktur file!\n" + ec.Message, "Error");
                    SetMode(2);
                    return;
                }
                Invoke(new Action(() =>
                {
                    loader_checkcolumn.Visible = false;
                    dg_checkcolumn.DataSource = new BindingSource(dt, null);
                }));
            });
            T.Start();
        }
        void file_check_read(object sender, EventArgs e)
        {
            panel_loader.Visible = true;
            dg_previewfile.DataSource = null;
            //Console.WriteLine(((TextBox)sender).Text);
            string filename = ((TextBox)sender).Text;
            ExcelPackage xlsfile = new ExcelPackage(new System.IO.FileInfo(filename));
            ExcelWorksheet sheet = xlsfile.Workbook.Worksheets.First();

            DataTable dt = new DataTable();
            Dictionary<int, string> cols = new Dictionary<int, string>();

            bool _columnmode = cb_containheader.Checked; //check if first row is column header

            Thread T = new Thread((ThreadStart)delegate
            {
                try
                {
                    if (_columnmode)
                    {
                        for (int i = 1; i <= maxcolnumber; i++)
                        {
                            AppCentre.Log(i + " ");
                            object cnm = sheet.Cells[1, i].Value;
                            cols.Add(i - 1, cnm == null ? "unnamed column " + i : cnm.ToString());
                            dt.Columns.Add(cnm == null ? "unnamed column " + i : cnm.ToString());
                        }
                    }
                    else
                    {
                        for (int i = 1; i <= maxcolnumber; i++)
                        {
                            dt.Columns.Add();
                        }
                    }
                }
                catch (Exception exc)
                {
                    AppCentre.Inform(exc.Message, "Error");
                    Invoke(new Action(() =>
                    {
                        panel_loader.Visible = false;                        
                    }));
                }

                try
                {
                    int rowlimit = sheet.Dimension.End.Row > 50 ? 50 : sheet.Dimension.End.Row;
                    for (int i = (_columnmode ? 2 : 1); i <= rowlimit; i++)
                    {
                        int looprange = _columnmode ? cols.Count : maxcolnumber;
                        DataRow dr = dt.NewRow();
                        for (int j = 0; j < looprange; j++)
                        {
                            object cnm = sheet.Cells[i, j + 1].Value;
                            if (_columnmode)
                            {
                                //AppCentre.Log("Reading row " + i + " column " + cols[j]);
                                dr[cols[j]] = cnm == null ? "-" : cnm.ToString();
                            }
                            else
                            {
                                //AppCentre.Log("Reading row " + i + " column " + j);
                                dr[j] = cnm == null ? "-" : cnm.ToString();
                            }
                        }
                        dt.Rows.Add(dr);
                    }
                }
                catch (Exception exc)
                {
                    AppCentre.Inform(exc.Message, "Error");
                }
                finally
                {
                    Invoke(new Action(() =>
                    {
                        panel_loader.Visible = false;
                        dg_previewfile.DataSource = new BindingSource(dt, null);
                    }));
                }
                
            });
            T.Start();                           
        }
        #endregion
        void StartImportProcess()
        {
            DialogResult dg = MessageBox.Show("Mulai proses import?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.No)
            {
                SetMode(3);
                return;
            }

            string file = t_filename.Text;
            bool _columnmode = cb_containheader.Checked;

            ExcelPackage xlsfile = new ExcelPackage(new System.IO.FileInfo(file));
            ExcelWorksheet sheet = xlsfile.Workbook.Worksheets.First();

            List<DataStructure.ms_mhs> datalist = new List<DataStructure.ms_mhs>();
            try
            {
                Thread T2 = new Thread((ThreadStart)delegate
            {
                Invoke(new Action(() =>
                {
                    l_status.Text = "Executing Import... ";
                    prg_import.Value = 0;
                    prg_import.Maximum = datalist.Count;
                }));
                int cpos = 0;
                foreach (DataStructure.ms_mhs i in datalist)
                {
                    cpos++;
                    Query.Insert<DataStructure.ms_mhs>(i, true);
                    Invoke(new Action(() =>
                    {
                        l_status.Text = "Executing Import... " + cpos + "/" + datalist.Count;
                        prg_import.Value = cpos;
                    }));
                    
                }
                b_end_close.Visible = true;
            });
            Thread T = new Thread((ThreadStart)delegate
            {
                GetString GetStr = (object obj) =>
                {
                    return obj == null ? "null" : obj.ToString();
                };
                int rowlimit = sheet.Dimension.End.Row;
                Invoke(new Action(() =>
                {
                    l_status.Text = "Accumulating data...";
                    prg_import.Maximum = rowlimit;
                }));

                string auxlabel = "Imported "+DateTime.Now.ToShortDateString();

                for (int i = (_columnmode ? 2 : 1); i <= rowlimit; i++)
                {
                    //Urutan : nama 1, nim 2, prodi 3, jurusan 4, fakultas 5, angkatan 6 
                    object cnim = sheet.Cells[i, 2].Value;    //nim
                    //NIM ada di posisi kedua
                    if (cnim == null) continue; //tidak ada nim = tidak di input

                    DataStructure.ms_mhs m = new DataStructure.ms_mhs();
                    m.nama = GetStr(sheet.Cells[i, 1].Value); //nama di posisi 1
                    m.nim = cnim.ToString();
                    m.prodi = GetStr(sheet.Cells[i, 3].Value);
                    m.jurusan = GetStr(sheet.Cells[i, 4].Value);
                    m.fakultas = GetStr(sheet.Cells[i, 5].Value);
                    m.angkatan = Convert.ToInt32(sheet.Cells[i, 6].Value);
                    m.aux = auxlabel;

                    datalist.Add(m);
                    Invoke(new Action(() =>
                    {
                        l_status.Text = "Accumulating data... " + i + "/" + rowlimit;
                        prg_import.Value = i;
                    }));
                }
                Invoke(new Action(() =>
                {
                    T2.Start();
                }));
            });
            T.Start();
            }
            catch (Exception ec)
            {
                AppCentre.Inform("Kesalahan pada file input!\nCek kembali struktur file!\n" + ec.Message, "Error");
                SetMode(2);
                return;
            }
        }
        private void Importer_Load(object sender, EventArgs e)
        {
            SetupIcon();
            SetupEventListener();

            SetMode(1);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            file_check_read(t_filename, new EventArgs());
        }
    }
}

