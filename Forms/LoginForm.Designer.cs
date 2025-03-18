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
            SuspendLayout();
            // 
            // username_txt
            // 
            username_txt.Anchor = AnchorStyles.None;
            username_txt.BackColor = Color.Gray;
            username_txt.BorderStyle = BorderStyle.None;
            username_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username_txt.ForeColor = Color.White;
            username_txt.Location = new Point(131, 98);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(336, 27);
            username_txt.TabIndex = 0;
            // 
            // password_txt
            // 
            password_txt.Anchor = AnchorStyles.None;
            password_txt.BackColor = Color.Gray;
            password_txt.BorderStyle = BorderStyle.None;
            password_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password_txt.ForeColor = Color.White;
            password_txt.Location = new Point(131, 145);
            password_txt.Name = "password_txt";
            password_txt.PasswordChar = '*';
            password_txt.Size = new Size(336, 27);
            password_txt.TabIndex = 0;
            // 
            // username_lbl
            // 
            username_lbl.Anchor = AnchorStyles.None;
            username_lbl.AutoSize = true;
            username_lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username_lbl.ForeColor = Color.White;
            username_lbl.Location = new Point(35, 98);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(80, 20);
            username_lbl.TabIndex = 1;
            username_lbl.Text = "Username";
            // 
            // password_lbl
            // 
            password_lbl.Anchor = AnchorStyles.None;
            password_lbl.AutoSize = true;
            password_lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password_lbl.ForeColor = Color.White;
            password_lbl.Location = new Point(35, 144);
            password_lbl.Name = "password_lbl";
            password_lbl.Size = new Size(76, 20);
            password_lbl.TabIndex = 2;
            password_lbl.Text = "Password";
            // 
            // connect_btn
            // 
            connect_btn.Anchor = AnchorStyles.None;
            connect_btn.BackColor = Color.Gray;
            connect_btn.FlatStyle = FlatStyle.Popup;
            connect_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            connect_btn.ForeColor = Color.White;
            connect_btn.Location = new Point(314, 208);
            connect_btn.Name = "connect_btn";
            connect_btn.Size = new Size(153, 45);
            connect_btn.TabIndex = 3;
            connect_btn.Text = "Conectare";
            connect_btn.UseVisualStyleBackColor = false;
            connect_btn.Click += connect_Click;
            // 
            // exit_btn
            // 
            exit_btn.Anchor = AnchorStyles.None;
            exit_btn.BackColor = Color.Gray;
            exit_btn.FlatStyle = FlatStyle.Popup;
            exit_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            exit_btn.ForeColor = Color.White;
            exit_btn.Location = new Point(131, 208);
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
            welecome_lbl.Location = new Point(162, 38);
            welecome_lbl.Name = "welecome_lbl";
            welecome_lbl.Size = new Size(261, 31);
            welecome_lbl.TabIndex = 4;
            welecome_lbl.Text = "Conectare bază de date";
            welecome_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(131, 178);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(118, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Arată parola";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(552, 287);
            Controls.Add(checkBox1);
            Controls.Add(welecome_lbl);
            Controls.Add(exit_btn);
            Controls.Add(connect_btn);
            Controls.Add(password_lbl);
            Controls.Add(username_lbl);
            Controls.Add(password_txt);
            Controls.Add(username_txt);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(570, 334);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestiuneCarti";
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
    }
}
