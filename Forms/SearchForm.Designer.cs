namespace GestiuneCarti.Forms
{
    partial class SearchForm
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            load_btn = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            queryOutput_lbl = new Label();
            error_timer = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            criteria_txt = new TextBox();
            criteria_lbl = new Label();
            label1 = new Label();
            autor_ck = new CheckBox();
            czu_ck = new CheckBox();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(54, 54, 54);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.FromArgb(54, 54, 54);
            dataGridView1.Location = new Point(50, 50);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(867, 379);
            dataGridView1.TabIndex = 0;
            // 
            // load_btn
            // 
            load_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            load_btn.BackColor = Color.FromArgb(54, 54, 54);
            load_btn.FlatAppearance.BorderColor = Color.DimGray;
            load_btn.FlatStyle = FlatStyle.Flat;
            load_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            load_btn.ForeColor = Color.White;
            load_btn.IconChar = FontAwesome.Sharp.IconChar.Check;
            load_btn.IconColor = Color.White;
            load_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            load_btn.Location = new Point(50, 12);
            load_btn.Name = "load_btn";
            load_btn.Size = new Size(215, 71);
            load_btn.TabIndex = 1;
            load_btn.Text = "Încarcă";
            load_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            load_btn.UseVisualStyleBackColor = false;
            load_btn.Click += load_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 54, 54);
            panel1.Controls.Add(queryOutput_lbl);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 526);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 35);
            panel1.TabIndex = 2;
            // 
            // queryOutput_lbl
            // 
            queryOutput_lbl.AutoSize = true;
            queryOutput_lbl.BackColor = Color.Transparent;
            queryOutput_lbl.Dock = DockStyle.Bottom;
            queryOutput_lbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            queryOutput_lbl.ForeColor = Color.White;
            queryOutput_lbl.Location = new Point(0, 4);
            queryOutput_lbl.Name = "queryOutput_lbl";
            queryOutput_lbl.Size = new Size(0, 31);
            queryOutput_lbl.TabIndex = 0;
            // 
            // error_timer
            // 
            error_timer.Enabled = true;
            error_timer.Interval = 5000;
            // 
            // panel2
            // 
            panel2.Controls.Add(criteria_txt);
            panel2.Controls.Add(criteria_lbl);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(autor_ck);
            panel2.Controls.Add(czu_ck);
            panel2.Controls.Add(load_btn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 429);
            panel2.Name = "panel2";
            panel2.Size = new Size(967, 97);
            panel2.TabIndex = 3;
            // 
            // criteria_txt
            // 
            criteria_txt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            criteria_txt.BackColor = Color.FromArgb(54, 54, 54);
            criteria_txt.BorderStyle = BorderStyle.FixedSingle;
            criteria_txt.ForeColor = Color.White;
            criteria_txt.Location = new Point(646, 56);
            criteria_txt.Name = "criteria_txt";
            criteria_txt.Size = new Size(271, 27);
            criteria_txt.TabIndex = 4;
            criteria_txt.Visible = false;
            // 
            // criteria_lbl
            // 
            criteria_lbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            criteria_lbl.AutoSize = true;
            criteria_lbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            criteria_lbl.ForeColor = Color.White;
            criteria_lbl.Location = new Point(646, 14);
            criteria_lbl.Name = "criteria_lbl";
            criteria_lbl.Size = new Size(54, 31);
            criteria_lbl.TabIndex = 3;
            criteria_lbl.Text = "test";
            criteria_lbl.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(292, 12);
            label1.Name = "label1";
            label1.Size = new Size(289, 31);
            label1.TabIndex = 3;
            label1.Text = "Alege criteriul de cautare:";
            // 
            // autor_ck
            // 
            autor_ck.AutoSize = true;
            autor_ck.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autor_ck.ForeColor = Color.White;
            autor_ck.Location = new Point(439, 54);
            autor_ck.Name = "autor_ck";
            autor_ck.Size = new Size(130, 29);
            autor_ck.TabIndex = 2;
            autor_ck.Text = "După autor";
            autor_ck.UseVisualStyleBackColor = true;
            autor_ck.CheckedChanged += autor_ck_CheckedChanged;
            // 
            // czu_ck
            // 
            czu_ck.AutoSize = true;
            czu_ck.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            czu_ck.ForeColor = Color.White;
            czu_ck.Location = new Point(292, 54);
            czu_ck.Name = "czu_ck";
            czu_ck.Size = new Size(119, 29);
            czu_ck.TabIndex = 2;
            czu_ck.Text = "După CZU";
            czu_ck.UseVisualStyleBackColor = true;
            czu_ck.CheckedChanged += czu_ck_CheckedChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(50, 50, 50, 0);
            panel3.Size = new Size(967, 429);
            panel3.TabIndex = 4;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(967, 561);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SearchForm";
            Text = "SearchForm";
            Load += SearchForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton load_btn;
        private Panel panel1;
        private Label queryOutput_lbl;
        private System.Windows.Forms.Timer error_timer;
        private Panel panel2;
        private CheckBox autor_ck;
        private CheckBox czu_ck;
        private Label label1;
        private Panel panel3;
        private TextBox criteria_txt;
        private Label criteria_lbl;
    }
}