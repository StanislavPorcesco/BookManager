using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;

namespace GestiuneCarti.Forms
{
    public partial class InfoForm : Form
    {
        private SQLiteConnection connection;
        public InfoForm(SQLiteConnection conn)
        {
            connection = conn ?? throw new ArgumentNullException(nameof(conn));
            if (connection.State != ConnectionState.Open) connection.Open();
            InitializeComponent();
            Data.GetTotalPret(conn);
            totalPret_lbl.Text = "Valoare totală inventar:  " + Data.GetTotalPret(conn).ToString() + " lei";
            totalCarti_lbl.Text = "Total cărți gestionate:  " + Data.GetTotalCarti(conn).ToString() + " buc";
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            
        }

    }
}
