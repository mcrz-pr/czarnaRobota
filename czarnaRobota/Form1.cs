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
            string termin, nazw, imi, date, birthPlace, pesel, city, address, zipcode, post, phone, mail, time = "", examPart = "", examNumber, examName, jobNumber = "", jobName = "";
            termin = term.Text;
            nazw = nazwisko.Text;
            imi = imie.Text;
            date = textBox_date.Text;
            birthPlace = textBox_birthPlace.Text;
            pesel = textbox_pesel.Text;
            city = textBox_city.Text;
            address = textBox_address.Text;
            zipcode = textBox_zipcode.Text;
            post = textBox_post.Text;
            phone = textBox_phone.Text;
            mail = textBox_mail.Text;
            if (radio_firstTime.Checked)
            {
                time = radio_firstTime.Text;
                examPart = "do części " + checkbox_teor.Text + ", " + checkbox_prak.Text;
            }
            else if (radio_secondTime.Checked)
            {
                time = radio_secondTime.Text;
                if (checkbox_teor.Checked && checkbox_prak.Checked)
                {
                    examPart = checkbox_teor.Text + ", " + checkbox_prak.Text;
                }
                else if (checkbox_prak.Checked)
                {
                    examPart = checkbox_prak.Text;
                }
                else if (checkbox_teor.Checked)
                {
                    examPart = checkbox_teor.Text;
                }
            }
            examNumber = test_number.Text;
            examName = test_title_label.Text;
            if (radio_inf.Checked)
            {
                jobName = radio_inf.Text;
                jobNumber = "351203";
            }
            else if (radio_prog.Checked)
            {
                jobName = radio_prog.Text;
                jobNumber = "351406";
            }

            string text = $"Deklaruję przystąpienie do egzaminu potwierdzającego kwalifikacje w zawodzie przeprowadzanego w terminie {termin}\n\nDane osobowe ucznia\n   Nazwisko:\t\t   {surname}\n   Imię (Imiona):\t\t   {name}\n   Data i miejsce urodzenia:\t   {date}, {birthPlace}\n   Numer PESEL:\t\t   {pesel}\n\nAdres korenspondencyjny\n   miejscowość:\t\t   {city}\n   ulica i numer domu:\t   {address}\n   kod pocztowy i poczta:\t   {zipcode}, {post}\n   nr telefonu z kierunkowym:\t   {phone}\n   mail:\t\t\t   {mail}\n\n\nDeklaruję przystapienie do egzaminu {time} {examPart}\n\nOznaczenie kwalifikacji zgodne z podstawą programową {examNumber}.\nNazwa kwalifikacji: {examName}.\n\nSymbol cyfrowy zawodu: {jobNumber}\nNazwa zawodu: {jobName}";

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
