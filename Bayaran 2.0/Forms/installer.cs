using MySql.Data.MySqlClient;
using Project_Bayaran.classes;
using Project_Bayaran.datamodel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Bayaran_2._0.forms
{
    public partial class installer : Form
    {
        SQLExecutor sql;
        SQL_Data data = null;
        public installer()
        {
            InitializeComponent();
        }
        private Font bold
        {
            get
            {
                return new Font("Verdana", 9, FontStyle.Bold);
            }
        }
        private Font normal
        {
            get
            {
                return new Font("Verdana", 9);
            }
        }
        private void set_mode_first()
        {
            not_1.Font = bold;
            not_2.Font = normal;
            not_3.Font = normal;

            panel_section_1.Visible = true;
            panel_section_2.Visible = false;
            
        }
        private void set_mode_second()
        {
            not_2.Font = bold;
            not_1.Font = normal;
            not_3.Font = normal;

            panel_section_2.Visible = true;
            panel_section_1.Visible = false;

            Thread thread = new Thread((ThreadStart)delegate
            {                
                var result = sql.Execute();
                if (result)
                {
                    app_settings aps = new app_settings{
                        ip=data.host,
                        dbuser=data.username,
                        dbpass=data.password,
                        dbname=data.database
                    };
                    Program._sp = new SettingsProvider();
                    Program._sp.setSettings(aps);
                    Invoke(new Action(() =>
                    {
                        set_mode_third();
                    }));
                }
                else
                {
                    Invoke(new Action(() =>
                    {
                        set_mode_first();
                    }));
                }
            });
            int tick = 0;
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Tick += (e,f) =>
            {
                tick++;
                if (tick >= 1)
                {
                    thread.Start();
                    timer.Stop();
                }
            };
            timer.Interval = 1000;
            timer.Start();
            
        }
        private void set_mode_third()
        {
            not_2.Font = normal;
            not_1.Font = normal;
            not_3.Font = bold;
            locker.lockform(panel_section_1.Controls, true);
            locker.lockform(panel_section_2.Controls, true);

            b_close.Visible = true;
        }
        public void prepare(int progress_count)
        {
            Invoke(new Action(() =>
            {
                p_progressBar.Maximum = progress_count;
                p_progressBar.Value = 0;
                l_progress_count.Text = "0/" + progress_count;
            }));
        }
        public void log(string log, int counter, string message)
        {
            Invoke(new Action(() =>
            {
                t_log.AppendText(log + Environment.NewLine);
                p_progressBar.Value = counter;
                l_progress_count.Text = counter.ToString()+"/" + p_progressBar.Maximum.ToString();
                l_progress_status.Text = "Status : " + message;
            }));
            
        }
        private void installer_Load(object sender, EventArgs e)
        {
            set_mode_first();
      
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //string result = "no result";
            if (e.KeyCode == Keys.Enter)
            {                
                     

            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {            
        }

        private void b_next_Click(object sender, EventArgs e)
        {
            this.data = new SQL_Data();
            data.username = t_username.Text.Trim();
            data.password = t_password.Text.Trim();
            data.host = t_addr.Text.Trim();
            data.database = t_dbname.Text.Trim();
            data.default_password = t_admin_pw.Text.Trim();
            data.default_user = t_admin_uname.Text.Trim();

            sql = new SQLExecutor(data, this);
            set_mode_second();
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Installation Completed. Program will restart", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();
        }
    }
    public class SQL_Data
    {
        public static string escape(string str)
        {
            return "`" + str + "`";
        }
        public static string quote(string str)
        {
            return "'" + str + "'";
        }
        public string default_user { get; set; }
        public string default_password { get; set; }
        public string host { get; set; }
        public string username { get; set; }
        public string password { get; set; }        
        public string database { get; set; }
    }
    public class SQLExecutor
    {
        string sqlFile = Directory.GetCurrentDirectory() + @"\install\queries.dbquery";
        MySqlConnection db = null;
        SQL_Data data = null;
        installer parent;
        string[] queries = {};
        public SQLExecutor(SQL_Data data, installer parent)
        {
            this.data = data;
            this.db = new MySqlConnection("Server=" + data.host + ";database=information_schema;Uid=" + data.username + ";Pwd=" + data.password);
            this.parent = parent;
        }
        public bool readQueries()
        {
            if (!File.Exists(this.sqlFile)) return false;
            StreamReader file = new StreamReader(this.sqlFile);
            string content = file.ReadToEnd();
            string[] contentExploded = content.Split(';');
            queries = (from string ex in contentExploded
                       where ex.Trim().Length > 0
                       select ex).ToArray();              
            return true;
        }
        private bool check_data(){
            return data.host.Length > 1 && 
                data.username.Length > 1 && 
                data.database.Length > 1 &&
                data.default_password.Length > 1 &&
                data.default_user.Length > 1;
        }
        public bool Execute()
        {
            if (!readQueries())
            {
                MessageBox.Show("Unable to read installation queries. Aborting...", "Error",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Program.terminate();
            }
            parent.prepare(queries.Length + 4);

            try
            {
                if (!check_data()) 
                {
                    throw new Exception("Please don't leave a blank field (except password)");

                }
                db.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to connect to server" + Environment.NewLine + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            string strquery = "DROP DATABASE IF EXISTS " + SQL_Data.escape(data.database);  
            int actionCounter = 0;
            using (var cmd = new MySqlCommand(strquery, db))
            {
                int c = cmd.ExecuteNonQuery();                   
                parent.log("Deleting old database " + data.database, actionCounter,"Creating Database");
                
                Thread.Sleep(500);
            };
            strquery = "CREATE DATABASE IF NOT EXISTS " + SQL_Data.escape(data.database);            
            using (var cmd = new MySqlCommand(strquery, db))
            {
                int c = cmd.ExecuteNonQuery();
                if (c > 0)
                {
                    actionCounter++;
                    parent.log("Successfully Creating Database " + data.database, actionCounter, "Creating Database");
                }
                else
                {
                    parent.log("Failed in Creating Database " + data.database, actionCounter, "Creating Database");
                    return false;
                }
                Thread.Sleep(1000);
            };
            strquery = "USE " + SQL_Data.escape(data.database);
            using (var cmd = new MySqlCommand(strquery, db))
            {
                int c = cmd.ExecuteNonQuery();
                actionCounter++;
                parent.log("Database " + data.database+" Selected", actionCounter,"Selecting Database");
                Thread.Sleep(500);
            }
            try
            {
                foreach (string item in queries)
                {
                    if (item.Length < 1) continue;
                    using (var cmd = new MySqlCommand(item, db))
                    {
                        int c = cmd.ExecuteNonQuery();
                        actionCounter++;
                        parent.log("Executing ... " + Environment.NewLine + item, actionCounter, "Executing Queries");
                    }
                    Thread.Sleep(750);
                }               
            }
            catch (Exception r)
            {
                MessageBox.Show("Invalid Queries File. Rolling Back Changes" + Environment.NewLine + r.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                strquery = "DROP DATABASE IF EXISTS " + data.database;                
                using (var cmd = new MySqlCommand(strquery, db))
                {
                    int c = cmd.ExecuteNonQuery();
                    parent.log("Deleting database " + data.database, actionCounter, "Rolling back changes");
                    MessageBox.Show("Check back query files. Otherwise, rerun the program", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Program.terminate();
                };
            }
            strquery = "SHOW TABLES";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(strquery, db))
            {                
                DataSet ds = new DataSet();
                int c = adapter.Fill(ds);                               
                actionCounter++;
                parent.log("Checking Result...", actionCounter, "Finishing...");                
                if (c < queries.Length)
                {
                    parent.log("Table Result : "+c.ToString(), actionCounter, "Finishing...");
                }
                else
                {
                    parent.log("Query Completed " + c.ToString() + "/" + queries.Length.ToString(), actionCounter, "Finishing...");
                }
                Thread.Sleep(500);
            }
            strquery = "INSERT INTO t_staff (c_username,c_password,c_level,c_fullname) VALUES (" + SQL_Data.quote(data.default_user) + "," + SQL_Data.quote(data.default_password) + ",1,'Default Admin')";
            using (var cmd = new MySqlCommand(strquery, db))
            {
                try
                {
                    int c = cmd.ExecuteNonQuery();
                    actionCounter++;
                    parent.log("Creating default user...", actionCounter, "Creating user");
                
                }
                catch (Exception r)
                {
                    MessageBox.Show("System Error. Rolling Back Changes" + Environment.NewLine + r.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    strquery = "DROP DATABASE IF EXISTS " + data.database;
                    using (var cmd2 = new MySqlCommand(strquery, db))
                    {
                        cmd2.ExecuteNonQuery();
                        parent.log("Deleting database " + data.database, actionCounter, "Rolling back changes");
                        MessageBox.Show("Check back query files. Otherwise, rerun the program", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Program.terminate();
                    };

                }
                
                Thread.Sleep(500);
            }
            parent.log("Done...", actionCounter, "Completed");
            db.Close();
            return true;
        }        
    }
}
