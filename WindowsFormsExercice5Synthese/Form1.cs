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
            

            //couleur remboursement
            InitializeComponent();
            label9.ForeColor = Color.Red;
            label7.ForeColor = Color.Red;
            label12.ForeColor = Color.Red;

            
            //contenu listbox1
            string[] myList = new string[5];

            myList[0] = "Mensuelle";
            myList[1] = "Bimestrielle";
            myList[2] = "Trimestrielle";
            myList[3] = "Semestrielle";
            myList[4] = "Annuelle";

            listBox1.Items.AddRange(myList);

            //selection à l'ouverture de la page
            listBox1.SelectedItem = "Mensuelle";
            hScrollBar1.Value = 1;

            //saisie utilisateur
            

            

            


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


                Regex ReNom = new Regex(@"^[A-Z a-z-]+$");

                if (ReNom.IsMatch(textBox1.Text))
                {
                    textBox1.BackColor = Color.White;
                    label10.Visible = true;
                    label10.ForeColor = Color.Green;
                    label10.Text = "Ok";
                }
                else
                {
                    label10.Visible = false;
                }
               
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "") | (label11.Text == "Erreur"))
            {
                MessageBox.Show("Erreur de saisie du capital");
            }

            //variables
            double k;
            double n = 0;
            double t = 0;
            double t2 = 1 - t;

            //saisie utilisateur
            k = Convert.ToDouble(textBox2.Text);

            //calcul du capital
            double MontantRemboursement = (k * t) / (1 - Math.Pow(t2, (-n)));



        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label7.Text = "0";
            label9.Text = "0";
            label10.Visible = false;
            label11.Visible = false;
            listBox1.SelectedItem = "Mensuelle";
            hScrollBar1.Value = 1;
            radioButton1.Checked = true;
            textBox1.Focus();







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

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == "Mensuelle")
            {

                hScrollBar1.Value = (hScrollBar1.Value / 1) * 1;
                label5.Text = hScrollBar1.Value.ToString();
                label5.Visible = true;
                hScrollBar1.LargeChange = 10;
                hScrollBar1.Minimum = 0;
                hScrollBar1.Maximum = 209;
            }

            if (listBox1.SelectedItem == "Bimestrielle")
            {

                hScrollBar1.Value = (hScrollBar1.Value / 2) * 2;
                label5.Text = hScrollBar1.Value.ToString();
                label5.Visible = true;
                hScrollBar1.LargeChange = 20;
                hScrollBar1.Minimum = 0;
                hScrollBar1.Maximum = 219;
            }

            if (listBox1.SelectedItem == "Trimestrielle")
            {

                hScrollBar1.Value = (hScrollBar1.Value / 3) * 3;
                label5.Text = hScrollBar1.Value.ToString();
                label5.Visible = true;
                hScrollBar1.LargeChange = 30;
                hScrollBar1.Minimum = 0;
                hScrollBar1.Maximum = 229;
            }

            if (listBox1.SelectedItem == "Semestrielle")
            {

                hScrollBar1.Value = (hScrollBar1.Value / 6) * 6;
                label5.Text = hScrollBar1.Value.ToString();
                label5.Visible = true;
                hScrollBar1.LargeChange = 60;
                hScrollBar1.Minimum = 0;
                hScrollBar1.Maximum = 259;
            }

            if (listBox1.SelectedItem == "Annuelle")
            {

                hScrollBar1.Value = (hScrollBar1.Value / 12) * 12;
                label5.Text = hScrollBar1.Value.ToString();
                label5.Visible = true;
                hScrollBar1.LargeChange = 120;               
                hScrollBar1.Minimum = 0;
                hScrollBar1.Maximum = 319;
            }
        }
    }
}
