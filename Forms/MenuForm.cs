using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Windows.Media;
using System.Runtime.InteropServices;
using GestiuneCarti.Forms;

namespace GestiuneCarti
{
    public partial class MenuForm : Form
    {
        private OracleConnection connection;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public MenuForm(OracleConnection _connection)
        {
            InitializeComponent();

            if (_connection == null)
            {
                MessageBox.Show("Eroare: Conexiunea la baza de date a eșuat!", "Eroare", MessageBoxButtons.OK);
                return;
            }
            else connection = _connection;


            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 75);
            menu_pnl.Controls.Add(leftBorderBtn);

            OpenChildForm(new InfoForm(connection));

        }
        //Structuri
        private struct RGBcolor
        {
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(255, 255, 255);
            public static System.Drawing.Color color2 = System.Drawing.Color.FromArgb(64, 64, 64);
            public static System.Drawing.Color color3 = System.Drawing.Color.FromArgb(54, 54, 54);
        }

        //Metode 
        private void ActivateButton(object senderBtn)
        {
            DisableButton();
            if (senderBtn != null)
            {
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                currentBtn.ForeColor = RGBcolor.color1;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;

                //Left border button
                leftBorderBtn.BackColor = RGBcolor.color1;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //iconCurentChildForm
                iconCurentChildForm.IconChar = currentBtn.IconChar;
                iconCurentChildForm.IconColor = currentBtn.IconColor;

                //lableCurrentChildForm
                labelCurentChildForm.Text = currentBtn.Text;
                labelCurentChildForm.ForeColor = currentBtn.ForeColor;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = RGBcolor.color3;
                currentBtn.ForeColor = RGBcolor.color1;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = RGBcolor.color1;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                leftBorderBtn.Location = new Point(-10, currentBtn.Location.Y);
            }

        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only one form
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.Size = desktop_pnl.Size;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            desktop_pnl.Controls.Add(childForm);
            desktop_pnl.Tag = childForm;
            childForm.BringToFront();
            childForm.BackColor = RGBcolor.color2;
            childForm.Show();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            connection.Close();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void maximize_btn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }

            else WindowState = FormWindowState.Normal;

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new AddForm(connection));
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new DeleteForm(connection));
        }

        private void modify_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new ModifyForm(connection));
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new SearchForm(connection));
        }

        private void restart_btn_Click(object? sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            if (currentBtn != null)
            {
                OpenChildForm(new InfoForm(connection));
                DisableButton();
                leftBorderBtn.Visible = false;

                iconCurentChildForm.IconChar = IconChar.Home;
                iconCurentChildForm.IconColor = RGBcolor.color1;

                labelCurentChildForm.Text = "Acasă";
                iconCurentChildForm.ForeColor = currentBtn.ForeColor;
            }
        }

        //Drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void titlebar_pnl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void restart_lbl_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void restart_lbl2_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
