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
            id_carte_txt = new TextBox();
            delete_btn = new FontAwesome.Sharp.IconButton();
            single_lbl = new Label();
            del1_ck = new CheckBox();
            metoda_lbl = new Label();
            delmore_ck = new CheckBox();
            queryOutput_lbl = new Label();
            multi_lbl = new Label();
            range1_txt = new TextBox();
            range2_txt = new TextBox();
            range_lbl = new Label();
            save_btn = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // id_carte_txt
            // 
            id_carte_txt.Anchor = AnchorStyles.None;
            id_carte_txt.BackColor = Color.FromArgb(54, 54, 54);
            id_carte_txt.BorderStyle = BorderStyle.FixedSingle;
            id_carte_txt.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            id_carte_txt.ForeColor = Color.White;
            id_carte_txt.Location = new Point(250, 370);
            id_carte_txt.Name = "id_carte_txt";
            id_carte_txt.Size = new Size(307, 28);
            id_carte_txt.TabIndex = 0;
            // 
            // delete_btn
            // 
            delete_btn.Anchor = AnchorStyles.None;
            delete_btn.BackColor = Color.FromArgb(54, 54, 54);
            delete_btn.FlatAppearance.BorderColor = Color.DimGray;
            delete_btn.FlatStyle = FlatStyle.Flat;
            delete_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_btn.ForeColor = Color.White;
            delete_btn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            delete_btn.IconColor = Color.White;
            delete_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            delete_btn.Location = new Point(250, 433);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(134, 66);
            delete_btn.TabIndex = 2;
            delete_btn.Text = "Șterge";
            delete_btn.TextAlign = ContentAlignment.MiddleLeft;
            delete_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // single_lbl
            // 
            single_lbl.Anchor = AnchorStyles.None;
            single_lbl.AutoSize = true;
            single_lbl.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            single_lbl.ForeColor = Color.White;
            single_lbl.Location = new Point(290, 313);
            single_lbl.Name = "single_lbl";
            single_lbl.Size = new Size(205, 29);
            single_lbl.TabIndex = 3;
            single_lbl.Text = "Introdu ID-ul Cărții";
            single_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // del1_ck
            // 
            del1_ck.Anchor = AnchorStyles.None;
            del1_ck.AutoSize = true;
            del1_ck.Checked = true;
            del1_ck.CheckState = CheckState.Checked;
            del1_ck.Font = new Font("Microsoft Sans Serif", 10.8F);
            del1_ck.ForeColor = Color.White;
            del1_ck.Location = new Point(290, 200);
            del1_ck.Name = "del1_ck";
            del1_ck.Size = new Size(209, 26);
            del1_ck.TabIndex = 4;
            del1_ck.Text = "Șterge o singură carte";
            del1_ck.UseVisualStyleBackColor = true;
            del1_ck.CheckedChanged += del1_ck_CheckedChanged;
            // 
            // metoda_lbl
            // 
            metoda_lbl.Anchor = AnchorStyles.None;
            metoda_lbl.AutoSize = true;
            metoda_lbl.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            metoda_lbl.ForeColor = Color.White;
            metoda_lbl.Location = new Point(290, 148);
            metoda_lbl.Name = "metoda_lbl";
            metoda_lbl.Size = new Size(224, 29);
            metoda_lbl.TabIndex = 3;
            metoda_lbl.Text = "Metoda de ștergere";
            // 
            // delmore_ck
            // 
            delmore_ck.Anchor = AnchorStyles.None;
            delmore_ck.AutoSize = true;
            delmore_ck.Font = new Font("Microsoft Sans Serif", 10.8F);
            delmore_ck.ForeColor = Color.White;
            delmore_ck.Location = new Point(290, 232);
            delmore_ck.Name = "delmore_ck";
            delmore_ck.Size = new Size(255, 26);
            delmore_ck.TabIndex = 4;
            delmore_ck.Text = "Șterge mai multe cărți odată";
            delmore_ck.UseVisualStyleBackColor = true;
            delmore_ck.CheckedChanged += delmore_ck_CheckedChanged;
            // 
            // queryOutput_lbl
            // 
            queryOutput_lbl.AutoSize = true;
            queryOutput_lbl.Dock = DockStyle.Bottom;
            queryOutput_lbl.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            queryOutput_lbl.ForeColor = Color.White;
            queryOutput_lbl.Location = new Point(0, 5);
            queryOutput_lbl.Name = "queryOutput_lbl";
            queryOutput_lbl.Size = new Size(0, 29);
            queryOutput_lbl.TabIndex = 3;
            // 
            // multi_lbl
            // 
            multi_lbl.Anchor = AnchorStyles.None;
            multi_lbl.AutoSize = true;
            multi_lbl.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            multi_lbl.ForeColor = Color.White;
            multi_lbl.Location = new Point(264, 269);
            multi_lbl.Name = "multi_lbl";
            multi_lbl.Size = new Size(281, 29);
            multi_lbl.TabIndex = 3;
            multi_lbl.Text = "Introdu intervalul ID-urilor";
            multi_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // range1_txt
            // 
            range1_txt.Anchor = AnchorStyles.None;
            range1_txt.BackColor = Color.FromArgb(54, 54, 54);
            range1_txt.BorderStyle = BorderStyle.FixedSingle;
            range1_txt.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            range1_txt.ForeColor = Color.White;
            range1_txt.Location = new Point(250, 352);
            range1_txt.Name = "range1_txt";
            range1_txt.Size = new Size(307, 28);
            range1_txt.TabIndex = 0;
            // 
            // range2_txt
            // 
            range2_txt.Anchor = AnchorStyles.None;
            range2_txt.BackColor = Color.FromArgb(54, 54, 54);
            range2_txt.BorderStyle = BorderStyle.FixedSingle;
            range2_txt.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            range2_txt.ForeColor = Color.White;
            range2_txt.Location = new Point(250, 386);
            range2_txt.Name = "range2_txt";
            range2_txt.Size = new Size(307, 28);
            range2_txt.TabIndex = 0;
            // 
            // range_lbl
            // 
            range_lbl.Anchor = AnchorStyles.None;
            range_lbl.AutoSize = true;
            range_lbl.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            range_lbl.ForeColor = Color.White;
            range_lbl.Location = new Point(290, 298);
            range_lbl.Name = "range_lbl";
            range_lbl.Size = new Size(214, 29);
            range_lbl.TabIndex = 3;
            range_lbl.Text = "(de ex. 100 și 200 )";
            range_lbl.TextAlign = ContentAlignment.MiddleCenter;
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
            save_btn.Location = new Point(404, 433);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(153, 66);
            save_btn.TabIndex = 2;
            save_btn.Text = "Salvează";
            save_btn.TextAlign = ContentAlignment.MiddleLeft;
            save_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += save_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 54, 54);
            panel1.Controls.Add(queryOutput_lbl);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 550);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 34);
            panel1.TabIndex = 5;
            // 
            // DeleteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 584);
            Controls.Add(panel1);
            Controls.Add(delmore_ck);
            Controls.Add(del1_ck);
            Controls.Add(metoda_lbl);
            Controls.Add(multi_lbl);
            Controls.Add(range_lbl);
            Controls.Add(single_lbl);
            Controls.Add(save_btn);
            Controls.Add(delete_btn);
            Controls.Add(range1_txt);
            Controls.Add(range2_txt);
            Controls.Add(id_carte_txt);
            Name = "DeleteForm";
            Text = "DeleteForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox id_carte_txt;
        private FontAwesome.Sharp.IconButton delete_btn;
        private Label single_lbl;
        private CheckBox del1_ck;
        private Label metoda_lbl;
        private CheckBox delmore_ck;
        private Label queryOutput_lbl;
        private Label multi_lbl;
        private TextBox range1_txt;
        private TextBox range2_txt;
        private Label range_lbl;
        private FontAwesome.Sharp.IconButton save_btn;
        private Panel panel1;
    }
}