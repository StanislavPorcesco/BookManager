namespace GestiuneCarti
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            username_txt = new TextBox();
            password_txt = new TextBox();
            username_lbl = new Label();
            password_lbl = new Label();
            connect_btn = new Button();
            exit_btn = new Button();
            welecome_lbl = new Label();
            checkBox1 = new CheckBox();
            host_txt = new TextBox();
            label1 = new Label();
            port_txt = new TextBox();
            label2 = new Label();
            serviceName_txt = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // username_txt
            // 
            username_txt.Anchor = AnchorStyles.Top;
            username_txt.BackColor = Color.Gray;
            username_txt.BorderStyle = BorderStyle.None;
            username_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username_txt.ForeColor = Color.White;
            username_txt.Location = new Point(129, 118);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(336, 27);
            username_txt.TabIndex = 0;
            // 
            // password_txt
            // 
            password_txt.Anchor = AnchorStyles.Top;
            password_txt.BackColor = Color.Gray;
            password_txt.BorderStyle = BorderStyle.None;
            password_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password_txt.ForeColor = Color.White;
            password_txt.Location = new Point(129, 168);
            password_txt.Name = "password_txt";
            password_txt.PasswordChar = '*';
            password_txt.Size = new Size(336, 27);
            password_txt.TabIndex = 0;
            // 
            // username_lbl
            // 
            username_lbl.Anchor = AnchorStyles.Top;
            username_lbl.AutoSize = true;
            username_lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username_lbl.ForeColor = Color.White;
            username_lbl.Location = new Point(35, 121);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(74, 20);
            username_lbl.TabIndex = 1;
            username_lbl.Text = "Utilizator";
            // 
            // password_lbl
            // 
            password_lbl.Anchor = AnchorStyles.Top;
            password_lbl.AutoSize = true;
            password_lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password_lbl.ForeColor = Color.White;
            password_lbl.Location = new Point(56, 171);
            password_lbl.Name = "password_lbl";
            password_lbl.Size = new Size(53, 20);
            password_lbl.TabIndex = 2;
            password_lbl.Text = "Parola";
            // 
            // connect_btn
            // 
            connect_btn.Anchor = AnchorStyles.Top;
            connect_btn.BackColor = Color.Gray;
            connect_btn.FlatStyle = FlatStyle.Popup;
            connect_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            connect_btn.ForeColor = Color.White;
            connect_btn.Location = new Point(312, 381);
            connect_btn.Name = "connect_btn";
            connect_btn.Size = new Size(153, 45);
            connect_btn.TabIndex = 3;
            connect_btn.Text = "Conectare";
            connect_btn.UseVisualStyleBackColor = false;
            connect_btn.Click += connect_Click;
            // 
            // exit_btn
            // 
            exit_btn.Anchor = AnchorStyles.Top;
            exit_btn.BackColor = Color.Gray;
            exit_btn.FlatStyle = FlatStyle.Popup;
            exit_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            exit_btn.ForeColor = Color.White;
            exit_btn.Location = new Point(129, 381);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(149, 45);
            exit_btn.TabIndex = 3;
            exit_btn.Text = "Anulează";
            exit_btn.UseVisualStyleBackColor = false;
            exit_btn.Click += exit_Click;
            // 
            // welecome_lbl
            // 
            welecome_lbl.Anchor = AnchorStyles.None;
            welecome_lbl.AutoSize = true;
            welecome_lbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welecome_lbl.ForeColor = Color.White;
            welecome_lbl.Location = new Point(166, 22);
            welecome_lbl.Name = "welecome_lbl";
            welecome_lbl.Size = new Size(261, 31);
            welecome_lbl.TabIndex = 4;
            welecome_lbl.Text = "Conectare bază de date";
            welecome_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top;
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(129, 351);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(118, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Arată parola";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // host_txt
            // 
            host_txt.Anchor = AnchorStyles.Top;
            host_txt.BackColor = Color.Gray;
            host_txt.BorderStyle = BorderStyle.None;
            host_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            host_txt.ForeColor = Color.White;
            host_txt.Location = new Point(129, 218);
            host_txt.Name = "host_txt";
            host_txt.Size = new Size(336, 27);
            host_txt.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(33, 221);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 2;
            label1.Text = "Adresa IP";
            // 
            // port_txt
            // 
            port_txt.Anchor = AnchorStyles.Top;
            port_txt.BackColor = Color.Gray;
            port_txt.BorderStyle = BorderStyle.None;
            port_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            port_txt.ForeColor = Color.White;
            port_txt.Location = new Point(129, 268);
            port_txt.Name = "port_txt";
            port_txt.Size = new Size(336, 27);
            port_txt.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(52, 271);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 2;
            label2.Text = "Port-ul";
            // 
            // serviceName_txt
            // 
            serviceName_txt.Anchor = AnchorStyles.Top;
            serviceName_txt.BackColor = Color.Gray;
            serviceName_txt.BorderStyle = BorderStyle.None;
            serviceName_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            serviceName_txt.ForeColor = Color.White;
            serviceName_txt.Location = new Point(129, 318);
            serviceName_txt.Name = "serviceName_txt";
            serviceName_txt.Size = new Size(336, 27);
            serviceName_txt.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(50, 321);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 2;
            label3.Text = "Service";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 54, 54);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(welecome_lbl);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(595, 76);
            panel1.TabIndex = 6;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(54, 54, 54);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Book;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 59;
            iconPictureBox1.Location = new Point(13, 11);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(74, 59);
            iconPictureBox1.TabIndex = 5;
            iconPictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(595, 451);
            Controls.Add(panel1);
            Controls.Add(checkBox1);
            Controls.Add(exit_btn);
            Controls.Add(connect_btn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password_lbl);
            Controls.Add(username_lbl);
            Controls.Add(serviceName_txt);
            Controls.Add(port_txt);
            Controls.Add(host_txt);
            Controls.Add(password_txt);
            Controls.Add(username_txt);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestiuneCarti";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username_txt;
        private TextBox password_txt;
        private Label username_lbl;
        private Label password_lbl;
        private Button connect_btn;
        private Button exit_btn;
        private Label welecome_lbl;
        private CheckBox checkBox1;
        private TextBox host_txt;
        private Label label1;
        private TextBox port_txt;
        private Label label2;
        private TextBox serviceName_txt;
        private Label label3;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
