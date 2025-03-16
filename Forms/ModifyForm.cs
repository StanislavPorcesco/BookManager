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
    public partial class ModifyForm : Form
    {
        private OracleConnection connection;
        public ModifyForm(OracleConnection _connection)
        {
            connection = _connection;
            InitializeComponent();
        }
    }
}
