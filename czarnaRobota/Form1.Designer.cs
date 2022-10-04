namespace czarnaRobota
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedPesel = new System.Windows.Forms.MaskedTextBox();
            this.data = new System.Windows.Forms.MaskedTextBox();
            this.miejsceUr = new System.Windows.Forms.TextBox();
            this.imie = new System.Windows.Forms.TextBox();
            this.nazwisko = new System.Windows.Forms.TextBox();
            this.pesel = new System.Windows.Forms.Label();
            this.datIMUr = new System.Windows.Forms.Label();
            this.imi = new System.Windows.Forms.Label();
            this.nazw = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedNrTel = new System.Windows.Forms.MaskedTextBox();
            this.maskedKodP = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.poczta = new System.Windows.Forms.TextBox();
            this.ulINrD = new System.Windows.Forms.TextBox();
            this.miejscow = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.term = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.prog = new System.Windows.Forms.RadioButton();
            this.inf = new System.Windows.Forms.RadioButton();
            this.egz = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kol = new System.Windows.Forms.RadioButton();
            this.pierw = new System.Windows.Forms.RadioButton();
            this.pis = new System.Windows.Forms.CheckBox();
            this.prak = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEKLARACJA PRZYSTĄPIENIA DO EGZAMINU";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedPesel);
            this.groupBox1.Controls.Add(this.data);
            this.groupBox1.Controls.Add(this.miejsceUr);
            this.groupBox1.Controls.Add(this.imie);
            this.groupBox1.Controls.Add(this.nazwisko);
            this.groupBox1.Controls.Add(this.pesel);
            this.groupBox1.Controls.Add(this.datIMUr);
            this.groupBox1.Controls.Add(this.imi);
            this.groupBox1.Controls.Add(this.nazw);
            this.groupBox1.Location = new System.Drawing.Point(48, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane osobowe ucznia";
            // 
            // maskedPesel
            // 
            this.maskedPesel.Location = new System.Drawing.Point(115, 93);
            this.maskedPesel.Mask = "00000000000";
            this.maskedPesel.Name = "maskedPesel";
            this.maskedPesel.Size = new System.Drawing.Size(302, 20);
            this.maskedPesel.TabIndex = 10;
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(160, 68);
            this.data.Mask = "00/00/0000";
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(86, 20);
            this.data.TabIndex = 9;
            // 
            // miejsceUr
            // 
            this.miejsceUr.Location = new System.Drawing.Point(252, 68);
            this.miejsceUr.Name = "miejsceUr";
            this.miejsceUr.Size = new System.Drawing.Size(165, 20);
            this.miejsceUr.TabIndex = 8;
            this.miejsceUr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameBL);
            // 
            // imie
            // 
            this.imie.Location = new System.Drawing.Point(108, 42);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(309, 20);
            this.imie.TabIndex = 5;
            this.imie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameBL);
            // 
            // nazwisko
            // 
            this.nazwisko.Location = new System.Drawing.Point(96, 17);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(321, 20);
            this.nazwisko.TabIndex = 4;
            this.nazwisko.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameBL);
            // 
            // pesel
            // 
            this.pesel.AutoSize = true;
            this.pesel.Location = new System.Drawing.Point(34, 96);
            this.pesel.Name = "pesel";
            this.pesel.Size = new System.Drawing.Size(78, 13);
            this.pesel.TabIndex = 3;
            this.pesel.Text = "Numer PESEL:";
            // 
            // datIMUr
            // 
            this.datIMUr.AutoSize = true;
            this.datIMUr.Location = new System.Drawing.Point(34, 72);
            this.datIMUr.Name = "datIMUr";
            this.datIMUr.Size = new System.Drawing.Size(125, 13);
            this.datIMUr.TabIndex = 2;
            this.datIMUr.Text = "Data i miejsce urodzenia:";
            // 
            // imi
            // 
            this.imi.AutoSize = true;
            this.imi.Location = new System.Drawing.Point(34, 45);
            this.imi.Name = "imi";
            this.imi.Size = new System.Drawing.Size(68, 13);
            this.imi.TabIndex = 1;
            this.imi.Text = "Imię (imiona):";
            // 
            // nazw
            // 
            this.nazw.AutoSize = true;
            this.nazw.Location = new System.Drawing.Point(34, 20);
            this.nazw.Name = "nazw";
            this.nazw.Size = new System.Drawing.Size(56, 13);
            this.nazw.TabIndex = 0;
            this.nazw.Text = "Nazwisko:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedNrTel);
            this.groupBox2.Controls.Add(this.maskedKodP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.mail);
            this.groupBox2.Controls.Add(this.poczta);
            this.groupBox2.Controls.Add(this.ulINrD);
            this.groupBox2.Controls.Add(this.miejscow);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(48, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 131);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adres korespondencyjny";
            // 
            // maskedNrTel
            // 
            this.maskedNrTel.Location = new System.Drawing.Point(199, 99);
            this.maskedNrTel.Mask = "+48 000 000 000";
            this.maskedNrTel.Name = "maskedNrTel";
            this.maskedNrTel.Size = new System.Drawing.Size(81, 20);
            this.maskedNrTel.TabIndex = 12;
            // 
            // maskedKodP
            // 
            this.maskedKodP.Location = new System.Drawing.Point(160, 71);
            this.maskedKodP.Mask = "00-000";
            this.maskedKodP.Name = "maskedKodP";
            this.maskedKodP.Size = new System.Drawing.Size(70, 20);
            this.maskedKodP.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mail:";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(314, 99);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(103, 20);
            this.mail.TabIndex = 9;
            // 
            // poczta
            // 
            this.poczta.Location = new System.Drawing.Point(236, 71);
            this.poczta.Name = "poczta";
            this.poczta.Size = new System.Drawing.Size(181, 20);
            this.poczta.TabIndex = 7;
            this.poczta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameBL);
            // 
            // ulINrD
            // 
            this.ulINrD.Location = new System.Drawing.Point(143, 43);
            this.ulINrD.Name = "ulINrD";
            this.ulINrD.Size = new System.Drawing.Size(274, 20);
            this.ulINrD.TabIndex = 5;
            this.ulINrD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameBL);
            // 
            // miejscow
            // 
            this.miejscow.Location = new System.Drawing.Point(115, 17);
            this.miejscow.Name = "miejscow";
            this.miejscow.Size = new System.Drawing.Size(302, 20);
            this.miejscow.TabIndex = 4;
            this.miejscow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameBL);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Numer telefonu z kierunkowym:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kod pocztowy i poczta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ulica i numer domu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Miejscowość:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(384, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Deklaruję przystąpienie do egzaminu potwierdzającego kwalifikacje w zawodzie ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "przeprowadzanego w terminie";
            // 
            // term
            // 
            this.term.FormattingEnabled = true;
            this.term.Items.AddRange(new object[] {
            "styczeń",
            "czerwiec"});
            this.term.Location = new System.Drawing.Point(273, 386);
            this.term.Name = "term";
            this.term.Size = new System.Drawing.Size(121, 21);
            this.term.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.prog);
            this.panel1.Controls.Add(this.inf);
            this.panel1.Location = new System.Drawing.Point(88, 431);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 23);
            this.panel1.TabIndex = 6;
            // 
            // prog
            // 
            this.prog.AutoSize = true;
            this.prog.Location = new System.Drawing.Point(233, 3);
            this.prog.Name = "prog";
            this.prog.Size = new System.Drawing.Size(117, 17);
            this.prog.TabIndex = 1;
            this.prog.TabStop = true;
            this.prog.Text = "technik programista";
            this.prog.UseVisualStyleBackColor = true;
            this.prog.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // inf
            // 
            this.inf.AutoSize = true;
            this.inf.Location = new System.Drawing.Point(21, 3);
            this.inf.Name = "inf";
            this.inf.Size = new System.Drawing.Size(111, 17);
            this.inf.TabIndex = 0;
            this.inf.TabStop = true;
            this.inf.Text = "technik informatyk";
            this.inf.UseVisualStyleBackColor = true;
            this.inf.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // egz
            // 
            this.egz.FormattingEnabled = true;
            this.egz.Location = new System.Drawing.Point(39, 472);
            this.egz.Name = "egz";
            this.egz.Size = new System.Drawing.Size(121, 21);
            this.egz.TabIndex = 7;
            this.egz.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.kol);
            this.panel2.Controls.Add(this.pierw);
            this.panel2.Location = new System.Drawing.Point(48, 511);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 23);
            this.panel2.TabIndex = 9;
            // 
            // kol
            // 
            this.kol.AutoSize = true;
            this.kol.Location = new System.Drawing.Point(149, 3);
            this.kol.Name = "kol";
            this.kol.Size = new System.Drawing.Size(138, 17);
            this.kol.TabIndex = 1;
            this.kol.TabStop = true;
            this.kol.Text = "po raz kolejny do części";
            this.kol.UseVisualStyleBackColor = true;
            // 
            // pierw
            // 
            this.pierw.AutoSize = true;
            this.pierw.Location = new System.Drawing.Point(3, 3);
            this.pierw.Name = "pierw";
            this.pierw.Size = new System.Drawing.Size(97, 17);
            this.pierw.TabIndex = 0;
            this.pierw.TabStop = true;
            this.pierw.Text = "po raz pierwszy";
            this.pierw.UseVisualStyleBackColor = true;
            // 
            // pis
            // 
            this.pis.AutoSize = true;
            this.pis.Location = new System.Drawing.Point(344, 514);
            this.pis.Name = "pis";
            this.pis.Size = new System.Drawing.Size(67, 17);
            this.pis.TabIndex = 10;
            this.pis.Text = "pisemnej";
            this.pis.UseVisualStyleBackColor = true;
            // 
            // prak
            // 
            this.prak.AutoSize = true;
            this.prak.Location = new System.Drawing.Point(417, 514);
            this.prak.Name = "prak";
            this.prak.Size = new System.Drawing.Size(80, 17);
            this.prak.TabIndex = 11;
            this.prak.Text = "praktycznej";
            this.prak.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Zatwierdź";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(535, 540);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Wyczyść";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(741, 540);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Zapisz";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(535, 31);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(367, 500);
            this.textBox3.TabIndex = 15;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 569);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prak);
            this.Controls.Add(this.pis);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.egz);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.term);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label pesel;
        private System.Windows.Forms.Label datIMUr;
        private System.Windows.Forms.Label imi;
        private System.Windows.Forms.Label nazw;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox miejsceUr;
        private System.Windows.Forms.TextBox imie;
        private System.Windows.Forms.TextBox nazwisko;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox poczta;
        private System.Windows.Forms.TextBox ulINrD;
        private System.Windows.Forms.TextBox miejscow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox term;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton prog;
        private System.Windows.Forms.RadioButton inf;
        private System.Windows.Forms.ComboBox egz;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox data;
        private System.Windows.Forms.MaskedTextBox maskedPesel;
        private System.Windows.Forms.MaskedTextBox maskedKodP;
        private System.Windows.Forms.MaskedTextBox maskedNrTel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton kol;
        private System.Windows.Forms.RadioButton pierw;
        private System.Windows.Forms.CheckBox pis;
        private System.Windows.Forms.CheckBox prak;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
    }
}

