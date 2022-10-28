using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P6_4_1214085
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbNama_Leave(object sender, EventArgs e)
        {
            if (tbNama.Text == "")
            {
                epWarning.SetError(tbNama, "Textbox Nama tidak boleh kosong!");
                epWrong.SetError(tbNama, "");
                epCorrect.SetError(tbNama, "");
            }
            else
            {

                if ((tbNama.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(tbNama, "");
                    epWrong.SetError(tbNama, "");
                    epCorrect.SetError(tbNama, "Betul!");
                }
                else
                {
                    epWrong.SetError(tbNama, "Inputan Hanya Boleh Huruf!");
                    epWarning.SetError(tbNama, "");
                    epCorrect.SetError(tbNama, "");
                }
            }
        }

        private void tbNPM_Leave(object sender, EventArgs e)
        {
            if (tbNPM.Text == "")
            {
                epWarning.SetError(tbNPM, "Textbox NPM tidak boleh kosong!");
                epWrong.SetError(tbNPM, "");
                epCorrect.SetError(tbNPM, "");
            }
            else
            {
                if ((tbNPM.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(tbNPM, "Betul!");
                    epWarning.SetError(tbNPM, "");
                    epWrong.SetError(tbNPM, "");
                }
                else
                {
                    epCorrect.SetError(tbNPM, "");
                    epWarning.SetError(tbNPM, "");
                    epWrong.SetError(tbNPM, "Inputan Hanya Boleh Angka!");
                }
            }
        }

        private void tbAgama_Leave(object sender, EventArgs e)
        {
            if (tbAgama.Text == "")
            {
                epWarning.SetError(tbAgama, "Textbox Agama tidak boleh kosong!");
                epWrong.SetError(tbAgama, "");
                epCorrect.SetError(tbAgama, "");
            }
            else
            {
                if ((tbAgama.Text).All(Char.IsUpper))
                {
                    epCorrect.SetError(tbAgama, "Betul!");
                    epWarning.SetError(tbAgama, "");
                    epWrong.SetError(tbAgama, "");
                }
                else
                {
                    epCorrect.SetError(tbAgama, "");
                    epWarning.SetError(tbAgama, "");
                    epWrong.SetError(tbAgama, "Inputan Hanya Boleh Huruf Kecil!");
                }
            }
        }

        private void tbHobi_Leave(object sender, EventArgs e)
        {
            if (tbHobi.Text == "")
            {
                epWarning.SetError(tbHobi, "Textbox Hobi tidak boleh kosong!");
                epWrong.SetError(tbHobi, "");
                epCorrect.SetError(tbHobi, "");
            }
            else
            {
                if ((tbHobi.Text).All(Char.IsLower))
                {
                    epCorrect.SetError(tbHobi, "Betul!");
                    epWarning.SetError(tbHobi, "");
                    epWrong.SetError(tbHobi, "");
                }
                else
                {
                    epCorrect.SetError(tbHobi, "");
                    epWarning.SetError(tbHobi, "");
                    epWrong.SetError(tbHobi, "Inputan Hanya Boleh Huruf Kecil!");
                }
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                epWarning.SetError(tbEmail, "Textbox Email tidak boleh kosong!");
                epWrong.SetError(tbEmail, "");
                epCorrect.SetError(tbEmail, "");
            }
            else
            {
                if (Regex.IsMatch(tbEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(tbEmail, "");
                    epWrong.SetError(tbEmail, "");
                    epCorrect.SetError(tbEmail, "Betul!");
                }
                else
                {
                    epWrong.SetError(tbEmail, "Format email salah!\nContoh : a@b.c");
                    epWarning.SetError(tbEmail, "");
                    epCorrect.SetError(tbEmail, "");
                }
            }
        }

        private void tbUmur_Leave(object sender, EventArgs e)
        {
            if (tbUmur.Text == "")
            {
                epWarning.SetError(tbUmur, "Textbox Umur tidak boleh kosong!");
                epWrong.SetError(tbUmur, "");
                epCorrect.SetError(tbUmur, "");
            }
            else
            {
                if (tbUmur.Text.Length > 2)
                {
                    epCorrect.SetError(tbUmur, "");
                    epWarning.SetError(tbUmur, "");
                    epWrong.SetError(tbUmur, "Inputan Tidak Boleh Lebih Dari Dua!");
                }
                else if (tbUmur.Text.Length <= 2)
                {
                    epCorrect.SetError(tbUmur, "Betul");
                    epWarning.SetError(tbUmur, "");
                    epWrong.SetError(tbNPM, "");
                }
            }
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            if (txtAngka1.Text == "")
            {
                epWarning.SetError(txtAngka1, "Text Box tidak boleh kosong!");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");
            }
            else
            {
                if ((txtAngka1.Text).All(Char.IsNumber))
                {
                    epWarning.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka1, "Betul!");
                }
                else
                {
                    epWarning.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka1, "Inputan hanya boleh angka!");
                    epCorrect.SetError(txtAngka1, "");
                }
            }
            if (txtAngka2.Text == "")
            {
                epWarning.SetError(txtAngka2, "Text Box tidak boleh kosong!");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");
            }
        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            int Angka1 = int.Parse(txtAngka1.Text);
            int Angka2 = int.Parse(txtAngka2.Text);
            if (txtAngka2.Text == "")
            {
                string input = String.Empty;
                epWarning.SetError(txtAngka2, "Text Box tidak boleh kosong!");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");
            }
            else
            {
                if ((txtAngka2.Text).All(Char.IsNumber))
                {
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "Betul!");
                }
                else
                {
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka2, "Inputan hanya boleh angka!");
                    epCorrect.SetError(txtAngka2, "");
                }
            }
            if (Angka1 > Angka2)
            {
                epWarning.SetError(txtAngka1, "");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "Benar");

                epWarning.SetError(txtAngka2, "");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "Benar");
            }
            else
            {
                epWarning.SetError(txtAngka1, "Salah");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");

                epWarning.SetError(txtAngka2, "Salah");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");
            }
        }

        private void btTampilkan_Click(object sender, EventArgs e)
        {
            int Angka1 = int.Parse(txtAngka1.Text);
            int Angka2 = int.Parse(txtAngka2.Text);

            if (Regex.IsMatch(tbEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                
            } else
            {
                MessageBox.Show("Masukkan email anda dengan benar", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Pemisah
            if (tbNama.Text == "")
            {
                MessageBox.Show("Harus memasukkan nama anda", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((tbNama.Text).All(Char.IsNumber))
            {
                MessageBox.Show("Masukkan Nama Anda dengan benar", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbNPM.Text == "")
            {
                MessageBox.Show("Harus memasukkan NPM anda", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((tbNPM.Text).All(Char.IsLetter))
            {
                MessageBox.Show("Masukkan NPM Anda dengan benar", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbAgama.Text == "")
            {
                MessageBox.Show("Harus memasukkan Agama anda", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((tbAgama.Text).All(Char.IsLower))
            {
                MessageBox.Show("Masukkan Agamma Anda dengan benar", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbHobi.Text == "")
            {
                MessageBox.Show("Harus memasukkan Hobi anda", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((tbHobi.Text).All(Char.IsUpper))
            {
                MessageBox.Show("Masukkan Hobi Anda dengan benar", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbEmail.Text == "")
            {
                MessageBox.Show("Harus memasukkan Email anda", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbUmur.Text == "")
            {
                MessageBox.Show("Harus memasukkan Umur anda", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbUmur.Text.Length > 2)
            {
                MessageBox.Show("Masukkan Umur Anda dengan benar", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtAngka1.Text == "")
            {
                MessageBox.Show("Harus memasukkan Angka1 anda", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Angka1 < Angka2)
            {
                MessageBox.Show("Angka 1 yang anda masukkan lebih kecil daripada Angka 2", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            else
            {
                MessageBox.Show
                ("Nama\t\t: " + tbNama.Text +
                "\nNPM\t\t: " + tbUmur.Text +
                "\nAgama\t\t: " + tbAgama.Text +
                "\nHobi\t\t: " + tbHobi.Text +
                "\nEmail\t\t: " + tbEmail.Text +
                "\nUmur\t\t: " + tbUmur.Text +
                "\nPerbandingan\t: Angka " + txtAngka1.Text + " lebih besar daripada " + txtAngka2.Text,
                "Informasi Pendaftaran",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
