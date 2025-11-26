namespace GestiuneCarti.Forms
{
    partial class ModifyForm
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
            BasePanel = new Panel();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            cbPanel = new Panel();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            valoare_tb = new TextBox();
            optiune_cb = new ComboBox();
            idCarte_tb = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            modificaCarte_btn = new FontAwesome.Sharp.IconButton();
            BasePanel.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            cbPanel.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 54, 54);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 891);
            panel1.Name = "panel1";
            panel1.Size = new Size(1660, 39);
            panel1.TabIndex = 14;
            // 
            // BasePanel
            // 
            BasePanel.Controls.Add(panel2);
            BasePanel.Dock = DockStyle.Fill;
            BasePanel.Location = new Point(0, 0);
            BasePanel.Name = "BasePanel";
            BasePanel.Padding = new Padding(50);
            BasePanel.Size = new Size(1660, 891);
            BasePanel.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(50, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(1560, 791);
            panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbPanel);
            groupBox1.Controls.Add(modificaCarte_btn);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(30);
            groupBox1.Size = new Size(1560, 791);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modifica carte";
            // 
            // cbPanel
            // 
            cbPanel.Controls.Add(panel3);
            cbPanel.Dock = DockStyle.Fill;
            cbPanel.Location = new Point(30, 54);
            cbPanel.Name = "cbPanel";
            cbPanel.Padding = new Padding(0, 0, 0, 40);
            cbPanel.Size = new Size(1500, 621);
            cbPanel.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 180, 0, 0);
            panel3.Size = new Size(1500, 581);
            panel3.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.1333351F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.86667F));
            tableLayoutPanel1.Controls.Add(valoare_tb, 1, 2);
            tableLayoutPanel1.Controls.Add(optiune_cb, 1, 0);
            tableLayoutPanel1.Controls.Add(idCarte_tb, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 180);
            tableLayoutPanel1.MaximumSize = new Size(1500, 200);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1500, 200);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // valoare_tb
            // 
            valoare_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            valoare_tb.BackColor = Color.FromArgb(54, 54, 54);
            valoare_tb.BorderStyle = BorderStyle.FixedSingle;
            valoare_tb.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            valoare_tb.ForeColor = Color.White;
            valoare_tb.Location = new Point(500, 147);
            valoare_tb.Name = "valoare_tb";
            valoare_tb.Size = new Size(997, 38);
            valoare_tb.TabIndex = 3;
            // 
            // optiune_cb
            // 
            optiune_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            optiune_cb.BackColor = Color.FromArgb(54, 54, 54);
            optiune_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            optiune_cb.FlatStyle = FlatStyle.Flat;
            optiune_cb.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            optiune_cb.ForeColor = Color.White;
            optiune_cb.Location = new Point(500, 13);
            optiune_cb.Name = "optiune_cb";
            optiune_cb.Size = new Size(997, 39);
            optiune_cb.TabIndex = 1;
            // 
            // idCarte_tb
            // 
            idCarte_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            idCarte_tb.BackColor = Color.FromArgb(54, 54, 54);
            idCarte_tb.BorderStyle = BorderStyle.FixedSingle;
            idCarte_tb.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            idCarte_tb.ForeColor = Color.White;
            idCarte_tb.Location = new Point(500, 80);
            idCarte_tb.Name = "idCarte_tb";
            idCarte_tb.Size = new Size(997, 38);
            idCarte_tb.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(3, 83);
            label1.Name = "label1";
            label1.Size = new Size(460, 31);
            label1.TabIndex = 3;
            label1.Text = "ID-ul cărții care urmează să fie modificată";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(3, 150);
            label3.Name = "label3";
            label3.Size = new Size(165, 31);
            label3.TabIndex = 7;
            label3.Text = "Valoarea nouă";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(3, 17);
            label2.Name = "label2";
            label2.Size = new Size(250, 31);
            label2.TabIndex = 4;
            label2.Text = "Optiuni de modificare";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // modificaCarte_btn
            // 
            modificaCarte_btn.BackColor = Color.FromArgb(54, 54, 54);
            modificaCarte_btn.Dock = DockStyle.Bottom;
            modificaCarte_btn.FlatStyle = FlatStyle.Flat;
            modificaCarte_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            modificaCarte_btn.ForeColor = Color.LightGray;
            modificaCarte_btn.IconChar = FontAwesome.Sharp.IconChar.None;
            modificaCarte_btn.IconColor = Color.Black;
            modificaCarte_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            modificaCarte_btn.Location = new Point(30, 675);
            modificaCarte_btn.Name = "modificaCarte_btn";
            modificaCarte_btn.Size = new Size(1500, 86);
            modificaCarte_btn.TabIndex = 4;
            modificaCarte_btn.Text = "Modifică carte";
            modificaCarte_btn.UseVisualStyleBackColor = false;
            modificaCarte_btn.Click += modificaCarte_btn_Click;
            // 
            // ModifyForm
            // 
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1660, 930);
            Controls.Add(BasePanel);
            Controls.Add(panel1);
            Name = "ModifyForm";
            BasePanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            cbPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Panel BasePanel;
        private Panel panel2;
        private GroupBox groupBox1;
        private Panel cbPanel;
        private ComboBox optiune_cb;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton modificaCarte_btn;
        private TextBox idCarte_tb;
        private TextBox valoare_tb;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
    }
}