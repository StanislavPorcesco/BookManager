using System.Windows.Forms;

namespace GestiuneCarti.Forms
{
    partial class InfoForm
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
            label1 = new Label();
            val_lbl = new Label();
            label2 = new Label();
            nr_carti_lbl = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panelBooks = new Panel();
            label27 = new Label();
            label21 = new Label();
            label15 = new Label();
            label32 = new Label();
            label6 = new Label();
            label31 = new Label();
            label26 = new Label();
            label30 = new Label();
            label24 = new Label();
            label29 = new Label();
            label28 = new Label();
            label25 = new Label();
            label23 = new Label();
            label22 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            vScrollBarBooks = new VScrollBar();
            vScrollBar1 = new VScrollBar();
            panelBooks.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 54, 54);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 1020);
            panel1.Name = "panel1";
            panel1.Size = new Size(1135, 35);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(69, 136);
            label1.Name = "label1";
            label1.Size = new Size(411, 31);
            label1.TabIndex = 1;
            label1.Text = "Informații pentru utilizarea aplicației";
            // 
            // val_lbl
            // 
            val_lbl.AutoSize = true;
            val_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            val_lbl.ForeColor = Color.White;
            val_lbl.Location = new Point(90, 97);
            val_lbl.Name = "val_lbl";
            val_lbl.Size = new Size(151, 25);
            val_lbl.TabIndex = 1;
            val_lbl.Text = "Valoarea totală: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(69, 21);
            label2.Name = "label2";
            label2.Size = new Size(302, 31);
            label2.TabIndex = 1;
            label2.Text = "Informații despre inventar:";
            // 
            // nr_carti_lbl
            // 
            nr_carti_lbl.AutoSize = true;
            nr_carti_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nr_carti_lbl.ForeColor = Color.White;
            nr_carti_lbl.Location = new Point(90, 62);
            nr_carti_lbl.Name = "nr_carti_lbl";
            nr_carti_lbl.Size = new Size(144, 25);
            nr_carti_lbl.TabIndex = 1;
            nr_carti_lbl.Text = "Număr de cărți:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(69, 176);
            label3.Name = "label3";
            label3.Size = new Size(409, 31);
            label3.TabIndex = 1;
            label3.Text = "1. Utilizarea formei de adăgare cărți: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(90, 232);
            label4.Name = "label4";
            label4.Size = new Size(266, 25);
            label4.TabIndex = 1;
            label4.Text = "ID-ul Cărții trebuie să fie unic.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(90, 207);
            label5.Name = "label5";
            label5.Size = new Size(766, 25);
            label5.TabIndex = 1;
            label5.Text = "Se introduc datele aferente fiecărei căsuță, însă respectând condițiile de formă a datelor.";
            // 
            // panelBooks
            // 
            panelBooks.Controls.Add(label5);
            panelBooks.Controls.Add(label2);
            panelBooks.Controls.Add(label1);
            panelBooks.Controls.Add(nr_carti_lbl);
            panelBooks.Controls.Add(label27);
            panelBooks.Controls.Add(label21);
            panelBooks.Controls.Add(label15);
            panelBooks.Controls.Add(label3);
            panelBooks.Controls.Add(val_lbl);
            panelBooks.Controls.Add(label32);
            panelBooks.Controls.Add(label6);
            panelBooks.Controls.Add(label31);
            panelBooks.Controls.Add(label26);
            panelBooks.Controls.Add(label30);
            panelBooks.Controls.Add(label24);
            panelBooks.Controls.Add(label29);
            panelBooks.Controls.Add(label28);
            panelBooks.Controls.Add(label25);
            panelBooks.Controls.Add(label23);
            panelBooks.Controls.Add(label22);
            panelBooks.Controls.Add(label20);
            panelBooks.Controls.Add(label19);
            panelBooks.Controls.Add(label18);
            panelBooks.Controls.Add(label17);
            panelBooks.Controls.Add(label16);
            panelBooks.Controls.Add(label14);
            panelBooks.Controls.Add(label13);
            panelBooks.Controls.Add(label12);
            panelBooks.Controls.Add(label11);
            panelBooks.Controls.Add(label10);
            panelBooks.Controls.Add(label9);
            panelBooks.Controls.Add(label8);
            panelBooks.Controls.Add(label7);
            panelBooks.Controls.Add(label4);
            panelBooks.Dock = DockStyle.Fill;
            panelBooks.Location = new Point(0, 0);
            panelBooks.Name = "panelBooks";
            panelBooks.Size = new Size(1135, 1020);
            panelBooks.TabIndex = 2;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.FlatStyle = FlatStyle.Flat;
            label27.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.ForeColor = Color.White;
            label27.Location = new Point(69, 837);
            label27.Name = "label27";
            label27.Size = new Size(443, 31);
            label27.TabIndex = 1;
            label27.Text = "4. Utilizarea formei de căutare a cărților.";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.FlatStyle = FlatStyle.Flat;
            label21.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.White;
            label21.Location = new Point(69, 637);
            label21.Name = "label21";
            label21.Size = new Size(480, 31);
            label21.TabIndex = 1;
            label21.Text = "3. Utilizarea formei de modificare a cărților.";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.FlatStyle = FlatStyle.Flat;
            label15.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(69, 463);
            label15.Name = "label15";
            label15.Size = new Size(454, 31);
            label15.TabIndex = 1;
            label15.Text = "2. Utilizarea formei de ștergere a cărților:";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.FlatStyle = FlatStyle.Flat;
            label32.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.ForeColor = Color.White;
            label32.Location = new Point(90, 970);
            label32.Name = "label32";
            label32.Size = new Size(824, 25);
            label32.TabIndex = 1;
            label32.Text = "Apasă butonului de salvare pentru ca cartea sa fie salvată în baza de date cu datele actualizate.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(90, 798);
            label6.Name = "label6";
            label6.Size = new Size(824, 25);
            label6.TabIndex = 1;
            label6.Text = "Apasă butonului de salvare pentru ca cartea sa fie salvată în baza de date cu datele actualizate.";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.FlatStyle = FlatStyle.Flat;
            label31.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.ForeColor = Color.White;
            label31.Location = new Point(90, 945);
            label31.Name = "label31";
            label31.Size = new Size(584, 25);
            label31.TabIndex = 1;
            label31.Text = "Apăsarea butonului de Modificare, aplică modificprile asupra cărții.";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.FlatStyle = FlatStyle.Flat;
            label26.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.White;
            label26.Location = new Point(90, 773);
            label26.Name = "label26";
            label26.Size = new Size(584, 25);
            label26.TabIndex = 1;
            label26.Text = "Apăsarea butonului de Modificare, aplică modificprile asupra cărții.";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.FlatStyle = FlatStyle.Flat;
            label30.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.ForeColor = Color.White;
            label30.Location = new Point(90, 895);
            label30.Name = "label30";
            label30.Size = new Size(801, 25);
            label30.TabIndex = 1;
            label30.Text = "După, în primul câmp se introduce ID-ul cărții țintă, adică cartea care doriți să fie modificată.";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.FlatStyle = FlatStyle.Flat;
            label24.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.White;
            label24.Location = new Point(90, 723);
            label24.Name = "label24";
            label24.Size = new Size(801, 25);
            label24.TabIndex = 1;
            label24.Text = "După, în primul câmp se introduce ID-ul cărții țintă, adică cartea care doriți să fie modificată.";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.FlatStyle = FlatStyle.Flat;
            label29.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label29.ForeColor = Color.White;
            label29.Location = new Point(90, 920);
            label29.Name = "label29";
            label29.Size = new Size(632, 25);
            label29.TabIndex = 1;
            label29.Text = "Iar în al doilea câmp se introducea valoarea nouă aferentă căsuței bifate.";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.FlatStyle = FlatStyle.Flat;
            label28.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.ForeColor = Color.White;
            label28.Location = new Point(90, 870);
            label28.Name = "label28";
            label28.Size = new Size(693, 25);
            label28.TabIndex = 1;
            label28.Text = "Mai întâi se bifează o căsuță, astfel alegeți ce anume modificați la cartea aleasă.";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.FlatStyle = FlatStyle.Flat;
            label25.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.ForeColor = Color.White;
            label25.Location = new Point(90, 748);
            label25.Name = "label25";
            label25.Size = new Size(632, 25);
            label25.TabIndex = 1;
            label25.Text = "Iar în al doilea câmp se introducea valoarea nouă aferentă căsuței bifate.";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.FlatStyle = FlatStyle.Flat;
            label23.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.White;
            label23.Location = new Point(90, 698);
            label23.Name = "label23";
            label23.Size = new Size(693, 25);
            label23.TabIndex = 1;
            label23.Text = "Mai întâi se bifează o căsuță, astfel alegeți ce anume modificați la cartea aleasă.";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.FlatStyle = FlatStyle.Flat;
            label22.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.White;
            label22.Location = new Point(90, 673);
            label22.Name = "label22";
            label22.Size = new Size(775, 25);
            label22.TabIndex = 1;
            label22.Text = "Cu ajutorul acestei forme puteți actualiza datele unei cărți existente mai puțin ID-ul cărții.";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.FlatStyle = FlatStyle.Flat;
            label20.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.White;
            label20.Location = new Point(90, 599);
            label20.Name = "label20";
            label20.Size = new Size(759, 25);
            label20.TabIndex = 1;
            label20.Text = "De exemplu 100 și 200, toate cărtile de la 100 pana la 200 inclusiv, urmează să fie șterse.";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.FlatStyle = FlatStyle.Flat;
            label19.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.White;
            label19.Location = new Point(90, 574);
            label19.Name = "label19";
            label19.Size = new Size(752, 25);
            label19.TabIndex = 1;
            label19.Text = "introduceți 2 ID-uri diferite, astfel toate cărțile cuprinse între cele 2 ID-uri vor fi șterse. ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.FlatStyle = FlatStyle.Flat;
            label18.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.White;
            label18.Location = new Point(90, 549);
            label18.Name = "label18";
            label18.Size = new Size(798, 25);
            label18.TabIndex = 1;
            label18.Text = "primiți posibilitatea de a șterge mai multe cărți simultan. Apar două câmpuri unde trebuie sa";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.FlatStyle = FlatStyle.Flat;
            label17.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(90, 524);
            label17.Name = "label17";
            label17.Size = new Size(806, 25);
            label17.TabIndex = 1;
            label17.Text = "se introduce ID-ul cărții ce urmează sa fie ștearsă. În momentul bifării celei de a doua căsuță, ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.FlatStyle = FlatStyle.Flat;
            label16.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(90, 499);
            label16.Name = "label16";
            label16.Size = new Size(793, 25);
            label16.TabIndex = 1;
            label16.Text = "Standart este bifată căsuța de ștergere a unei cărți, astfel în căsuța \"Introduceți ID-ul cărții\"";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.FlatStyle = FlatStyle.Flat;
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(90, 432);
            label14.Name = "label14";
            label14.Size = new Size(663, 25);
            label14.TabIndex = 1;
            label14.Text = "Lungimea limbei este de 2 caractere, adică se scrie sub forma RO, EN, DE etc.";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.FlatStyle = FlatStyle.Flat;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(90, 407);
            label13.Name = "label13";
            label13.Size = new Size(450, 25);
            label13.TabIndex = 1;
            label13.Text = "Numărul de exemplare trebuie să fie mai mare ca 0.";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(90, 382);
            label12.Name = "label12";
            label12.Size = new Size(355, 25);
            label12.TabIndex = 1;
            label12.Text = "Prețul cărții trebuie să fie mai mare ca 0.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(90, 357);
            label11.Name = "label11";
            label11.Size = new Size(338, 25);
            label11.TabIndex = 1;
            label11.Text = "ID-ul CZU trebuie să fie mai mare ca 0.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(90, 332);
            label10.Name = "label10";
            label10.Size = new Size(658, 25);
            label10.TabIndex = 1;
            label10.Text = "Anul publicarii trebuie să fie mai mare de cat 1440 si mai mic ca anul curent.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(90, 307);
            label9.Name = "label9";
            label9.Size = new Size(571, 25);
            label9.TabIndex = 1;
            label9.Text = "Lungimea locului publicării trebuie să fie mai mare de 2 caractere.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(90, 282);
            label8.Name = "label8";
            label8.Size = new Size(582, 25);
            label8.TabIndex = 1;
            label8.Text = "Lungimea numelui autorului trebuie să fie mai mare de 2 caractere.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(90, 257);
            label7.Name = "label7";
            label7.Size = new Size(486, 25);
            label7.TabIndex = 1;
            label7.Text = "Lungimea titlului trebuie să fie mai mare de 2 caractere.";
            // 
            // vScrollBarBooks
            // 
            vScrollBarBooks.Dock = DockStyle.Right;
            vScrollBarBooks.Location = new Point(1119, 0);
            vScrollBarBooks.Name = "vScrollBarBooks";
            vScrollBarBooks.Size = new Size(16, 1020);
            vScrollBarBooks.SmallChange = 2;
            vScrollBarBooks.TabIndex = 2;
            // 
            // vScrollBar1
            // 
            vScrollBar1.BackColor = Color.DarkGray;
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.Location = new Point(1121, 0);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(14, 912);
            vScrollBar1.TabIndex = 2;
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1135, 1055);
            Controls.Add(vScrollBarBooks);
            Controls.Add(panelBooks);
            Controls.Add(panel1);
            Name = "InfoForm";
            Text = "InfoForm";
            Load += InfoForm_Load;
            panelBooks.ResumeLayout(false);
            panelBooks.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label val_lbl;
        private Label label2;
        private Label nr_carti_lbl;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panelBooks;
        private VScrollBar vScrollBar1;
        private Label label8;
        private Label label7;
        private Label label10;
        private Label label9;
        private Label label15;
        private Label label16;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label21;
        private Label label22;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label27;
        private Label label32;
        private Label label6;
        private Label label31;
        private Label label26;
        private Label label30;
        private Label label24;
        private Label label29;
        private Label label28;
        private Label label25;
        private Label label23;
        private VScrollBar vScrollBarBooks;
    }
}