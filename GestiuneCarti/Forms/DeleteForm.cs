using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiuneCarti.Forms
{
    public partial class DeleteForm : Form
    {
        private SQLiteConnection connection;
        public DeleteForm(SQLiteConnection conn)
        {
            connection = conn ?? throw new ArgumentNullException(nameof(conn));
            InitializeComponent();
        }
        private void stergeCarte_btn_Click(object sender, EventArgs e)
        {
            int idCarte;
            if (connection.State != ConnectionState.Open) { connection.Open(); }
            try
            {
                if(idCarte_tb.Text == string.Empty || !idCarte_tb.Text.All(char.IsDigit))
                {
                    throw new Exception("ID Carte invalid!");
                } else idCarte = Convert.ToInt32(idCarte_tb.Text);

                if (Data.searchCarteByID(connection, idCarte) == false)
                {
                    throw new Exception("Nu există carte cu acest ID!");
                }
                else 
                {
                    Data.deleteCarte(connection, idCarte);
                    MessageBox.Show("Carte stearsă cu succes!");
                }          
            } catch(Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }          
        }
    }
}