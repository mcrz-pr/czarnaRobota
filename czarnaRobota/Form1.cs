using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            nrPesel = maskedPesel.Text;
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
            numEgz = egz.Text;
            nazwEgz = label9.Text;
            if (inf.Checked)
            {
                nazwZaw = inf.Text;
                numerZaw = "351203";
            }
            else if (prog.Checked)
            {
                nazwZaw = prog.Text;
                numerZaw = "351406";
            }

            string text = $"Deklaruję przystąpienie do egzaminu potwierdzającego kwalifikacje w zawodzie przeprowadzanego w terminie {termin}\n\nDane osobowe ucznia\n   Nazwisko:\t\t   {nazw}\n   Imię (Imiona):\t\t   {imi}\n   Data i miejsce urodzenia:\t   {dat}, {miejsceU}\n   Numer PESEL:\t\t   {nrPesel}\n\nAdres korenspondencyjny\n   miejscowość:\t\t   {miejsco}\n   ulica i numer domu:\t   {ulNr}\n   kod pocztowy i poczta:\t   {kodP}, {poczt}\n   nr telefonu z kierunkowym:\t   {nrTel}\n   mail:\t\t\t   {mai}\n\n\nDeklaruję przystapienie do egzaminu {raz} {czeEgz}\n\nOznaczenie kwalifikacji zgodne z podstawą programową {numEgz}.\nNazwa kwalifikacji: {nazwEgz}.\n\nSymbol cyfrowy zawodu: {numerZaw}\nNazwa zawodu: {nazwZaw}";

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dupa(object sender, EventArgs e)
        {
            if (kol.Checked)
            {
                pis.Enabled = true;
                prak.Enabled = true;
            }
            else
            {
                pis.Enabled = false;
                prak.Enabled = false;
            }

        }

        private void clear_maskedtextbox(MaskedTextBox a)
        {
            a.Text = "";
            a.BackColor = Color.White;
        }

        private void clear_textbox(TextBox a)
        {
            a.Text = "";
            a.BackColor = Color.White;
        }

        private bool check_textbox_null(TextBox a)
        {
            if (a.Text.Length == 0)
            {
                a.BackColor = Color.Red;
                return true;
            }
            else
            {
                a.BackColor = Color.White;
                return false;
            }
        }

        private bool check_maskedtextbox_null(MaskedTextBox a)
        {
            if (a.Text.Length == 0 || a.Text == "  .  ." || a.Text == "  -" || a.Text == "+48         ")
            {
                a.BackColor = Color.Red;
                return true;
            }
            else
            {
                a.BackColor = Color.White;
                return false;
            }
        }


        private void zatwierdz_Click(object sender, EventArgs e)
        {
            int errors = 0;
            MaskedTextBox[] maskedTextBoxes =
            {
              maskedKodP,
              maskedNrTel,
              maskedPesel,
              data
            };

            TextBox[] textboxes =
            {
                ulINrD,
                imie,
                nazwisko,
                miejsceUr,
                miejscow,
                mail,
                poczta
            };
            // check if textboxes are empty
            for (int j = 0; j < maskedTextBoxes.Length; j++)
            {
                errors += Convert.ToInt32(check_maskedtextbox_null(maskedTextBoxes[j]));
            }

            for (int i = 0; i < textboxes.Length; i++)
            {
                errors += Convert.ToInt32(check_textbox_null(textboxes[i]));
            }

            if (errors == 0)
            {
                textBox3.Text = create_text_with_data();
            }
            else
            {
                MessageBox.Show("HALOOOOO");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MaskedTextBox[] maskedTextBoxes =
            {
              maskedKodP,
              maskedNrTel,
              maskedPesel,
              data
            };

            TextBox[] textboxes =
            {
                ulINrD,
                imie,
                nazwisko,
                miejsceUr,
                miejscow,
                mail,
                poczta
            };

            for (int j = 0; j < maskedTextBoxes.Length; j++)
            {
                clear_maskedtextbox(maskedTextBoxes[j]);
            }

            for (int i = 0; i < textboxes.Length; i++)
            {
                clear_textbox(textboxes[i]);
            }

            textBox3.Text = null;
        }

        private void maskedPesel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var zapisDialog = new SaveFileDialog())
            {

                zapisDialog.InitialDirectory = "c:\\";
                zapisDialog.Filter = "txt files (*.txt)|*.txt";
                zapisDialog.FilterIndex = 2;
                try
                {
                    if (zapisDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(zapisDialog.FileName, create_text_with_data());
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void clear(object sender, MouseEventArgs e)
        {
            if (sender.GetType() == typeof(MaskedTextBox))
            {
                MaskedTextBox x = (MaskedTextBox)sender;
                x.BackColor = Color.White;
            }
            else
            {
                TextBox x = (TextBox)sender;
                x.BackColor = Color.White;
            }

        }
    }
}
