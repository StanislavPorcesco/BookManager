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
            label1 = new Label();
            val_lbl = new Label();
            label2 = new Label();
            nr_carti_lbl = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 54, 54);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 519);
            panel1.Name = "panel1";
            panel1.Size = new Size(1135, 35);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(39, 146);
            label1.Name = "label1";
            label1.Size = new Size(417, 31);
            label1.TabIndex = 1;
            label1.Text = "Informații pentru utilizarea aplicației:";
            // 
            // val_lbl
            // 
            val_lbl.AutoSize = true;
            val_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            val_lbl.ForeColor = Color.White;
            val_lbl.Location = new Point(60, 107);
            val_lbl.Name = "val_lbl";
            val_lbl.Size = new Size(151, 25);
            val_lbl.TabIndex = 1;
            val_lbl.Text = "Valoarea totală: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(39, 31);
            label2.Name = "label2";
            label2.Size = new Size(302, 31);
            label2.TabIndex = 1;
            label2.Text = "Informații despre inventar:";
            // 
            // nr_carti_lbl
            // 
            nr_carti_lbl.AutoSize = true;
            nr_carti_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nr_carti_lbl.ForeColor = Color.White;
            nr_carti_lbl.Location = new Point(60, 72);
            nr_carti_lbl.Name = "nr_carti_lbl";
            nr_carti_lbl.Size = new Size(144, 25);
            nr_carti_lbl.TabIndex = 1;
            nr_carti_lbl.Text = "Număr de cărți:";
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1135, 554);
            Controls.Add(label2);
            Controls.Add(nr_carti_lbl);
            Controls.Add(val_lbl);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "InfoForm";
            Text = "InfoForm";
            Load += InfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label val_lbl;
        private Label label2;
        private Label nr_carti_lbl;
    }
}