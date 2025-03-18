using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;

namespace GestiuneCarti
{
    public partial class AddForm : Form
    {
        private OracleConnection connection;
        public AddForm(OracleConnection _connection)
        {
            connection = _connection;
            InitializeComponent();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            queryOutput_lbl.Text = string.Empty;
            error_timer.Stop();
        }
        private void add_book_btn_Click(object sender, EventArgs e)
        {
            queryOutput_lbl.Text = string.Empty;
            string id_carte = id_carte_txt.Text;
            string titlu = titlu_txt.Text;
            string autor = autor_txt.Text;
            string loc_pub = loc_pub_txt.Text;
            string an_pub = an_pub_txt.Text;
            string id_czu = id_czu_txt.Text;
            string pret = pret_txt.Text;
            string nr_exemp = nr_exemp_txt.Text;
            string limba = limba_txt.Text;

            string addQuery = "INSERT INTO CARTI (ID_CARTE, TITLU, AUTOR, LOCUL_PUBLICARII, ANUL_PUBLICARII, ID_CZU, PRET, NR_EXEMPLARE, LIMBA) " +
                  "VALUES (:id_carte, :titlu, :autor, :loc_pub, :an_pub, :id_czu, :pret, :nr_exemp, :limba)";

            if (connection.State != ConnectionState.Open)
            {
                queryOutput_lbl.Text = "Conexiunea cu baza de date este eșuată";
                error_timer.Start();
            }


            try
            {
                using (OracleCommand cmd = new OracleCommand(addQuery, connection))
                {
                    cmd.Parameters.Add(":id_carte", OracleDbType.Int32).Value = Convert.ToInt32(id_carte_txt.Text);
                    cmd.Parameters.Add(":titlu", OracleDbType.Varchar2).Value = titlu_txt.Text;
                    cmd.Parameters.Add(":autor", OracleDbType.Varchar2).Value = autor_txt.Text;
                    cmd.Parameters.Add(":loc_pub", OracleDbType.Varchar2).Value = loc_pub_txt.Text;
                    cmd.Parameters.Add(":an_pub", OracleDbType.Int32).Value = Convert.ToInt32(an_pub_txt.Text);
                    cmd.Parameters.Add(":id_czu", OracleDbType.Int32).Value = Convert.ToInt32(id_czu_txt.Text);
                    cmd.Parameters.Add(":pret", OracleDbType.Decimal).Value = Convert.ToDecimal(pret_txt.Text);
                    cmd.Parameters.Add(":nr_exemp", OracleDbType.Int32).Value = Convert.ToInt32(nr_exemp_txt.Text);
                    cmd.Parameters.Add(":limba", OracleDbType.Varchar2).Value = limba_txt.Text;

                    int rows = cmd.ExecuteNonQuery();
                    queryOutput_lbl.Text = "Carte introdusa cu succes!";
                    error_timer.Start();
                    connection.Commit();
                    id_carte_txt.Text = "";
                    titlu_txt.Text = "";
                    autor_txt.Text = "";
                    loc_pub_txt.Text = "";
                    an_pub_txt.Text = "";
                    id_czu_txt.Text = "";
                    pret_txt.Text = "";
                    nr_exemp_txt.Text = "";
                    limba_txt.Text = "";
                }



            }
            catch (Exception ex)
            {
                queryOutput_lbl.Text = "Eroare: " + ex.Message;
                error_timer.Start();
            }

        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            error_timer.Tick += Timer_Tick;
        }
    }
}
