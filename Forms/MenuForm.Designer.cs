namespace GestiuneCarti
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
            search_btn = new FontAwesome.Sharp.IconButton();
            modify_btn = new FontAwesome.Sharp.IconButton();
            delete_btn = new FontAwesome.Sharp.IconButton();
            add_btn = new FontAwesome.Sharp.IconButton();
            logo_pnl = new Panel();
            restart_btn = new FontAwesome.Sharp.IconPictureBox();
            titlebar_pnl = new Panel();
            panel1 = new Panel();
            labelCurentChildForm = new Label();
            iconCurentChildForm = new FontAwesome.Sharp.IconPictureBox();
            minimize_btn = new FontAwesome.Sharp.IconButton();
            maximize_btn = new FontAwesome.Sharp.IconButton();
            close_btn = new FontAwesome.Sharp.IconButton();
            desktop_pnl = new Panel();
            menu_pnl.SuspendLayout();
            logo_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)restart_btn).BeginInit();
            titlebar_pnl.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurentChildForm).BeginInit();
            SuspendLayout();
            // 
            // menu_pnl
            // 
            menu_pnl.BackColor = Color.FromArgb(54, 54, 54);
            menu_pnl.Controls.Add(search_btn);
            menu_pnl.Controls.Add(modify_btn);
            menu_pnl.Controls.Add(delete_btn);
            menu_pnl.Controls.Add(add_btn);
            menu_pnl.Controls.Add(logo_pnl);
            menu_pnl.Dock = DockStyle.Left;
            menu_pnl.Location = new Point(0, 2);
            menu_pnl.Name = "menu_pnl";
            menu_pnl.Size = new Size(220, 630);
            menu_pnl.TabIndex = 0;
            // 
            // search_btn
            // 
            search_btn.Dock = DockStyle.Top;
            search_btn.FlatAppearance.BorderSize = 0;
            search_btn.FlatStyle = FlatStyle.Flat;
            search_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_btn.ForeColor = Color.White;
            search_btn.IconChar = FontAwesome.Sharp.IconChar.Search;
            search_btn.IconColor = Color.White;
            search_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            search_btn.ImageAlign = ContentAlignment.MiddleLeft;
            search_btn.Location = new Point(0, 350);
            search_btn.Name = "search_btn";
            search_btn.Padding = new Padding(10, 0, 20, 0);
            search_btn.Size = new Size(220, 75);
            search_btn.TabIndex = 4;
            search_btn.Text = "Caută cărți";
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
            modify_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            modify_btn.ForeColor = Color.White;
            modify_btn.IconChar = FontAwesome.Sharp.IconChar.SquarePen;
            modify_btn.IconColor = Color.White;
            modify_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            modify_btn.ImageAlign = ContentAlignment.MiddleLeft;
            modify_btn.Location = new Point(0, 275);
            modify_btn.Name = "modify_btn";
            modify_btn.Padding = new Padding(10, 0, 20, 0);
            modify_btn.Size = new Size(220, 75);
            modify_btn.TabIndex = 3;
            modify_btn.Text = "Modifică cărți";
            modify_btn.TextAlign = ContentAlignment.MiddleLeft;
            modify_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            modify_btn.UseVisualStyleBackColor = true;
            modify_btn.Click += modify_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Dock = DockStyle.Top;
            delete_btn.FlatAppearance.BorderSize = 0;
            delete_btn.FlatStyle = FlatStyle.Flat;
            delete_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_btn.ForeColor = Color.White;
            delete_btn.IconChar = FontAwesome.Sharp.IconChar.SquareMinus;
            delete_btn.IconColor = Color.White;
            delete_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            delete_btn.ImageAlign = ContentAlignment.MiddleLeft;
            delete_btn.Location = new Point(0, 200);
            delete_btn.Name = "delete_btn";
            delete_btn.Padding = new Padding(10, 0, 20, 0);
            delete_btn.Size = new Size(220, 75);
            delete_btn.TabIndex = 2;
            delete_btn.Text = "Șterge cărți";
            delete_btn.TextAlign = ContentAlignment.MiddleLeft;
            delete_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // add_btn
            // 
            add_btn.Dock = DockStyle.Top;
            add_btn.FlatAppearance.BorderSize = 0;
            add_btn.FlatStyle = FlatStyle.Flat;
            add_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_btn.ForeColor = Color.White;
            add_btn.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            add_btn.IconColor = Color.White;
            add_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            add_btn.ImageAlign = ContentAlignment.MiddleLeft;
            add_btn.Location = new Point(0, 125);
            add_btn.Name = "add_btn";
            add_btn.Padding = new Padding(10, 0, 20, 0);
            add_btn.Size = new Size(220, 75);
            add_btn.TabIndex = 1;
            add_btn.Text = "Adaugă cărți";
            add_btn.TextAlign = ContentAlignment.MiddleLeft;
            add_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // logo_pnl
            // 
            logo_pnl.Controls.Add(restart_btn);
            logo_pnl.Dock = DockStyle.Top;
            logo_pnl.Location = new Point(0, 0);
            logo_pnl.Name = "logo_pnl";
            logo_pnl.Size = new Size(220, 125);
            logo_pnl.TabIndex = 0;
            // 
            // restart_btn
            // 
            restart_btn.Anchor = AnchorStyles.None;
            restart_btn.BackColor = Color.FromArgb(54, 54, 54);
            restart_btn.ForeColor = Color.FromArgb(224, 224, 224);
            restart_btn.IconChar = FontAwesome.Sharp.IconChar.Book;
            restart_btn.IconColor = Color.FromArgb(224, 224, 224);
            restart_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            restart_btn.IconSize = 85;
            restart_btn.Location = new Point(57, 0);
            restart_btn.Name = "restart_btn";
            restart_btn.Padding = new Padding(0, 20, 0, 20);
            restart_btn.Size = new Size(85, 125);
            restart_btn.TabIndex = 0;
            restart_btn.TabStop = false;
            restart_btn.Click += restart_btn_Click;
            // 
            // titlebar_pnl
            // 
            titlebar_pnl.BackColor = Color.FromArgb(54, 54, 54);
            titlebar_pnl.Controls.Add(panel1);
            titlebar_pnl.Controls.Add(minimize_btn);
            titlebar_pnl.Controls.Add(maximize_btn);
            titlebar_pnl.Controls.Add(close_btn);
            titlebar_pnl.Dock = DockStyle.Top;
            titlebar_pnl.Location = new Point(220, 2);
            titlebar_pnl.MaximumSize = new Size(0, 35);
            titlebar_pnl.MinimumSize = new Size(0, 35);
            titlebar_pnl.Name = "titlebar_pnl";
            titlebar_pnl.Size = new Size(876, 35);
            titlebar_pnl.TabIndex = 1;
            titlebar_pnl.MouseDown += titlebar_pnl_MouseDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(labelCurentChildForm);
            panel1.Controls.Add(iconCurentChildForm);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 35);
            panel1.TabIndex = 3;
            // 
            // labelCurentChildForm
            // 
            labelCurentChildForm.BackColor = Color.FromArgb(64, 64, 64);
            labelCurentChildForm.Dock = DockStyle.Left;
            labelCurentChildForm.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCurentChildForm.ForeColor = Color.White;
            labelCurentChildForm.Location = new Point(55, 0);
            labelCurentChildForm.Name = "labelCurentChildForm";
            labelCurentChildForm.Padding = new Padding(0, 5, 0, 0);
            labelCurentChildForm.Size = new Size(155, 35);
            labelCurentChildForm.TabIndex = 4;
            labelCurentChildForm.Text = "Acasă";
            // 
            // iconCurentChildForm
            // 
            iconCurentChildForm.BackColor = Color.FromArgb(64, 64, 64);
            iconCurentChildForm.Dock = DockStyle.Left;
            iconCurentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurentChildForm.IconColor = Color.White;
            iconCurentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurentChildForm.IconSize = 35;
            iconCurentChildForm.Location = new Point(0, 0);
            iconCurentChildForm.Name = "iconCurentChildForm";
            iconCurentChildForm.Padding = new Padding(20, 0, 20, 0);
            iconCurentChildForm.Size = new Size(55, 35);
            iconCurentChildForm.TabIndex = 3;
            iconCurentChildForm.TabStop = false;
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
            minimize_btn.Location = new Point(594, 0);
            minimize_btn.Name = "minimize_btn";
            minimize_btn.Size = new Size(94, 35);
            minimize_btn.TabIndex = 1;
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
            maximize_btn.Location = new Point(688, 0);
            maximize_btn.Name = "maximize_btn";
            maximize_btn.Size = new Size(94, 35);
            maximize_btn.TabIndex = 2;
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
            close_btn.Location = new Point(782, 0);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(94, 35);
            close_btn.TabIndex = 0;
            close_btn.TextAlign = ContentAlignment.MiddleRight;
            close_btn.UseVisualStyleBackColor = true;
            close_btn.Click += close_btn_Click;
            // 
            // desktop_pnl
            // 
            desktop_pnl.Dock = DockStyle.Fill;
            desktop_pnl.Location = new Point(220, 37);
            desktop_pnl.Name = "desktop_pnl";
            desktop_pnl.Size = new Size(876, 595);
            desktop_pnl.TabIndex = 2;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1096, 632);
            Controls.Add(desktop_pnl);
            Controls.Add(titlebar_pnl);
            Controls.Add(menu_pnl);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuForm";
            Padding = new Padding(0, 2, 0, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestiuneCarti";
            Load += MenuForm_Load;
            menu_pnl.ResumeLayout(false);
            logo_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)restart_btn).EndInit();
            titlebar_pnl.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconCurentChildForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel menu_pnl;
        private FontAwesome.Sharp.IconButton add_btn;
        private Panel logo_pnl;
        private FontAwesome.Sharp.IconButton search_btn;
        private FontAwesome.Sharp.IconButton modify_btn;
        private FontAwesome.Sharp.IconButton delete_btn;
        private Panel titlebar_pnl;
        private FontAwesome.Sharp.IconButton close_btn;
        private FontAwesome.Sharp.IconButton maximize_btn;
        private FontAwesome.Sharp.IconButton minimize_btn;
        private FontAwesome.Sharp.IconPictureBox restart_btn;
        private FontAwesome.Sharp.IconPictureBox iconCurentChildForm;
        private Label labelCurentChildForm;
        private Panel panel1;
        private Panel desktop_pnl;
    }
}