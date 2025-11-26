namespace GestiuneCarti.Forms
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            menu_pnl = new Panel();
            label2 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            imprimare_btn = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            search_btn = new FontAwesome.Sharp.IconButton();
            modify_btn = new FontAwesome.Sharp.IconButton();
            add_btn = new FontAwesome.Sharp.IconButton();
            logo_pnl = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            restart_btn = new FontAwesome.Sharp.IconPictureBox();
            restart_lbl2 = new Label();
            restart_lbl = new Label();
            titlebar_pnl = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            iconCurentChildForm = new FontAwesome.Sharp.IconPictureBox();
            labelCurentChildForm = new Label();
            minimize_btn = new FontAwesome.Sharp.IconButton();
            maximize_btn = new FontAwesome.Sharp.IconButton();
            close_btn = new FontAwesome.Sharp.IconButton();
            desktop_pnl = new Panel();
            menu_pnl.SuspendLayout();
            logo_pnl.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)restart_btn).BeginInit();
            titlebar_pnl.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurentChildForm).BeginInit();
            SuspendLayout();
            // 
            // menu_pnl
            // 
            menu_pnl.BackColor = Color.FromArgb(54, 54, 54);
            menu_pnl.Controls.Add(label2);
            menu_pnl.Controls.Add(iconButton1);
            menu_pnl.Controls.Add(imprimare_btn);
            menu_pnl.Controls.Add(label1);
            menu_pnl.Controls.Add(search_btn);
            menu_pnl.Controls.Add(modify_btn);
            menu_pnl.Controls.Add(add_btn);
            menu_pnl.Controls.Add(logo_pnl);
            menu_pnl.Dock = DockStyle.Left;
            menu_pnl.Location = new Point(0, 3);
            menu_pnl.Name = "menu_pnl";
            menu_pnl.Size = new Size(266, 1030);
            menu_pnl.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 1000);
            label2.Margin = new Padding(10, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(228, 20);
            label2.TabIndex = 1;
            label2.Text = "Dezvoltator: Porcesco Stanislav";
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.SquareMinus;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 525);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 21, 0);
            iconButton1.Size = new Size(266, 100);
            iconButton1.TabIndex = 5;
            iconButton1.Text = "Șterge";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // imprimare_btn
            // 
            imprimare_btn.Dock = DockStyle.Top;
            imprimare_btn.FlatAppearance.BorderSize = 0;
            imprimare_btn.FlatStyle = FlatStyle.Flat;
            imprimare_btn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            imprimare_btn.ForeColor = Color.White;
            imprimare_btn.IconChar = FontAwesome.Sharp.IconChar.Print;
            imprimare_btn.IconColor = Color.White;
            imprimare_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imprimare_btn.ImageAlign = ContentAlignment.MiddleLeft;
            imprimare_btn.Location = new Point(0, 425);
            imprimare_btn.Name = "imprimare_btn";
            imprimare_btn.Padding = new Padding(10, 0, 21, 0);
            imprimare_btn.Size = new Size(266, 100);
            imprimare_btn.TabIndex = 4;
            imprimare_btn.Text = "Imprimează";
            imprimare_btn.TextAlign = ContentAlignment.MiddleLeft;
            imprimare_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            imprimare_btn.UseVisualStyleBackColor = true;
            imprimare_btn.Click += imprimare_btn_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 0;
            // 
            // search_btn
            // 
            search_btn.Dock = DockStyle.Top;
            search_btn.FlatAppearance.BorderSize = 0;
            search_btn.FlatStyle = FlatStyle.Flat;
            search_btn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            search_btn.ForeColor = Color.White;
            search_btn.IconChar = FontAwesome.Sharp.IconChar.Search;
            search_btn.IconColor = Color.White;
            search_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            search_btn.ImageAlign = ContentAlignment.MiddleLeft;
            search_btn.Location = new Point(0, 325);
            search_btn.Name = "search_btn";
            search_btn.Padding = new Padding(10, 0, 21, 0);
            search_btn.Size = new Size(266, 100);
            search_btn.TabIndex = 3;
            search_btn.Text = "Caută";
            search_btn.TextAlign = ContentAlignment.MiddleLeft;
            search_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // modify_btn
            // 
            modify_btn.Dock = DockStyle.Top;
            modify_btn.FlatAppearance.BorderSize = 0;
            modify_btn.FlatStyle = FlatStyle.Flat;
            modify_btn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            modify_btn.ForeColor = Color.White;
            modify_btn.IconChar = FontAwesome.Sharp.IconChar.SquarePen;
            modify_btn.IconColor = Color.White;
            modify_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            modify_btn.ImageAlign = ContentAlignment.MiddleLeft;
            modify_btn.Location = new Point(0, 225);
            modify_btn.Name = "modify_btn";
            modify_btn.Padding = new Padding(10, 0, 21, 0);
            modify_btn.Size = new Size(266, 100);
            modify_btn.TabIndex = 2;
            modify_btn.Text = "Modifică";
            modify_btn.TextAlign = ContentAlignment.MiddleLeft;
            modify_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            modify_btn.UseVisualStyleBackColor = true;
            modify_btn.Click += modify_btn_Click;
            // 
            // add_btn
            // 
            add_btn.Dock = DockStyle.Top;
            add_btn.FlatAppearance.BorderSize = 0;
            add_btn.FlatStyle = FlatStyle.Flat;
            add_btn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            add_btn.ForeColor = Color.White;
            add_btn.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            add_btn.IconColor = Color.White;
            add_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            add_btn.ImageAlign = ContentAlignment.MiddleLeft;
            add_btn.Location = new Point(0, 125);
            add_btn.Name = "add_btn";
            add_btn.Padding = new Padding(10, 0, 21, 0);
            add_btn.Size = new Size(266, 100);
            add_btn.TabIndex = 1;
            add_btn.Text = "Adaugă";
            add_btn.TextAlign = ContentAlignment.MiddleLeft;
            add_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // logo_pnl
            // 
            logo_pnl.Controls.Add(tableLayoutPanel2);
            logo_pnl.Dock = DockStyle.Top;
            logo_pnl.Location = new Point(0, 0);
            logo_pnl.Name = "logo_pnl";
            logo_pnl.Size = new Size(266, 125);
            logo_pnl.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.4736824F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.5263176F));
            tableLayoutPanel2.Controls.Add(restart_btn, 0, 0);
            tableLayoutPanel2.Controls.Add(restart_lbl2, 1, 1);
            tableLayoutPanel2.Controls.Add(restart_lbl, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(266, 125);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // restart_btn
            // 
            restart_btn.Anchor = AnchorStyles.None;
            restart_btn.BackColor = Color.FromArgb(54, 54, 54);
            restart_btn.IconChar = FontAwesome.Sharp.IconChar.Book;
            restart_btn.IconColor = Color.White;
            restart_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            restart_btn.IconSize = 85;
            restart_btn.Location = new Point(10, 3);
            restart_btn.Name = "restart_btn";
            restart_btn.Padding = new Padding(0, 20, 0, 20);
            tableLayoutPanel2.SetRowSpan(restart_btn, 2);
            restart_btn.Size = new Size(85, 98);
            restart_btn.TabIndex = 0;
            restart_btn.TabStop = false;
            restart_btn.Click += restart_btn_Click;
            // 
            // restart_lbl2
            // 
            restart_lbl2.AutoSize = true;
            restart_lbl2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            restart_lbl2.ForeColor = Color.White;
            restart_lbl2.Location = new Point(108, 52);
            restart_lbl2.Name = "restart_lbl2";
            restart_lbl2.Size = new Size(79, 38);
            restart_lbl2.TabIndex = 0;
            restart_lbl2.Text = "Cărți";
            restart_lbl2.Click += restart_lbl2_Click;
            // 
            // restart_lbl
            // 
            restart_lbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            restart_lbl.AutoSize = true;
            restart_lbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            restart_lbl.ForeColor = Color.White;
            restart_lbl.Location = new Point(108, 14);
            restart_lbl.Name = "restart_lbl";
            restart_lbl.Size = new Size(132, 38);
            restart_lbl.TabIndex = 0;
            restart_lbl.Text = "Gestiune";
            restart_lbl.TextAlign = ContentAlignment.BottomLeft;
            restart_lbl.Click += restart_lbl_Click;
            // 
            // titlebar_pnl
            // 
            titlebar_pnl.BackColor = Color.FromArgb(54, 54, 54);
            titlebar_pnl.Controls.Add(panel1);
            titlebar_pnl.Controls.Add(minimize_btn);
            titlebar_pnl.Controls.Add(maximize_btn);
            titlebar_pnl.Controls.Add(close_btn);
            titlebar_pnl.Dock = DockStyle.Top;
            titlebar_pnl.Location = new Point(266, 3);
            titlebar_pnl.MaximumSize = new Size(0, 53);
            titlebar_pnl.MinimumSize = new Size(0, 35);
            titlebar_pnl.Name = "titlebar_pnl";
            titlebar_pnl.Size = new Size(1636, 53);
            titlebar_pnl.TabIndex = 1;
            titlebar_pnl.MouseDown += titlebar_pnl_MouseDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 7, 0, 0);
            panel1.Size = new Size(308, 53);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(308, 46);
            panel2.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.6233768F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.3766251F));
            tableLayoutPanel1.Controls.Add(iconCurentChildForm, 0, 0);
            tableLayoutPanel1.Controls.Add(labelCurentChildForm, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(308, 46);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // iconCurentChildForm
            // 
            iconCurentChildForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iconCurentChildForm.BackColor = Color.FromArgb(64, 64, 64);
            iconCurentChildForm.BackgroundImageLayout = ImageLayout.None;
            iconCurentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurentChildForm.IconColor = Color.White;
            iconCurentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurentChildForm.IconSize = 40;
            iconCurentChildForm.Location = new Point(3, 3);
            iconCurentChildForm.Name = "iconCurentChildForm";
            iconCurentChildForm.Padding = new Padding(21, 0, 21, 0);
            iconCurentChildForm.Size = new Size(76, 40);
            iconCurentChildForm.TabIndex = 3;
            iconCurentChildForm.TabStop = false;
            // 
            // labelCurentChildForm
            // 
            labelCurentChildForm.BackColor = Color.FromArgb(64, 64, 64);
            labelCurentChildForm.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCurentChildForm.ForeColor = Color.White;
            labelCurentChildForm.Location = new Point(85, 0);
            labelCurentChildForm.Margin = new Padding(3, 0, 3, 7);
            labelCurentChildForm.Name = "labelCurentChildForm";
            labelCurentChildForm.Size = new Size(218, 39);
            labelCurentChildForm.TabIndex = 4;
            labelCurentChildForm.Text = "Acasă";
            labelCurentChildForm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // minimize_btn
            // 
            minimize_btn.Dock = DockStyle.Right;
            minimize_btn.FlatAppearance.BorderSize = 0;
            minimize_btn.FlatStyle = FlatStyle.Flat;
            minimize_btn.ForeColor = Color.FromArgb(224, 224, 224);
            minimize_btn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            minimize_btn.IconColor = Color.FromArgb(224, 224, 224);
            minimize_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            minimize_btn.IconSize = 30;
            minimize_btn.Location = new Point(1354, 0);
            minimize_btn.Name = "minimize_btn";
            minimize_btn.Size = new Size(94, 53);
            minimize_btn.TabIndex = 6;
            minimize_btn.TextAlign = ContentAlignment.MiddleRight;
            minimize_btn.UseVisualStyleBackColor = true;
            minimize_btn.Click += minimize_btn_Click;
            // 
            // maximize_btn
            // 
            maximize_btn.Dock = DockStyle.Right;
            maximize_btn.FlatAppearance.BorderSize = 0;
            maximize_btn.FlatStyle = FlatStyle.Flat;
            maximize_btn.ForeColor = Color.FromArgb(224, 224, 224);
            maximize_btn.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            maximize_btn.IconColor = Color.FromArgb(224, 224, 224);
            maximize_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            maximize_btn.IconSize = 30;
            maximize_btn.Location = new Point(1448, 0);
            maximize_btn.Name = "maximize_btn";
            maximize_btn.Size = new Size(94, 53);
            maximize_btn.TabIndex = 7;
            maximize_btn.TextAlign = ContentAlignment.MiddleRight;
            maximize_btn.UseVisualStyleBackColor = true;
            maximize_btn.Click += maximize_btn_Click;
            // 
            // close_btn
            // 
            close_btn.Dock = DockStyle.Right;
            close_btn.FlatAppearance.BorderSize = 0;
            close_btn.FlatStyle = FlatStyle.Flat;
            close_btn.ForeColor = Color.FromArgb(224, 224, 224);
            close_btn.IconChar = FontAwesome.Sharp.IconChar.Close;
            close_btn.IconColor = Color.FromArgb(224, 224, 224);
            close_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            close_btn.IconSize = 30;
            close_btn.Location = new Point(1542, 0);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(94, 53);
            close_btn.TabIndex = 8;
            close_btn.TextAlign = ContentAlignment.MiddleRight;
            close_btn.UseVisualStyleBackColor = true;
            close_btn.Click += close_btn_Click;
            // 
            // desktop_pnl
            // 
            desktop_pnl.Dock = DockStyle.Fill;
            desktop_pnl.Location = new Point(266, 56);
            desktop_pnl.Name = "desktop_pnl";
            desktop_pnl.Size = new Size(1636, 977);
            desktop_pnl.TabIndex = 2;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1902, 1033);
            Controls.Add(desktop_pnl);
            Controls.Add(titlebar_pnl);
            Controls.Add(menu_pnl);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuForm";
            Padding = new Padding(0, 3, 0, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestiune Cărți";
            Load += MenuForm_Load;
            menu_pnl.ResumeLayout(false);
            menu_pnl.PerformLayout();
            logo_pnl.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)restart_btn).EndInit();
            titlebar_pnl.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconCurentChildForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel menu_pnl;
        private FontAwesome.Sharp.IconButton add_btn;
        private Panel logo_pnl;
        private FontAwesome.Sharp.IconButton search_btn;
        private FontAwesome.Sharp.IconButton modify_btn;
        private Panel titlebar_pnl;
        private FontAwesome.Sharp.IconButton close_btn;
        private FontAwesome.Sharp.IconButton maximize_btn;
        private FontAwesome.Sharp.IconButton minimize_btn;
        private FontAwesome.Sharp.IconPictureBox restart_btn;
        private FontAwesome.Sharp.IconPictureBox iconCurentChildForm;
        private Label labelCurentChildForm;
        private Panel panel1;
        private Panel desktop_pnl;
        private Label restart_lbl2;
        private Label restart_lbl;
        private Label label1;
        private FontAwesome.Sharp.IconButton imprimare_btn;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
    }
}