using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace czarnaRobota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string create_text_with_data()
        {
            string termin, nazw, imi, dat, miejsceU, nrPesel, miejsco, ulNr, kodP, poczt, nrTel, mai, raz = "", czeEgz = "", nazwEgz, numEgz, nazwZaw = "", numerZaw = "";
            termin = term.Text;
            nazw = nazwisko.Text;
            imi = imie.Text;
            dat = data.Text;
            miejsceU = miejsceUr.Text;
            nrPesel = pesel.Text;
            miejsco = miejscow.Text;
            ulNr = ulINrD.Text;
            kodP = maskedKodP.Text;
            poczt = poczta.Text;
            nrTel = maskedNrTel.Text;
            mai = mail.Text;
            if (pierw.Checked)
            {
                raz = pierw.Text;
                czeEgz = "do części " + pis.Text + ", " + prak.Text;
            }
            else if (kol.Checked)
            {
                raz = kol.Text;
                if (pis.Checked && prak.Checked)
                {
                    czeEgz = pis.Text + ", " + prak.Text;
                }
                else if (prak.Checked)
                {
                    czeEgz = prak.Text;
                }
                else if (pis.Checked)
                {
                    czeEgz = pis.Text;
                }
            }
            numEgz = test_number.Text;
            nazwEgz = test_title_label.Text;
            if (radio_inf.Checked)
            {
                nazwZaw = radio_inf.Text;
                numerZaw = "351203";
            }
            else if (radio_prog.Checked)
            {
                nazwZaw = radio_prog.Text;
                numerZaw = "351406";
            }

            string text = $"Deklaruję przystąpienie do egzaminu potwierdzającego kwalifikacje w zawodzie przeprowadzanego w terminie {termin}\n\nDane osobowe ucznia\n   Nazwisko:\t\t   {surname}\n   Imię (Imiona):\t\t   {name}\n   Data i miejsce urodzenia:\t   {date}, {birthPlace}\n   Numer PESEL:\t\t   {pesel}\n\nAdres korenspondencyjny\n   miejscowość:\t\t   {city}\n   ulica i numer domu:\t   {address}\n   kod pocztowy i poczta:\t   {zipcode}, {post}\n   nr telefonu z kierunkowym:\t   {phone}\n   mail:\t\t\t   {mail}\n\n\nDeklaruję przystapienie do egzaminu {raz} {czeEgz}\n\nOznaczenie kwalifikacji zgodne z podstawą programową {numEgz}.\nNazwa kwalifikacji: {nazwEgz}.\n\nSymbol cyfrowy zawodu: {numerZaw}\nNazwa zawodu: {nazwZaw}";

            text = text.Replace("\n", Environment.NewLine);

            return text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string[] col = { "INF.02", "INF.03" };
            if (inf.Checked)
            {
                egz.Items.Clear();
                egz.Items.AddRange(col);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string[] col = { "INF.03", "INF.04" };
            if (prog.Checked)
            {
                egz.Items.Clear();
                egz.Items.AddRange(col);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (egz.Text)
            {
                case "INF.02":
                    label9.Text = "Administracja i eksploatacja systemów komputerowych, urządzeń\r\nperyferyjnych i lokalnych sieci komputerowych";
                    break;
                case "INF.03":
                    label9.Text = "Tworzenie i administrowanie stronami i aplikacjami internetowymi oraz\r\nbazami danych";
                    break;
                case "INF.04":
                    label9.Text = "Projektowanie, programowanie i testowanie aplikacji";
                    break;
            }
        }

        private void nameBL(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z')
                e.KeyChar -= (char)32;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
