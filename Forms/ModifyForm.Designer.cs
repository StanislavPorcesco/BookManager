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
            title_ck = new CheckBox();
            limba_ck = new CheckBox();
            autor_ck = new CheckBox();
            loc_ck = new CheckBox();
            an_ck = new CheckBox();
            idCZU_ck = new CheckBox();
            pret_ck = new CheckBox();
            nr_exemp_ck = new CheckBox();
            mainLabel_lbl = new Label();
            label1 = new Label();
            target_txt = new TextBox();
            modify_btn = new FontAwesome.Sharp.IconButton();
            save_btn = new FontAwesome.Sharp.IconButton();
            error_panel = new Panel();
            queryOutput_lbl = new Label();
            label2 = new Label();
            new_val_txt = new TextBox();
            error_panel.SuspendLayout();
            SuspendLayout();
            // 
            // title_ck
            // 
            title_ck.Anchor = AnchorStyles.None;
            title_ck.AutoSize = true;
            title_ck.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title_ck.ForeColor = Color.White;
            title_ck.Location = new Point(215, 103);
            title_ck.Name = "title_ck";
            title_ck.Size = new Size(69, 27);
            title_ck.TabIndex = 0;
            title_ck.Text = "Titlu";
            title_ck.UseVisualStyleBackColor = true;
            title_ck.CheckedChanged += title_ck_CheckedChanged;
            // 
            // limba_ck
            // 
            limba_ck.Anchor = AnchorStyles.None;
            limba_ck.AutoSize = true;
            limba_ck.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            limba_ck.ForeColor = Color.White;
            limba_ck.Location = new Point(215, 136);
            limba_ck.Name = "limba_ck";
            limba_ck.Size = new Size(82, 27);
            limba_ck.TabIndex = 0;
            limba_ck.Text = "Limba";
            limba_ck.UseVisualStyleBackColor = true;
            limba_ck.CheckedChanged += limba_ck_CheckedChanged;
            // 
            // autor_ck
            // 
            autor_ck.Anchor = AnchorStyles.None;
            autor_ck.AutoSize = true;
            autor_ck.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autor_ck.ForeColor = Color.White;
            autor_ck.Location = new Point(215, 169);
            autor_ck.Name = "autor_ck";
            autor_ck.Size = new Size(78, 27);
            autor_ck.TabIndex = 0;
            autor_ck.Text = "Autor";
            autor_ck.UseVisualStyleBackColor = true;
            autor_ck.CheckedChanged += autor_ck_CheckedChanged;
            // 
            // loc_ck
            // 
            loc_ck.Anchor = AnchorStyles.None;
            loc_ck.AutoSize = true;
            loc_ck.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loc_ck.ForeColor = Color.White;
            loc_ck.Location = new Point(215, 202);
            loc_ck.Name = "loc_ck";
            loc_ck.Size = new Size(155, 27);
            loc_ck.TabIndex = 0;
            loc_ck.Text = "Locul publicării";
            loc_ck.UseVisualStyleBackColor = true;
            loc_ck.CheckedChanged += loc_ck_CheckedChanged;
            // 
            // an_ck
            // 
            an_ck.Anchor = AnchorStyles.None;
            an_ck.AutoSize = true;
            an_ck.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            an_ck.ForeColor = Color.White;
            an_ck.Location = new Point(393, 103);
            an_ck.Name = "an_ck";
            an_ck.Size = new Size(150, 27);
            an_ck.TabIndex = 0;
            an_ck.Text = "Anul publicării";
            an_ck.UseVisualStyleBackColor = true;
            an_ck.CheckedChanged += an_ck_CheckedChanged;
            // 
            // idCZU_ck
            // 
            idCZU_ck.Anchor = AnchorStyles.None;
            idCZU_ck.AutoSize = true;
            idCZU_ck.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            idCZU_ck.ForeColor = Color.White;
            idCZU_ck.Location = new Point(393, 136);
            idCZU_ck.Name = "idCZU_ck";
            idCZU_ck.Size = new Size(88, 27);
            idCZU_ck.TabIndex = 0;
            idCZU_ck.Text = "ID CZU";
            idCZU_ck.UseVisualStyleBackColor = true;
            idCZU_ck.CheckedChanged += idCZU_ck_CheckedChanged;
            // 
            // pret_ck
            // 
            pret_ck.Anchor = AnchorStyles.None;
            pret_ck.AutoSize = true;
            pret_ck.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pret_ck.ForeColor = Color.White;
            pret_ck.Location = new Point(393, 169);
            pret_ck.Name = "pret_ck";
            pret_ck.Size = new Size(65, 27);
            pret_ck.TabIndex = 0;
            pret_ck.Text = "Preț";
            pret_ck.UseVisualStyleBackColor = true;
            pret_ck.CheckedChanged += pret_ck_CheckedChanged;
            // 
            // nr_exemp_ck
            // 
            nr_exemp_ck.Anchor = AnchorStyles.None;
            nr_exemp_ck.AutoSize = true;
            nr_exemp_ck.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nr_exemp_ck.ForeColor = Color.White;
            nr_exemp_ck.Location = new Point(393, 202);
            nr_exemp_ck.Name = "nr_exemp_ck";
            nr_exemp_ck.Size = new Size(145, 27);
            nr_exemp_ck.TabIndex = 0;
            nr_exemp_ck.Text = "Nr. exemplare";
            nr_exemp_ck.UseVisualStyleBackColor = true;
            nr_exemp_ck.CheckedChanged += nr_exemp_ck_CheckedChanged;
            // 
            // mainLabel_lbl
            // 
            mainLabel_lbl.Anchor = AnchorStyles.None;
            mainLabel_lbl.AutoSize = true;
            mainLabel_lbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainLabel_lbl.ForeColor = Color.White;
            mainLabel_lbl.Location = new Point(215, 60);
            mainLabel_lbl.Name = "mainLabel_lbl";
            mainLabel_lbl.Size = new Size(315, 31);
            mainLabel_lbl.TabIndex = 1;
            mainLabel_lbl.Text = "Alege ce dorești să modifici:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(190, 244);
            label1.Name = "label1";
            label1.Size = new Size(383, 31);
            label1.TabIndex = 1;
            label1.Text = "ID-ul cărții ce urmează modificată:";
            // 
            // target_txt
            // 
            target_txt.Anchor = AnchorStyles.None;
            target_txt.BackColor = Color.FromArgb(54, 54, 54);
            target_txt.BorderStyle = BorderStyle.FixedSingle;
            target_txt.ForeColor = Color.White;
            target_txt.Location = new Point(190, 288);
            target_txt.Name = "target_txt";
            target_txt.Size = new Size(411, 27);
            target_txt.TabIndex = 2;
            // 
            // modify_btn
            // 
            modify_btn.Anchor = AnchorStyles.None;
            modify_btn.BackColor = Color.FromArgb(54, 54, 54);
            modify_btn.FlatAppearance.BorderColor = Color.DimGray;
            modify_btn.FlatStyle = FlatStyle.Flat;
            modify_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            modify_btn.ForeColor = Color.White;
            modify_btn.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            modify_btn.IconColor = Color.White;
            modify_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            modify_btn.Location = new Point(190, 424);
            modify_btn.Name = "modify_btn";
            modify_btn.Size = new Size(230, 66);
            modify_btn.TabIndex = 3;
            modify_btn.Text = "Modifică";
            modify_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            modify_btn.UseVisualStyleBackColor = false;
            modify_btn.Click += modify_btn_Click;
            // 
            // save_btn
            // 
            save_btn.Anchor = AnchorStyles.None;
            save_btn.BackColor = Color.FromArgb(54, 54, 54);
            save_btn.FlatAppearance.BorderColor = Color.DimGray;
            save_btn.FlatStyle = FlatStyle.Flat;
            save_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            save_btn.ForeColor = Color.White;
            save_btn.IconChar = FontAwesome.Sharp.IconChar.Check;
            save_btn.IconColor = Color.White;
            save_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            save_btn.Location = new Point(440, 424);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(157, 66);
            save_btn.TabIndex = 3;
            save_btn.Text = "Salvează";
            save_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += save_btn_Click;
            // 
            // error_panel
            // 
            error_panel.BackColor = Color.FromArgb(54, 54, 54);
            error_panel.Controls.Add(queryOutput_lbl);
            error_panel.Dock = DockStyle.Bottom;
            error_panel.Location = new Point(0, 538);
            error_panel.Name = "error_panel";
            error_panel.Size = new Size(800, 35);
            error_panel.TabIndex = 4;
            // 
            // queryOutput_lbl
            // 
            queryOutput_lbl.AutoSize = true;
            queryOutput_lbl.Dock = DockStyle.Bottom;
            queryOutput_lbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            queryOutput_lbl.ForeColor = Color.White;
            queryOutput_lbl.Location = new Point(0, 4);
            queryOutput_lbl.Name = "queryOutput_lbl";
            queryOutput_lbl.Size = new Size(0, 31);
            queryOutput_lbl.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(190, 333);
            label2.Name = "label2";
            label2.Size = new Size(171, 31);
            label2.TabIndex = 1;
            label2.Text = "Valoarea nouă:";
            // 
            // new_val_txt
            // 
            new_val_txt.Anchor = AnchorStyles.None;
            new_val_txt.BackColor = Color.FromArgb(54, 54, 54);
            new_val_txt.BorderStyle = BorderStyle.FixedSingle;
            new_val_txt.ForeColor = Color.White;
            new_val_txt.Location = new Point(190, 377);
            new_val_txt.Name = "new_val_txt";
            new_val_txt.Size = new Size(411, 27);
            new_val_txt.TabIndex = 2;
            // 
            // ModifyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 573);
            Controls.Add(error_panel);
            Controls.Add(save_btn);
            Controls.Add(modify_btn);
            Controls.Add(new_val_txt);
            Controls.Add(label2);
            Controls.Add(target_txt);
            Controls.Add(label1);
            Controls.Add(mainLabel_lbl);
            Controls.Add(loc_ck);
            Controls.Add(nr_exemp_ck);
            Controls.Add(autor_ck);
            Controls.Add(pret_ck);
            Controls.Add(idCZU_ck);
            Controls.Add(limba_ck);
            Controls.Add(an_ck);
            Controls.Add(title_ck);
            Name = "ModifyForm";
            Text = "ModifyForm";
            error_panel.ResumeLayout(false);
            error_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox title_ck;
        private CheckBox limba_ck;
        private CheckBox autor_ck;
        private CheckBox loc_ck;
        private CheckBox an_ck;
        private CheckBox idCZU_ck;
        private CheckBox pret_ck;
        private CheckBox nr_exemp_ck;
        private Label mainLabel_lbl;
        private Label label1;
        private TextBox target_txt;
        private FontAwesome.Sharp.IconButton modify_btn;
        private FontAwesome.Sharp.IconButton save_btn;
        private Panel error_panel;
        private Label queryOutput_lbl;
        private Label label2;
        private TextBox new_val_txt;
    }
}