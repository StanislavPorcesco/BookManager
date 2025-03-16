using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiuneCarti.Forms
{
    public partial class DeleteForm : Form
    {

        private OracleConnection connection;
        public DeleteForm(OracleConnection _connection)
        {
            connection = _connection;
            InitializeComponent();
            multi_lbl.Hide();
            range1_txt.Hide();
            range2_txt.Hide();
            range_lbl.Hide();
        }

        private void del1_ck_CheckedChanged(object sender, EventArgs e)
        {
            single_lbl.Text = "Introdu ID-ul Cărții";
            single_lbl.Show();
            range1_txt.Hide();
            range2_txt.Hide();
            multi_lbl.Hide();
            range_lbl.Hide();
            id_carte_txt.Show();
            delmore_ck.Checked = false;
        }

        private void delmore_ck_CheckedChanged(object sender, EventArgs e)
        {

            multi_lbl.Show();
            single_lbl.Hide();
            range_lbl.Show();
            range1_txt.Show();
            range2_txt.Show();
            id_carte_txt.Hide();
            del1_ck.Checked = false;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string id_carte = id_carte_txt.Text;
            if (connection.State != ConnectionState.Open)
            {
                queryOutput_lbl.Text = "Conexiune eșuată";
            }
            else
            {
                queryOutput_lbl.Text = "Conexiune stabila. Nici o comanda executata";

            }
            
            
                try
                {
                    if (del1_ck.Checked)
                    {
                        string query = $"DELETE FROM CARTI WHERE ID_CARTE = :id_carte";
                        using (OracleConnection conn = connection)
                        {
                            using (OracleCommand cmd = new OracleCommand(query, conn))
                            {
                                cmd.Parameters.Add(":id_carte", OracleDbType.Int32).Value = Convert.ToInt32(id_carte_txt.Text);


                                cmd.ExecuteNonQuery();
                                queryOutput_lbl.Text = $"Cartea {id_carte} a fost ștearsă cu succes";
                            }
                        }
                        connection.Open();
                    }
                 /*   if (delmore_ck.Checked)
                    {
                        string query = $"DELETE FROM CARTI WHERE ID_CARTE BETWEEN :id_range1 AND :id_range2:";

                        using (OracleConnection conn = connection)
                        {
                            using (OracleCommand cmd = new OracleCommand(query, conn))
                            {
                                cmd.Parameters.Add(":id_range1", OracleDbType.Int32).Value = Convert.ToInt32(range1_txt.Text);
                                cmd.Parameters.Add(":id_range2", OracleDbType.Int32).Value = Convert.ToInt32(range2_txt.Text);

                                int rows = cmd.ExecuteNonQuery();
                                queryOutput_lbl.Text = $"Au fost șterse {rows} rânduri";
                                connection.Commit();
                            }
                        }
                       
                    }*/
                }
                catch (Exception ex)
                {
                    queryOutput_lbl.Text = ex.Message;
                }            
        }
    }
}
