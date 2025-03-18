using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace GestiuneCarti.Forms
{

    public partial class SearchForm : Form
    {
        private OracleConnection connection;
        public SearchForm(OracleConnection _connection)
        {
            connection = _connection;
            InitializeComponent();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            queryOutput_lbl.Text = string.Empty;
            error_timer.Stop();
        }
        private void SearchForm_Load(object sender, EventArgs e)
        {
            error_timer.Tick += Timer_Tick;
        }
        private void load_btn_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
            {
                queryOutput_lbl.Text = "Conexiune eșuată!";
                error_timer.Start();

            }
            else
            {
                try
                {
                    if (czu_ck.Checked)
                    {
                        int id_czu = Convert.ToInt32(criteria_txt.Text);
                        string query2 = $"SELECT ID_CARTE, ID_CZU FROM CARTI WHERE ID_CZU = {id_czu} ORDER BY 1";
                        using (OracleDataAdapter adapter = new OracleDataAdapter(query2, connection))
                        {

                            dataGridView1.Width = 1100;
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                            queryOutput_lbl.Text = "Tabel încărcat cu succes!";
                            error_timer.Start();
                        }
                    }

                    if (autor_ck.Checked)
                    {
                        string autor = Convert.ToString(criteria_txt.Text);
                        string query3 = $"SELECT ID_CARTE, AUTOR FROM CARTI WHERE AUTOR = '{autor}' ORDER BY 1";
                        using (OracleDataAdapter adapter = new OracleDataAdapter(query3, connection))
                        {
                            dataGridView1.Width = 1100;
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                            queryOutput_lbl.Text = "Tabel încărcat cu succes!";
                            error_timer.Start();
                        }
                    }

                    if (!autor_ck.Checked && !czu_ck.Checked)
                    {
                        string query1 = "SELECT * FROM CARTI ORDER BY 1";
                        using (OracleDataAdapter adapter = new OracleDataAdapter(query1, connection))
                        {
                            dataGridView1.Width = 1100;
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                            queryOutput_lbl.Text = "Tabel încărcat cu succes!";
                            error_timer.Start();
                        }
                    }
                } catch (Exception ex)
                {
                    queryOutput_lbl.Text = "Eroare!";
                    MessageBox.Show($"A apărut o eroare:\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

               
            }
        }

        private void autor_ck_CheckedChanged(object? sender, EventArgs e)
        {
            criteria_txt.Text = string.Empty;
            czu_ck.CheckedChanged -= czu_ck_CheckedChanged;
            czu_ck.Checked = false;
            czu_ck.CheckedChanged += czu_ck_CheckedChanged;
            criteria_lbl.Text = "Introduceți autorul dorit:";

            criteria_lbl.Visible = true;
            criteria_txt.Visible = true;

            if (!autor_ck.Checked && !czu_ck.Checked)
            {
                criteria_lbl.Visible = false;
                criteria_txt.Visible = false;
            }

            
        }

        private void czu_ck_CheckedChanged(object? sender, EventArgs e)
        {
            criteria_txt.Text = string.Empty;
            autor_ck.CheckedChanged -= autor_ck_CheckedChanged;
            autor_ck.Checked = false;
            autor_ck.CheckedChanged += autor_ck_CheckedChanged;
            criteria_lbl.Text = "Introduceți CZU-ul dorit:";
            criteria_lbl.Visible = true;
            criteria_txt.Visible = true;

            if (!autor_ck.Checked && !czu_ck.Checked)
            {
                criteria_lbl.Visible = false;
                criteria_txt.Visible = false;
            }
        }
    }
}
