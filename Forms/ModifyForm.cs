using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace GestiuneCarti.Forms
{
    public partial class ModifyForm : Form
    {
        private OracleConnection connection;
        public ModifyForm(OracleConnection _connection)
        {
            connection = _connection;
            InitializeComponent();

        }

        //need rework
        private void modify_btn_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
            {
                throw new CustomException("Conexiune eșuată");
            }
            else
            {
                try
                {
                    //wokrs
                    if (title_ck.Checked)
                    {
                        checkIntegrity();

                        string query = "UPDATE CARTI SET TITLU = :titlu WHERE ID_CARTE = :target";
                        using (OracleCommand cmd = new OracleCommand(query, connection))
                        {
                            cmd.Parameters.Add("titlu", OracleDbType.Varchar2).Value = Convert.ToString(new_val_txt.Text);
                            cmd.Parameters.Add("target", OracleDbType.Int32).Value = Convert.ToInt32(target_txt.Text);

                            cmd.ExecuteNonQuery();
                            queryOutput_lbl.Text = "Modificat cu succes!";
                        }
                    }

                    //works
                    if (limba_ck.Checked)
                    {
                        checkIntegrity();

                        string query = "UPDATE CARTI SET LIMBA = :limba WHERE ID_CARTE = :target";
                        using (OracleCommand cmd = new OracleCommand(query, connection))
                        {
                            cmd.Parameters.Add("limba", OracleDbType.Varchar2).Value = Convert.ToString(new_val_txt.Text);
                            cmd.Parameters.Add("target", OracleDbType.Int32).Value = Convert.ToInt32(target_txt.Text);

                            cmd.ExecuteNonQuery();
                            queryOutput_lbl.Text = "Modificat cu succes!";
                        }
                    }

                    //works
                    if (autor_ck.Checked)
                    {
                        checkIntegrity();

                        string query = "UPDATE CARTI SET AUTOR = :autor WHERE ID_CARTE = :target";
                        using (OracleCommand cmd = new OracleCommand(query, connection))
                        {
                            cmd.Parameters.Add("autor", OracleDbType.Varchar2).Value = Convert.ToString(new_val_txt.Text);
                            cmd.Parameters.Add("target", OracleDbType.Int32).Value = Convert.ToInt32(target_txt.Text);

                            cmd.ExecuteNonQuery();
                            queryOutput_lbl.Text = "Modificat cu succes!";
                        }
                    }

                    //works
                    if (loc_ck.Checked)
                    {
                        checkIntegrity();

                        string query = "UPDATE CARTI SET LOCUL_PUBLICARII = :loc WHERE ID_CARTE = :target";
                        using (OracleCommand cmd = new OracleCommand(query, connection))
                        {
                            cmd.Parameters.Add("loc", OracleDbType.Varchar2).Value = Convert.ToString(new_val_txt.Text);
                            cmd.Parameters.Add("target", OracleDbType.Int32).Value = Convert.ToInt32(target_txt.Text);

                            cmd.ExecuteNonQuery();
                            queryOutput_lbl.Text = "Modificat cu succes!";
                        }
                    }

                    //works
                    if (an_ck.Checked)
                    {
                        checkIntegrity();

                        string query = "UPDATE CARTI SET ANUL_PUBLICARII = :an WHERE ID_CARTE = :target";
                        using (OracleCommand cmd = new OracleCommand(query, connection))
                        {
                            cmd.Parameters.Add("an", OracleDbType.Int32).Value = Convert.ToInt32(new_val_txt.Text);
                            cmd.Parameters.Add("target", OracleDbType.Int32).Value = Convert.ToInt32(target_txt.Text);

                            cmd.ExecuteNonQuery();
                            queryOutput_lbl.Text = "Modificat cu succes!";
                        }
                    }
                    //works
                    if (idCZU_ck.Checked)
                    {
                        checkIntegrity();

                        string query = "UPDATE CARTI SET ID_CZU = :id_czu WHERE ID_CARTE = :target";
                        using (OracleCommand cmd = new OracleCommand(query, connection))
                        {
                            cmd.Parameters.Add("id_czu", OracleDbType.Int32).Value = Convert.ToInt32(new_val_txt.Text);
                            cmd.Parameters.Add("target", OracleDbType.Int32).Value = Convert.ToInt32(target_txt.Text);

                            cmd.ExecuteNonQuery();
                            queryOutput_lbl.Text = "Modificat cu succes!";
                        }
                    }
                    //works
                    if (pret_ck.Checked)
                    {
                        checkIntegrity();

                        string query = "UPDATE CARTI SET PRET = :pret WHERE ID_CARTE = :target";
                        using (OracleCommand cmd = new OracleCommand(query, connection))
                        {
                            cmd.Parameters.Add("pret", OracleDbType.Decimal).Value = Convert.ToDecimal(new_val_txt.Text.Replace(".", ","));
                            cmd.Parameters.Add("target", OracleDbType.Int32).Value = Convert.ToInt32(target_txt.Text);

                            cmd.ExecuteNonQuery();
                            queryOutput_lbl.Text = "Modificat cu succes!";
                        }
                    }
                    //works
                    if (nr_exemp_ck.Checked)
                    {
                        checkIntegrity();

                        string query = "UPDATE CARTI SET NR_EXEMPLARE = :nr_exemp WHERE ID_CARTE = :target";
                        using (OracleCommand cmd = new OracleCommand(query, connection))
                        {
                            cmd.Parameters.Add("nr_exemp", OracleDbType.Int32).Value = Convert.ToInt32(new_val_txt.Text);
                            cmd.Parameters.Add("target", OracleDbType.Int32).Value = Convert.ToInt32(target_txt.Text);

                            cmd.ExecuteNonQuery();
                            queryOutput_lbl.Text = "Modificat cu succes!";
                        }
                    }

                    if (!title_ck.Checked && !autor_ck.Checked && !limba_ck.Checked && !loc_ck.Checked && !an_ck.Checked && !idCZU_ck.Checked && !pret_ck.Checked && !nr_exemp_ck.Checked)
                    {
                        throw new CustomException("Selectati o casuță!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Eroare: {ex.Message}", "Eroare", MessageBoxButtons.OK);
                }
            }




        }

        private void checkIntegrity()
        {
            if (target_txt.Text == string.Empty)
            {
                throw new CustomException("Concretizați care carte trebuie modificată!");
            }

            if (new_val_txt.Text == string.Empty)
            {
                throw new CustomException("Concretizați care este valoarea nouă");
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Commit();
                queryOutput_lbl.Text = "Modificări salvate!";
            }
            else
            {
                queryOutput_lbl.Text = "Conxiune eșuată!";
            }
        }
        private void title_ck_CheckedChanged(object? sender, EventArgs e)
        {
            limba_ck.CheckedChanged -= limba_ck_CheckedChanged;
            limba_ck.Checked = false;
            limba_ck.CheckedChanged += limba_ck_CheckedChanged;

            autor_ck.CheckedChanged -= autor_ck_CheckedChanged;
            autor_ck.Checked = false;
            autor_ck.CheckedChanged += autor_ck_CheckedChanged;

            loc_ck.CheckedChanged -= loc_ck_CheckedChanged;
            loc_ck.Checked = false;
            loc_ck.CheckedChanged += loc_ck_CheckedChanged;

            an_ck.CheckedChanged -= an_ck_CheckedChanged;
            an_ck.Checked = false;
            an_ck.CheckedChanged += an_ck_CheckedChanged;

            idCZU_ck.CheckedChanged -= idCZU_ck_CheckedChanged;
            idCZU_ck.Checked = false;
            idCZU_ck.CheckedChanged += idCZU_ck_CheckedChanged;

            pret_ck.CheckedChanged -= pret_ck_CheckedChanged;
            pret_ck.Checked = false;
            pret_ck.CheckedChanged += pret_ck_CheckedChanged;

            nr_exemp_ck.CheckedChanged -= nr_exemp_ck_CheckedChanged;
            nr_exemp_ck.Checked = false;
            nr_exemp_ck.CheckedChanged += nr_exemp_ck_CheckedChanged;
        }

        private void limba_ck_CheckedChanged(object? sender, EventArgs e)
        {
            title_ck.CheckedChanged -= title_ck_CheckedChanged;
            title_ck.Checked = false;
            title_ck.CheckedChanged += title_ck_CheckedChanged;

            autor_ck.CheckedChanged -= autor_ck_CheckedChanged;
            autor_ck.Checked = false;
            autor_ck.CheckedChanged += autor_ck_CheckedChanged;

            loc_ck.CheckedChanged -= loc_ck_CheckedChanged;
            loc_ck.Checked = false;
            loc_ck.CheckedChanged += loc_ck_CheckedChanged;

            an_ck.CheckedChanged -= an_ck_CheckedChanged;
            an_ck.Checked = false;
            an_ck.CheckedChanged += an_ck_CheckedChanged;

            idCZU_ck.CheckedChanged -= idCZU_ck_CheckedChanged;
            idCZU_ck.Checked = false;
            idCZU_ck.CheckedChanged += idCZU_ck_CheckedChanged;

            pret_ck.CheckedChanged -= pret_ck_CheckedChanged;
            pret_ck.Checked = false;
            pret_ck.CheckedChanged += pret_ck_CheckedChanged;

            nr_exemp_ck.CheckedChanged -= nr_exemp_ck_CheckedChanged;
            nr_exemp_ck.Checked = false;
            nr_exemp_ck.CheckedChanged += nr_exemp_ck_CheckedChanged;
        }

        private void autor_ck_CheckedChanged(object? sender, EventArgs e)
        {

            title_ck.CheckedChanged -= title_ck_CheckedChanged;
            title_ck.Checked = false;
            title_ck.CheckedChanged += title_ck_CheckedChanged;

            limba_ck.CheckedChanged -= limba_ck_CheckedChanged;
            limba_ck.Checked = false;
            limba_ck.CheckedChanged += limba_ck_CheckedChanged;

            loc_ck.CheckedChanged -= loc_ck_CheckedChanged;
            loc_ck.Checked = false;
            loc_ck.CheckedChanged += loc_ck_CheckedChanged;

            an_ck.CheckedChanged -= an_ck_CheckedChanged;
            an_ck.Checked = false;
            an_ck.CheckedChanged += an_ck_CheckedChanged;

            idCZU_ck.CheckedChanged -= idCZU_ck_CheckedChanged;
            idCZU_ck.Checked = false;
            idCZU_ck.CheckedChanged += idCZU_ck_CheckedChanged;

            pret_ck.CheckedChanged -= pret_ck_CheckedChanged;
            pret_ck.Checked = false;
            pret_ck.CheckedChanged += pret_ck_CheckedChanged;

            nr_exemp_ck.CheckedChanged -= nr_exemp_ck_CheckedChanged;
            nr_exemp_ck.Checked = false;
            nr_exemp_ck.CheckedChanged += nr_exemp_ck_CheckedChanged;
        }

        private void loc_ck_CheckedChanged(object? sender, EventArgs e)
        {
            title_ck.CheckedChanged -= title_ck_CheckedChanged;
            title_ck.Checked = false;
            title_ck.CheckedChanged += title_ck_CheckedChanged;

            limba_ck.CheckedChanged -= limba_ck_CheckedChanged;
            limba_ck.Checked = false;
            limba_ck.CheckedChanged += limba_ck_CheckedChanged;

            autor_ck.CheckedChanged -= autor_ck_CheckedChanged;
            autor_ck.Checked = false;
            autor_ck.CheckedChanged += autor_ck_CheckedChanged;

            an_ck.CheckedChanged -= an_ck_CheckedChanged;
            an_ck.Checked = false;
            an_ck.CheckedChanged += an_ck_CheckedChanged;

            idCZU_ck.CheckedChanged -= idCZU_ck_CheckedChanged;
            idCZU_ck.Checked = false;
            idCZU_ck.CheckedChanged += idCZU_ck_CheckedChanged;

            pret_ck.CheckedChanged -= pret_ck_CheckedChanged;
            pret_ck.Checked = false;
            pret_ck.CheckedChanged += pret_ck_CheckedChanged;

            nr_exemp_ck.CheckedChanged -= nr_exemp_ck_CheckedChanged;
            nr_exemp_ck.Checked = false;
            nr_exemp_ck.CheckedChanged += nr_exemp_ck_CheckedChanged;
        }

        private void an_ck_CheckedChanged(object? sender, EventArgs e)
        {

            title_ck.CheckedChanged -= title_ck_CheckedChanged;
            title_ck.Checked = false;
            title_ck.CheckedChanged += title_ck_CheckedChanged;

            limba_ck.CheckedChanged -= limba_ck_CheckedChanged;
            limba_ck.Checked = false;
            limba_ck.CheckedChanged += limba_ck_CheckedChanged;

            autor_ck.CheckedChanged -= autor_ck_CheckedChanged;
            autor_ck.Checked = false;
            autor_ck.CheckedChanged += autor_ck_CheckedChanged;

            loc_ck.CheckedChanged -= loc_ck_CheckedChanged;
            loc_ck.Checked = false;
            loc_ck.CheckedChanged += loc_ck_CheckedChanged;

            idCZU_ck.CheckedChanged -= idCZU_ck_CheckedChanged;
            idCZU_ck.Checked = false;
            idCZU_ck.CheckedChanged += idCZU_ck_CheckedChanged;

            pret_ck.CheckedChanged -= pret_ck_CheckedChanged;
            pret_ck.Checked = false;
            pret_ck.CheckedChanged += pret_ck_CheckedChanged;

            nr_exemp_ck.CheckedChanged -= nr_exemp_ck_CheckedChanged;
            nr_exemp_ck.Checked = false;
            nr_exemp_ck.CheckedChanged += nr_exemp_ck_CheckedChanged;
        }

        private void idCZU_ck_CheckedChanged(object? sender, EventArgs e)
        {

            title_ck.CheckedChanged -= title_ck_CheckedChanged;
            title_ck.Checked = false;
            title_ck.CheckedChanged += title_ck_CheckedChanged;

            limba_ck.CheckedChanged -= limba_ck_CheckedChanged;
            limba_ck.Checked = false;
            limba_ck.CheckedChanged += limba_ck_CheckedChanged;

            autor_ck.CheckedChanged -= autor_ck_CheckedChanged;
            autor_ck.Checked = false;
            autor_ck.CheckedChanged += autor_ck_CheckedChanged;

            loc_ck.CheckedChanged -= loc_ck_CheckedChanged;
            loc_ck.Checked = false;
            loc_ck.CheckedChanged += loc_ck_CheckedChanged;

            an_ck.CheckedChanged -= an_ck_CheckedChanged;
            an_ck.Checked = false;
            an_ck.CheckedChanged += an_ck_CheckedChanged;

            pret_ck.CheckedChanged -= pret_ck_CheckedChanged;
            pret_ck.Checked = false;
            pret_ck.CheckedChanged += pret_ck_CheckedChanged;

            nr_exemp_ck.CheckedChanged -= nr_exemp_ck_CheckedChanged;
            nr_exemp_ck.Checked = false;
            nr_exemp_ck.CheckedChanged += nr_exemp_ck_CheckedChanged;
        }

        private void pret_ck_CheckedChanged(object? sender, EventArgs e)
        {
            title_ck.CheckedChanged -= title_ck_CheckedChanged;
            title_ck.Checked = false;
            title_ck.CheckedChanged += title_ck_CheckedChanged;

            limba_ck.CheckedChanged -= limba_ck_CheckedChanged;
            limba_ck.Checked = false;
            limba_ck.CheckedChanged += limba_ck_CheckedChanged;

            autor_ck.CheckedChanged -= autor_ck_CheckedChanged;
            autor_ck.Checked = false;
            autor_ck.CheckedChanged += autor_ck_CheckedChanged;

            loc_ck.CheckedChanged -= loc_ck_CheckedChanged;
            loc_ck.Checked = false;
            loc_ck.CheckedChanged += loc_ck_CheckedChanged;

            an_ck.CheckedChanged -= an_ck_CheckedChanged;
            an_ck.Checked = false;
            an_ck.CheckedChanged += an_ck_CheckedChanged;

            idCZU_ck.CheckedChanged -= idCZU_ck_CheckedChanged;
            idCZU_ck.Checked = false;
            idCZU_ck.CheckedChanged += idCZU_ck_CheckedChanged;

            nr_exemp_ck.CheckedChanged -= nr_exemp_ck_CheckedChanged;
            nr_exemp_ck.Checked = false;
            nr_exemp_ck.CheckedChanged += nr_exemp_ck_CheckedChanged;
        }

        private void nr_exemp_ck_CheckedChanged(object? sender, EventArgs e)
        {
            title_ck.CheckedChanged -= title_ck_CheckedChanged;
            title_ck.Checked = false;
            title_ck.CheckedChanged += title_ck_CheckedChanged;

            limba_ck.CheckedChanged -= limba_ck_CheckedChanged;
            limba_ck.Checked = false;
            limba_ck.CheckedChanged += limba_ck_CheckedChanged;

            autor_ck.CheckedChanged -= autor_ck_CheckedChanged;
            autor_ck.Checked = false;
            autor_ck.CheckedChanged += autor_ck_CheckedChanged;

            loc_ck.CheckedChanged -= loc_ck_CheckedChanged;
            loc_ck.Checked = false;
            loc_ck.CheckedChanged += loc_ck_CheckedChanged;

            an_ck.CheckedChanged -= an_ck_CheckedChanged;
            an_ck.Checked = false;
            an_ck.CheckedChanged += an_ck_CheckedChanged;

            idCZU_ck.CheckedChanged -= idCZU_ck_CheckedChanged;
            idCZU_ck.Checked = false;
            idCZU_ck.CheckedChanged += idCZU_ck_CheckedChanged;

            pret_ck.CheckedChanged -= pret_ck_CheckedChanged;
            pret_ck.Checked = false;
            pret_ck.CheckedChanged += pret_ck_CheckedChanged;
        }

        private void mainLabel_lbl_Click(object sender, EventArgs e)
        {

        }
    }

    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {

        }
    }
}
