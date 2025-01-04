using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANEKDOT
{
    public partial class Form1 : Form
    {
        Timer timer;

        public Form1()
        {
            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += DoCoolThings;
            timer.Start();
            InitializeComponent();
        }

        private void DoCoolThings(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }

        string a = "Штирлиц стрелял вслепую. Слепая испугалась и побежала скачками, но качки быстро отстали.";
        string b = "Штирлиц всю ночь топил камин. На утро камин утонул.";
        string c = "Поймал как-то людоед американца, немца и русского... И съел всех! Голодный был очень, не до разговоров было...";
        string g = "Французы, прочитав русские сказки, с удивлением узнали, что лягушек можно не только есть, но еще и на них жениться.";
        string h= "— Чебурашка, слышь, чё говорю?— Гена, ну ты посмотри на меня, конечно слышу…";
        string j = "— Гена, угадай, что такое красное и вредно для твоих зубов?— Чебурашка, я думаю, что это варенье.— Нет Гена, это кирпич";
        string i = "1";  
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            myForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "anekdoti")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
 
            if (radioButton3.Checked && radioButton4.Checked)
            {
                label2.Text = j;
            }
            if (radioButton3.Checked && radioButton5.Checked)
            {
                label2.Text = h;
            }
            if (radioButton2.Checked && radioButton4.Checked)
            {
                label2.Text = c;
            }
            if (radioButton2.Checked && radioButton5.Checked)
            {
                label2.Text = g;
            }
            if (radioButton1.Checked && radioButton4.Checked)
            {
                label2.Text = a;
            }
            if (radioButton1.Checked && radioButton5.Checked)
            {
                label2.Text = b;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           
         listBox1.Items.Add(textBox2.Text);
           
            i = i + 0;
            label5.Text = i;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);

            i = i + 0;
            label5.Text = i;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (i== "1000000000000000000000000000000000000000000")
            {
                Form3 myForm = new Form3();
                myForm.Show();
            }
            else 
            {
                Form4 myForm = new Form4();
                myForm.Show();
            }

        }
    }   
}
