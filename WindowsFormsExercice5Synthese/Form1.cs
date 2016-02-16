using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsExercice5Synthese
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label9.ForeColor = Color.Red;
            label7.ForeColor = Color.Red;
            label12.ForeColor = Color.Red;


            string[] myList = new string[5];

            myList[0] = "Mensuelle";
            myList[1] = "Bimestrielle";
            myList[2] = "Trimestrielle";
            myList[3] = "Semestrielle";
            myList[4] = "Annuelle";

            listBox1.Items.AddRange(myList);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {


                Regex ReNom = new Regex(@"^[A-Z a-z]+$");

                if (ReNom.IsMatch(textBox1.Text))
                {
                    textBox1.BackColor = Color.White;
                    label10.Visible = true;
                    label10.ForeColor = Color.Green;
                    label10.Text = "Ok";
                }
                else
                {
                    textBox1.BackColor = Color.White;
                    label10.Visible = true;
                    label10.ForeColor = Color.Red;
                    label10.Text = "Erreur";
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Erreur\n \nEntrez le capital");
            }
            else
            {
                MessageBox.Show("Saisie validée");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label7.Text = "";
            label9.Text = "";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Regex ReCapitalEmprunte = new Regex(@"^[0-9]{1,10}$"); 

            if (ReCapitalEmprunte.IsMatch(textBox2.Text))
            {
                textBox2.BackColor = Color.White;
                label11.Visible = true;
                label11.ForeColor = Color.Green;
                label11.Text = "Ok";
            }
            else
            {
                textBox2.BackColor = Color.White;
                label11.Visible = true;
                label11.ForeColor = Color.Red;
                label11.Text = "Erreur";
            }

        }
    }
}
