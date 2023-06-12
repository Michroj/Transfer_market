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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label1.Text = Program.nazwaklubu;
            Budżet.Text = Program.budzet;
        }

        private void button1_Click(object sender, EventArgs e)
        {Form3 fr =new Form3();
            fr.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.ShowDialog();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 fr6 = new Form6();
            fr6.ShowDialog();
        }

        private void Nazwak_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 fr7 = new Form7();
            fr7.ShowDialog();   
        }
    }
}
