using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace czarnaRobota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string[] col = { "INF.02", "INF.03" };
            if (inf.Checked)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(col);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string[] col = { "INF.03", "INF.04" };
            if (prog.Checked)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(col);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
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
    }
}
