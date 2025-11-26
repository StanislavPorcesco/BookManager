using System.Windows.Forms;

namespace GestiuneCarti.Forms
{
    partial class InfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            totalCarti_lbl = new Label();
            totalPret_lbl = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 54, 54);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 963);
            panel1.Name = "panel1";
            panel1.Size = new Size(1589, 39);
            panel1.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(50);
            panel2.Size = new Size(1589, 963);
            panel2.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(54, 54, 54);
            panel3.Controls.Add(totalCarti_lbl);
            panel3.Controls.Add(totalPret_lbl);
            panel3.Dock = DockStyle.Fill;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(50, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(1489, 863);
            panel3.TabIndex = 22;
            // 
            // totalCarti_lbl
            // 
            totalCarti_lbl.AutoSize = true;
            totalCarti_lbl.Dock = DockStyle.Top;
            totalCarti_lbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            totalCarti_lbl.ForeColor = Color.White;
            totalCarti_lbl.Location = new Point(0, 58);
            totalCarti_lbl.Name = "totalCarti_lbl";
            totalCarti_lbl.Padding = new Padding(10);
            totalCarti_lbl.Size = new Size(400, 58);
            totalCarti_lbl.TabIndex = 2;
            totalCarti_lbl.Text = "Total cărți gestionate: 0 buc";
            // 
            // totalPret_lbl
            // 
            totalPret_lbl.AutoSize = true;
            totalPret_lbl.Dock = DockStyle.Top;
            totalPret_lbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            totalPret_lbl.ForeColor = Color.White;
            totalPret_lbl.Location = new Point(0, 0);
            totalPret_lbl.Name = "totalPret_lbl";
            totalPret_lbl.Padding = new Padding(10);
            totalPret_lbl.Size = new Size(409, 58);
            totalPret_lbl.TabIndex = 1;
            totalPret_lbl.Text = "Valoare totală inventar: 0 lei";
            // 
            // InfoForm
            // 
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1589, 1002);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Name = "InfoForm";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label totalPret_lbl;
        private Label totalCarti_lbl;
    }
}