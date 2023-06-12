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
    public partial class Form5 : Form
    {

        public static Form5 instance;
        string sr = "";
        public Form5()
        {   
            InitializeComponent();
        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            sr = "";
            if (textBox1.Text.Length > 0)
            {
                sr += $" AND narodowosc like\"{textBox1.Text}%\"";


            }
            if (textBox2.Text.Length > 0)
                sr += $" AND wiek>{textBox2.Text}";
            if (textBox3.Text.Length > 0)
                sr += $" AND wiek<{textBox3.Text}";
            if (textBox4.Text.Length > 0)
                sr += $" AND dlugosc>{textBox4.Text}";
            if (textBox5.Text.Length > 0)
                sr += $" AND dlugosc<{textBox5.Text}";
            if (textBox4.Text.Length > 0)
                sr += $" AND zarobki>{textBox6.Text}";
            if (textBox5.Text.Length > 0)
                sr += $" AND zarobki<{textBox7.Text}";

            listView3.Items.Clear();

            Model model = new Model(sr);
            model.STP(sr);
            foreach (var o in model.Menadżert)
            {

                ListViewItem lv = new ListViewItem(o.Imię);
                lv.SubItems.Add(o.Nazwisko);
                lv.SubItems.Add(o.Wiek.ToString());
          
                lv.SubItems.Add(o.Narodowość);
                
        
                lv.SubItems.Add(o.Zarobki);
                lv.SubItems.Add(o.Nazwaklubu);
                lv.SubItems.Add(o.Długośćk);
                listView3.Items.Add(lv);
            }
        }

        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
