using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace GestiuneCarti.Forms
{
    public partial class InfoForm : Form
    {
        private OracleConnection connection;
        public InfoForm(OracleConnection _connection)
        {
            InitializeComponent();
            connection = _connection;
            SetupScrollBar();
        }

        private void SetupScrollBar()
        {
            vScrollBarBooks.Minimum = 0;
            vScrollBarBooks.Maximum = panelBooks.Height;
            vScrollBarBooks.SmallChange = 20;
            vScrollBarBooks.LargeChange = 500;

            // Eveniment pentru scroll manual
            vScrollBarBooks.Scroll += (sender, e) =>
            {
                panelBooks.AutoScrollPosition = new Point(0, vScrollBarBooks.Value);
            };
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
            {
                throw new CustomException("Conexiune eșuată!");
            }
            else
            {
                try
                {
                    string query1 = "SELECT SUM(PRET*NR_EXEMPLARE) FROM CARTI";
                    using (OracleCommand cmd = new OracleCommand(query1, connection))
                    {
                        object nr_inv = cmd.ExecuteScalar();
                        val_lbl.Text = $"Valoare totală: {nr_inv} lei";
                    }

                    string query2 = "SELECT COUNT(ID_CARTE) FROM CARTI";
                    using (OracleCommand cmd = new OracleCommand(query2, connection))
                    {
                        object nr_carti = cmd.ExecuteScalar();
                        nr_carti_lbl.Text = $"Număr de cărți: {nr_carti} buc.";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Eroare: {ex.Message}", "Eroare", MessageBoxButtons.OK);
                }
            }
        }

    }
}
