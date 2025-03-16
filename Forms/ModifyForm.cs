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
        private void modify_btn_Click(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {

        }
        private void modifyID_ck_CheckedChanged(object sender, EventArgs e)
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

            nr_exemp_ck.CheckedChanged -= nr_exemp_ck_CheckedChanged;
            nr_exemp_ck.Checked = false;
            nr_exemp_ck.CheckedChanged += nr_exemp_ck_CheckedChanged;

        }

        private void title_ck_CheckedChanged(object sender, EventArgs e)
        {
            modifyID_ck.CheckedChanged -= modifyID_ck_CheckedChanged;
            modifyID_ck.Checked = false;
            modifyID_ck.CheckedChanged += modifyID_ck_CheckedChanged;

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

        private void limba_ck_CheckedChanged(object sender, EventArgs e)
        {
            modifyID_ck.CheckedChanged -= modifyID_ck_CheckedChanged;
            modifyID_ck.Checked = false;
            modifyID_ck.CheckedChanged += modifyID_ck_CheckedChanged;

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

        private void autor_ck_CheckedChanged(object sender, EventArgs e)
        {
            modifyID_ck.CheckedChanged -= modifyID_ck_CheckedChanged;
            modifyID_ck.Checked = false;
            modifyID_ck.CheckedChanged += modifyID_ck_CheckedChanged;

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

        private void loc_ck_CheckedChanged(object sender, EventArgs e)
        {
            modifyID_ck.CheckedChanged -= modifyID_ck_CheckedChanged;
            modifyID_ck.Checked = false;
            modifyID_ck.CheckedChanged += modifyID_ck_CheckedChanged;

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

        private void an_ck_CheckedChanged(object sender, EventArgs e)
        {
            modifyID_ck.CheckedChanged -= modifyID_ck_CheckedChanged;
            modifyID_ck.Checked = false;
            modifyID_ck.CheckedChanged += modifyID_ck_CheckedChanged;

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

        private void idCZU_ck_CheckedChanged(object sender, EventArgs e)
        {
            modifyID_ck.CheckedChanged -= modifyID_ck_CheckedChanged;
            modifyID_ck.Checked = false;
            modifyID_ck.CheckedChanged += modifyID_ck_CheckedChanged;

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

        private void pret_ck_CheckedChanged(object sender, EventArgs e)
        {
            modifyID_ck.CheckedChanged -= modifyID_ck_CheckedChanged;
            modifyID_ck.Checked = false;
            modifyID_ck.CheckedChanged += modifyID_ck_CheckedChanged;

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

        private void nr_exemp_ck_CheckedChanged(object sender, EventArgs e)
        {
            modifyID_ck.CheckedChanged -= modifyID_ck_CheckedChanged;
            modifyID_ck.Checked = false;
            modifyID_ck.CheckedChanged += modifyID_ck_CheckedChanged;

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
    }
}
