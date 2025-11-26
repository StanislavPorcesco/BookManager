namespace GestiuneCarti.Forms
{
    partial class DeleteForm
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
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            idCarte_tb = new TextBox();
            stergeCarte_btn = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1660, 930);
            panel2.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(50);
            panel3.Size = new Size(1660, 891);
            panel3.TabIndex = 22;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(54, 54, 54);
            panel4.Controls.Add(groupBox1);
            panel4.Dock = DockStyle.Fill;
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(50, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(1560, 791);
            panel4.TabIndex = 23;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(64, 64, 64);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Controls.Add(stergeCarte_btn);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(30);
            groupBox1.Size = new Size(1560, 791);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Șterge carte";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88.6F));
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(idCarte_tb, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(30, 54);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new Size(1500, 621);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 294);
            label1.Name = "label1";
            label1.Size = new Size(101, 31);
            label1.TabIndex = 12;
            label1.Text = "ID Carte";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // idCarte_tb
            // 
            idCarte_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            idCarte_tb.BackColor = Color.FromArgb(54, 54, 54);
            idCarte_tb.BorderStyle = BorderStyle.FixedSingle;
            idCarte_tb.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            idCarte_tb.ForeColor = Color.White;
            idCarte_tb.Location = new Point(174, 291);
            idCarte_tb.Name = "idCarte_tb";
            idCarte_tb.Size = new Size(1323, 38);
            idCarte_tb.TabIndex = 1;
            // 
            // stergeCarte_btn
            // 
            stergeCarte_btn.BackColor = Color.FromArgb(54, 54, 54);
            stergeCarte_btn.Dock = DockStyle.Bottom;
            stergeCarte_btn.FlatStyle = FlatStyle.Flat;
            stergeCarte_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stergeCarte_btn.ForeColor = Color.LightGray;
            stergeCarte_btn.IconChar = FontAwesome.Sharp.IconChar.None;
            stergeCarte_btn.IconColor = Color.Black;
            stergeCarte_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            stergeCarte_btn.Location = new Point(30, 675);
            stergeCarte_btn.Name = "stergeCarte_btn";
            stergeCarte_btn.Size = new Size(1500, 86);
            stergeCarte_btn.TabIndex = 2;
            stergeCarte_btn.Text = "Șterge carte";
            stergeCarte_btn.UseVisualStyleBackColor = false;
            stergeCarte_btn.Click += stergeCarte_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 54, 54);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 891);
            panel1.Name = "panel1";
            panel1.Size = new Size(1660, 39);
            panel1.TabIndex = 23;
            // 
            // DeleteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1660, 930);
            Controls.Add(panel2);
            Name = "DeleteForm";
            Text = "DeleteForm";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Panel panel4;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton stergeCarte_btn;
        private TextBox idCarte_tb;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
    }
}