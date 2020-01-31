using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelviGultaslarProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtbxhouseAge.Visible = false;
            label16.Visible = false;
            chckbxIsNew.Visible = false;
            chckbxIsImarli.Visible = false;
            groupBox1.Visible = false;
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void scoreCalculateButton_Click(object sender, EventArgs e)
        {
            String name = txtbxName.Text;
            string surname = txtbxSurname.Text;
            int age = int.Parse(txtbxAge.Text);
            int income = int.Parse(txtbxIncome.Text);
            int workYear = int.Parse(txtbxWorkYear.Text);
            int expense = int.Parse(txtbxExpense.Text);

            
            int scoreAge = 0;
            int scoreIncome = 0;
            int scoreExpense = 0;
            int scoreWorkYear = 0;

            if (age >= 65)
                scoreAge += 100;
            else if (age >= 50)
                scoreAge += 180;
            else if (age >= 40)
                scoreAge += 160;
            else if (age >= 30)
                scoreAge += 140;
            else if (age >= 18)
                scoreAge += 120;
            else
                scoreAge = 0;


            if (income >= 25000)
                scoreIncome += 180;
            else if (income >= 20000)
                scoreIncome += 160;
            else if (income >= 15000)
                scoreIncome += 140;
            else if (income >= 10000)
                scoreIncome += 120;
            else if (income >= 5000)
                scoreIncome += 100;
            else
                scoreIncome = 0;


            if (expense >= 25000)
                scoreExpense += 100;
            else if (expense >= 20000)
                scoreExpense += 120;
            else if (expense >= 15000)
                scoreExpense += 140;
            else if (expense >= 10000)
                scoreExpense += 160;
            else if (expense >= 5000)
                scoreExpense += 180;
            else
                scoreExpense = 200;


            if (workYear >= 25)
                scoreWorkYear += 180;
            else if (workYear >= 20)
                scoreWorkYear += 160;
            else if (workYear >= 15)
                scoreWorkYear += 140;
            else if (workYear >= 10)
                scoreWorkYear += 120;
            else if (workYear >= 5)
                scoreWorkYear += 100;
            else
                scoreWorkYear = 0;

            double finalScoreTemp = (scoreAge * 0.1) + (scoreExpense * 0.4) + (scoreIncome * 0.4) + (scoreWorkYear * 0.1);
            int finalScore = int.Parse(finalScoreTemp.ToString());
            richTextBox1.Text = "Kredi Skorunuz : " + finalScore.ToString();
            scoreResultLabel.Text = finalScore.ToString();
            txtbxCreditScore.Text = finalScore.ToString();
        }

        private void nameChanged(object sender, EventArgs e)
        {
            if (TextBoxHasNumber(txtbxName.Text))
            {
                MessageBox.Show("Yalnızca metin girilmelidir !");
                txtbxName.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
           if(TextBoxHasNumber(txtbxSurname.Text))
            {
                MessageBox.Show("Yalnızca metin girilmelidir !");
                txtbxSurname.Text = "";
            }
        }

        public Boolean TextBoxHasNumber(string text)
        {
            bool flag = false;
            for (int i = 0; i < text.Length; i++)
            {
                string tempEntry = text.Substring(i, 1);
                switch (tempEntry)
                {
                    case "0":
                        flag = true;
                        break;
                    case "1":
                        flag = true;
                        break;
                    case "2":
                        flag = true;
                        break;
                    case "3":
                        flag = true;
                        break;
                    case "4":
                        flag = true;
                        break;
                    case "5":
                        flag = true;
                        break;
                    case "6":
                        flag = true;
                        break;
                    case "7":
                        flag = true;
                        break;
                    case "8":
                        flag = true;
                        break;
                    case "9":
                        flag = true;
                        break;
                    default:
                        flag = false;
                        break;
                }
                if (flag == true)
                    break;
            }
            return flag;
        }

        public Boolean TextBoxHasNotLetter(string text)
        {
            bool flag = false;
            for (int i = 0; i < text.Length; i++)
            {
                string tempEntry = text.Substring(i, 1);
                switch (tempEntry)
                {
                    case "0":
                        flag = true;
                        break;
                    case "1":
                        flag = true;
                        break;
                    case "2":
                        flag = true;
                        break;
                    case "3":
                        flag = true;
                        break;
                    case "4":
                        flag = true;
                        break;
                    case "5":
                        flag = true;
                        break;
                    case "6":
                        flag = true;
                        break;
                    case "7":
                        flag = true;
                        break;
                    case "8":
                        flag = true;
                        break;
                    case "9":
                        flag = true;
                        break;
                    default:
                        flag = false;
                        break;
                }
                if (flag == false)
                    break;
            }
            return flag;
        }


        private void txtbxAge_Leave(object sender, EventArgs e)
        {
            if (!TextBoxHasNotLetter(txtbxAge.Text))
            {
                MessageBox.Show("Yalnızca Sayı girilmelidir !");
                txtbxAge.Text = "";
            }
        }

        private void txtbxIncome_Leave(object sender, EventArgs e)
        {
            if (!TextBoxHasNotLetter(txtbxIncome.Text))
            {
                MessageBox.Show("Yalnızca Sayı girilmelidir !");
                txtbxIncome.Text = "";
            }
        }

        private void txtbxWorkYear_Leave(object sender, EventArgs e)
        {
            if (!TextBoxHasNotLetter(txtbxWorkYear.Text))
            {
                MessageBox.Show("Yalnızca Sayı girilmelidir !");
                txtbxWorkYear.Text = "";
            }
        }

        private void txtbxExpense_Leave(object sender, EventArgs e)
        {
            if (!TextBoxHasNotLetter(txtbxExpense.Text))
            {
                MessageBox.Show("Yalnızca Sayı girilmelidir !");
                txtbxExpense.Text = "";
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secili = listBox1.Items[listBox1.SelectedIndex].ToString();
            if (secili == "Konut Kredisi")
            {
                txtbxhouseAge.Visible = true;
                label16.Visible = true;
                chckbxIsNew.Visible = true;
                chckbxIsImarli.Visible = false;
                groupBox1.Visible = false;
            }
                
            else if(secili == "Taşıt Kredisi")
            {
                txtbxhouseAge.Visible = false;
                label16.Visible = false;
                chckbxIsNew.Visible = true;
                chckbxIsImarli.Visible = false;
                groupBox1.Visible = false;
            }
            else if (secili == "Arsa Kredisi")
            {
                txtbxhouseAge.Visible = false;
                label16.Visible = false;
                chckbxIsNew.Visible = false;
                chckbxIsImarli.Visible = true;
                groupBox1.Visible = false;
            }
            else if (secili == "İhtiyaç Kredisi")
            {
                txtbxhouseAge.Visible = false;
                label16.Visible = false;
                chckbxIsNew.Visible = false;
                chckbxIsImarli.Visible = false;
                groupBox1.Visible = true;
            }
            else
            {
                txtbxhouseAge.Visible = false;
                label16.Visible = false;
                chckbxIsNew.Visible = false;
                chckbxIsImarli.Visible = false;
                groupBox1.Visible = false;
            }


        }

        private void chckbxIsNew_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbxIsNew.Checked)
                txtbxhouseAge.Enabled = false;
            else
                txtbxhouseAge.Enabled = true;
        }

        private void creditCalculate_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            if(txtbxCreditScore.Text=="" || txtbxCreditScore.Text == null)
            {
                MessageBox.Show("Lütfen kredi sokorunu hesaplayınız.");
                return;
            }
                

            string secili = listBox1.Items[listBox1.SelectedIndex].ToString();

            int maturity=int.Parse(txtbxMaturity.Text);
            int amount = int.Parse(txtbxAmount.Text);
            int score = int.Parse(scoreResultLabel.Text);


            if (secili == "Konut Kredisi")
            {
                Konut konutProject = new Konut();
                konutProject.Maturity = maturity;
                konutProject.Amount = amount;
                konutProject.Score = score;
                konutProject.HouseAge = 0;
                konutProject.InterestRate = 0.99;
                if (chckbxIsNew.Checked)
                    konutProject.IsNew = true;
                else
                    konutProject.HouseAge = int.Parse(txtbxhouseAge.Text);
                dataGridView1.DataSource = konutProject.CreatePaymentTable();
            }

            else if (secili == "Taşıt Kredisi")
            {
                Arac aracProject = new Arac();
                aracProject.Maturity = maturity;
                aracProject.Amount = amount;
                aracProject.Score = score;
                aracProject.IsNew = false;
                aracProject.InterestRate = 1.10;
                if (chckbxIsNew.Checked)
                    aracProject.IsNew = true;
                dataGridView1.DataSource = aracProject.CreatePaymentTable();
            }
            else if (secili == "Arsa Kredisi")
            {
                Arsa arsaProject = new Arsa();
                arsaProject.Maturity = maturity;
                arsaProject.Amount = amount;
                arsaProject.Score = score;
                arsaProject.IsImarli = false;
                arsaProject.InterestRate = 1.20;
                if (chckbxIsImarli.Checked)
                    arsaProject.IsImarli = true;
                dataGridView1.DataSource = arsaProject.CreatePaymentTable();

            }
            else if (secili == "İhtiyaç Kredisi")
            {
                Ihtiyac ihtiyacProject = new Ihtiyac();
                ihtiyacProject.Maturity = maturity;
                ihtiyacProject.Amount = amount;
                ihtiyacProject.Score = score;
                ihtiyacProject.IsBireysel = false;
                ihtiyacProject.InterestRate = 1.45;
                if (rdbtnBireysel.Checked)
                    ihtiyacProject.IsBireysel = true;
                if (rdbtnKurumsal.Checked)
                    ihtiyacProject.IsBireysel = false;
                dataGridView1.DataSource=ihtiyacProject.CreatePaymentTable();
            }            
        }
    }
}
