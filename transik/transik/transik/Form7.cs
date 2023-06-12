using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace transik
{
    using encje;

    public partial class Form7 : Form
    {
       
        public Form7()
        {
            InitializeComponent();

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            label12.Text = Program.nazwaklubu;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool czy = true;
            if (textBox1.TextLength < 0)
                czy = false;
            if (textBox2.TextLength < 0)
                czy = false;
            if (textBox3.TextLength < 0)
                czy = false;
            if (textBox4.TextLength < 0)
                czy = false;
            if (textBox5.TextLength < 0)
                czy = false;
            if (textBox6.TextLength < 0)
                czy = false;
            if (textBox7.TextLength < 0)
                czy = false;
            if (textBox8.TextLength < 0)
                czy = false;
            if (comboBox1.SelectedIndex==-1)
                czy = false;
            if(czy)
            {
                try
                {
                    int a = int.Parse(textBox3.Text), b = int.Parse(textBox4.Text);
                    int.Parse(textBox5.Text);
                    int.Parse(textBox6.Text);
                }
                catch {
                    MessageBox.Show("nieprawidłowo uzupełniony formularz ");
                    
                }   
                Piłkarz pilkarz = new Piłkarz(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), int.Parse(textBox4.Text), textBox5.Text,comboBox1.Text, textBox6.Text, textBox7.Text); 
            
            
            
            
            }
            else
            { MessageBox.Show("nie uzupełniłeś wszystkich pól"); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
