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

            //couleur de police du remboursement
            InitializeComponent();
            label9.ForeColor = Color.Red;
            label7.ForeColor = Color.Red;
            label12.ForeColor = Color.Red;


            //contenu du listbox1
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
            label9.Text = "";
            if (radioButton1.Checked)
            {

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = "";
            if (radioButton2.Checked)
            {

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = "";
            if (radioButton3.Checked)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label9.Text = "";
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
            label9.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Text = "";
            if ((textBox2.Text == "") | (label11.Text == "Erreur"))
            {
                MessageBox.Show("Erreur de saisie du capital");
            }
            else
            {



                //variables
                double k;
                double n = 0;
                double t7 = 0.07;
                double t8 = 0.08;
                double t9 = 0.09;
                double MontantRemboursement = 0;

                //saisie utilisateur
                k = Convert.ToDouble(textBox2.Text);

                //calcul du montant du remboursement
                if (listBox1.SelectedItem == "Mensuelle")
                {
                    n = Convert.ToUInt32(label7.Text);

                    if (radioButton1.Checked == true)
                    {
                        MontantRemboursement = (k * (t7 / 12)) / (1 - (Math.Pow((1 + t7 / 12), (-n))));
                    }
                    if (radioButton2.Checked == true)
                    {
                        MontantRemboursement = (k * (t8 / 12)) / (1 - (Math.Pow((1 + t8 / 12), (-n))));
                    }

                    if (radioButton3.Checked == true)
                    {
                        MontantRemboursement = (k * (t9 / 12)) / (1 - (Math.Pow((1 + t9 / 12), (-n))));
                    }


                }
                if (listBox1.SelectedItem == "Bimestrielle")
                {
                    
                    n = Convert.ToUInt32(label7.Text);

                    if (radioButton1.Checked == true)
                    {
                        MontantRemboursement = (k * (t7 / 6)) / (1 - (Math.Pow((1 + t7 / 6), (-n))));
                    }

                    if (radioButton2.Checked == true)
                    {
                        MontantRemboursement = (k * (t8 / 6)) / (1 - (Math.Pow((1 + t8 / 6), (-n))));
                    }

                    if (radioButton3.Checked == true)
                    {
                        MontantRemboursement = (k * (t9 / 6)) / (1 - (Math.Pow((1 + t9 / 6), (-n))));
                    }
                }

                if (listBox1.SelectedItem == "Trimestrielle")
                {
                    
                    n = Convert.ToUInt32(label7.Text);

                    if (radioButton1.Checked == true)
                    {
                        MontantRemboursement = (k * (t9 / 4)) / (1 - (Math.Pow((1 + t9 / 4), (-n))));
                    }

                    if (radioButton2.Checked == true)
                    {
                        MontantRemboursement = (k * (t8 / 4)) / (1 - (Math.Pow((1 + t8 / 4), (-n))));
                    }

                    if (radioButton3.Checked == true)
                    {
                        MontantRemboursement = (k * (t9 / 4)) / (1 - (Math.Pow((1 + t9 / 4), (-n))));
                    }
                }

                if (listBox1.SelectedItem == "Semestrielle")
                {
                    n = Convert.ToUInt32(label7.Text);

                    if (radioButton1.Checked == true)
                    {
                        MontantRemboursement = (k * (t7 / 2)) / (1 - (Math.Pow((1 + t7 / 2), (-n))));
                    }
                    if (radioButton2.Checked == true)
                    {
                        MontantRemboursement = (k * (t8 / 2)) / (1 - (Math.Pow((1 + t8 / 2), (-n))));
                    }

                    if (radioButton3.Checked == true)
                    {
                        MontantRemboursement = (k * (t9 / 2)) / (1 - (Math.Pow((1 + t9 / 2), (-n))));
                    }

                }
                if (listBox1.SelectedItem == "Annuelle")
                {
                    n = Convert.ToUInt32(label7.Text);

                    if (radioButton1.Checked == true)
                    {
                        MontantRemboursement = (k * (t7)) / (1 - (Math.Pow((1 + t7), (-n))));
                    }

                    if (radioButton2.Checked == true)
                    {
                        MontantRemboursement = (k * (t8)) / (1 - (Math.Pow((1 + t8), (-n))));
                    }

                    if (radioButton3.Checked == true)
                    {
                        MontantRemboursement = (k * (t9)) / (1 - (Math.Pow((1 + t9), (-n))));
                    }

                }
                //affichage du montant des remboursements
                label9.Text = MontantRemboursement.ToString();
            }
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
            label9.Text = "";
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
            label9.Text = "";
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            label9.Text = "";

            //seulement 2 chiffres apres la virgule
            Regex ReMontant = new Regex(@"^[0-9]{1,10}(,)[0-9]{2}$");





            //variable
            double n = 0;

            //affichage durée en mois de remboursement
            if (listBox1.SelectedItem == "Mensuelle")
            {

                n = hScrollBar1.Value;
                hScrollBar1.Value = (hScrollBar1.Value / 1) * 1;
                label5.Text = hScrollBar1.Value.ToString();
                label5.Visible = true;
                hScrollBar1.LargeChange = 10;
                hScrollBar1.SmallChange = 1;
                hScrollBar1.Minimum = 0;
                hScrollBar1.Maximum = 209;
            }

            if (listBox1.SelectedItem == "Bimestrielle")
            {
                n = hScrollBar1.Value / 2;
                hScrollBar1.Value = (hScrollBar1.Value / 2) * 2;
                label5.Text = hScrollBar1.Value.ToString();
                label5.Visible = true;
                hScrollBar1.LargeChange = 20;
                hScrollBar1.SmallChange = 2;
                hScrollBar1.Minimum = 0;
                hScrollBar1.Maximum = 219;
            }

            if (listBox1.SelectedItem == "Trimestrielle")
            {
                n = hScrollBar1.Value / 3;
                hScrollBar1.Value = (hScrollBar1.Value / 3) * 3;
                label5.Text = hScrollBar1.Value.ToString();
                label5.Visible = true;
                hScrollBar1.LargeChange = 30;
                hScrollBar1.SmallChange = 3;
                hScrollBar1.Minimum = 0;
                hScrollBar1.Maximum = 229;
            }

            if (listBox1.SelectedItem == "Semestrielle")
            {
                n = hScrollBar1.Value / 6;
                hScrollBar1.Value = (hScrollBar1.Value / 6) * 6;
                label5.Text = hScrollBar1.Value.ToString();
                label5.Visible = true;
                hScrollBar1.LargeChange = 60;
                hScrollBar1.SmallChange = 6;
                hScrollBar1.Minimum = 0;
                hScrollBar1.Maximum = 259;
            }

            if (listBox1.SelectedItem == "Annuelle")
            {
                n = hScrollBar1.Value / 12;
                hScrollBar1.Value = (hScrollBar1.Value / 12) * 12;
                label5.Text = hScrollBar1.Value.ToString();
                label5.Visible = true;
                hScrollBar1.LargeChange = 120;
                hScrollBar1.SmallChange = 12;
                hScrollBar1.Minimum = 0;
                hScrollBar1.Maximum = 319;
            }

            //affichage du nombre de remboursements
            label7.Text = n.ToString();
        }
    }
}
