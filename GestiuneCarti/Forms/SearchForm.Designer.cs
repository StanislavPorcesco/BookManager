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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            afisare_btn = new Button();
            coloana_cb = new ComboBox();
            label3 = new Label();
            button_panel = new Panel();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            valoare_tb = new TextBox();
            label1 = new Label();
            cauta_btn = new Button();
            panel1 = new Panel();
            grid_panel = new Panel();
            afisare_gv = new DataGridView();
            button_panel.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            grid_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)afisare_gv).BeginInit();
            SuspendLayout();
            // 
            // afisare_btn
            // 
            afisare_btn.BackColor = Color.FromArgb(54, 54, 54);
            afisare_btn.Dock = DockStyle.Fill;
            afisare_btn.FlatStyle = FlatStyle.Flat;
            afisare_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            afisare_btn.ForeColor = Color.LightGray;
            afisare_btn.Location = new Point(0, 0);
            afisare_btn.Margin = new Padding(0, 0, 10, 30);
            afisare_btn.Name = "afisare_btn";
            tableLayoutPanel1.SetRowSpan(afisare_btn, 2);
            afisare_btn.Size = new Size(380, 86);
            afisare_btn.TabIndex = 1;
            afisare_btn.Text = "Afisează";
            afisare_btn.UseVisualStyleBackColor = false;
            afisare_btn.Click += afisare_btn_Click;
            // 
            // coloana_cb
            // 
            coloana_cb.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            coloana_cb.BackColor = Color.FromArgb(54, 54, 54);
            coloana_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            coloana_cb.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            coloana_cb.ForeColor = Color.White;
            coloana_cb.FormattingEnabled = true;
            coloana_cb.Location = new Point(400, 47);
            coloana_cb.Margin = new Padding(10, 3, 10, 30);
            coloana_cb.Name = "coloana_cb";
            coloana_cb.Size = new Size(370, 39);
            coloana_cb.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(393, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 5, 5, 5);
            label3.Size = new Size(384, 39);
            label3.TabIndex = 0;
            label3.Text = "Selectează criteriu";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_panel
            // 
            button_panel.Controls.Add(panel2);
            button_panel.Controls.Add(panel1);
            button_panel.Dock = DockStyle.Bottom;
            button_panel.Location = new Point(0, 808);
            button_panel.Name = "button_panel";
            button_panel.Size = new Size(1660, 155);
            button_panel.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(50, 0, 50, 0);
            panel2.Size = new Size(1660, 116);
            panel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(coloana_cb, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(valoare_tb, 2, 1);
            tableLayoutPanel1.Controls.Add(label1, 2, 0);
            tableLayoutPanel1.Controls.Add(afisare_btn, 0, 0);
            tableLayoutPanel1.Controls.Add(cauta_btn, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(50, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.62069F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.37931F));
            tableLayoutPanel1.Size = new Size(1560, 116);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // valoare_tb
            // 
            valoare_tb.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            valoare_tb.BackColor = Color.FromArgb(54, 54, 54);
            valoare_tb.BorderStyle = BorderStyle.FixedSingle;
            valoare_tb.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            valoare_tb.ForeColor = Color.White;
            valoare_tb.Location = new Point(790, 48);
            valoare_tb.Margin = new Padding(10, 0, 10, 30);
            valoare_tb.Name = "valoare_tb";
            valoare_tb.Size = new Size(370, 38);
            valoare_tb.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(783, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 5, 5, 5);
            label1.Size = new Size(384, 39);
            label1.TabIndex = 0;
            label1.Text = "Introduceți valoarea";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cauta_btn
            // 
            cauta_btn.BackColor = Color.FromArgb(54, 54, 54);
            cauta_btn.Dock = DockStyle.Fill;
            cauta_btn.FlatStyle = FlatStyle.Flat;
            cauta_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cauta_btn.ForeColor = Color.LightGray;
            cauta_btn.Location = new Point(1180, 0);
            cauta_btn.Margin = new Padding(10, 0, 0, 30);
            cauta_btn.Name = "cauta_btn";
            tableLayoutPanel1.SetRowSpan(cauta_btn, 2);
            cauta_btn.Size = new Size(380, 86);
            cauta_btn.TabIndex = 4;
            cauta_btn.Text = "Caută după criteriu";
            cauta_btn.UseVisualStyleBackColor = false;
            cauta_btn.Click += cauta_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 54, 54);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(1660, 39);
            panel1.TabIndex = 1;
            // 
            // grid_panel
            // 
            grid_panel.Controls.Add(afisare_gv);
            grid_panel.Dock = DockStyle.Fill;
            grid_panel.Location = new Point(0, 0);
            grid_panel.Name = "grid_panel";
            grid_panel.Padding = new Padding(50);
            grid_panel.Size = new Size(1660, 808);
            grid_panel.TabIndex = 18;
            // 
            // afisare_gv
            // 
            afisare_gv.AllowUserToAddRows = false;
            afisare_gv.AllowUserToDeleteRows = false;
            afisare_gv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            afisare_gv.BackgroundColor = Color.FromArgb(54, 54, 54);
            afisare_gv.BorderStyle = BorderStyle.Fixed3D;
            afisare_gv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(54, 54, 54);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            afisare_gv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            afisare_gv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(54, 54, 54);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            afisare_gv.DefaultCellStyle = dataGridViewCellStyle2;
            afisare_gv.Dock = DockStyle.Fill;
            afisare_gv.Location = new Point(50, 50);
            afisare_gv.Name = "afisare_gv";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(54, 54, 54);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            afisare_gv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            afisare_gv.RowHeadersVisible = false;
            afisare_gv.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(54, 54, 54);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            afisare_gv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            afisare_gv.Size = new Size(1560, 708);
            afisare_gv.TabIndex = 0;
            // 
            // SearchForm
            // 
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1660, 963);
            Controls.Add(grid_panel);
            Controls.Add(button_panel);
            Name = "SearchForm";
            button_panel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            grid_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)afisare_gv).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button afisare_btn;
        private ComboBox coloana_cb;
        private Label label3;
        private Panel button_panel;
        private Panel grid_panel;
        private DataGridView afisare_gv;
        private Panel panel1;
        private Button cauta_btn;
        private TextBox valoare_tb;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
    }
}