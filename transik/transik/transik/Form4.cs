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
    public partial class Form4 : Form
    {
       public string sr = "";
        public Form4()
        {
            InitializeComponent();
            label9.Text = Program.budzet;
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sr = "";
            if (nar.Text.Length > 0)
            {
                sr += $" AND narodowosc like\"{nar.Text}%\"";

                
            }
            if (wod.Text.Length > 0)
                sr += $" AND wiek>{wod.Text}";
            if (wdo.Text.Length > 0)
                sr += $" AND wiek<{wdo.Text}";
            if (wartod.Text.Length > 0)
                sr += $" AND wartosc>{wartod.Text}";
            if (wardo.Text.Length > 0)
                sr += $" AND wartosc<{wardo.Text}";
            
            int z = 0;
            if (checkBox1.Checked)
            {
                z++;
                
                sr += $" AND ( pozycja=\"bramkarz\""; }
            if (checkBox2.Checked)
            { if(z>0)
                    sr += $" OR pozycja=\"obronca\"";
              else
                sr += $" AND ( pozycja=\"obronca\"";
              z++;
            }
            if (checkBox3.Checked)
            {
                if (z > 0)
                    sr += $" OR pozycja=\"pomocnik\"";
                else
                    sr += $" AND ( pozycja=\"pomocnik\"";
                z++;
            }
            if (checkBox4.Checked)
            {if(z>0)
                sr += $" OR pozycja=\"napastnik\"";
            else
                    sr += $" AND ( pozycja=\"napastnik\"";
                z++;
            }
            if(z>0)
             sr += ")";
            listView2.Items.Clear();

            Model model=new Model();
            model.STP6(sr);
            
            foreach (var o in model.Piłkarzet)
            {

                ListViewItem lv = new ListViewItem(o.Imię);
                lv.SubItems.Add(o.Nazwisko);
                lv.SubItems.Add(o.Wiek.ToString());
                lv.SubItems.Add(o.Wzrost.ToString());
                lv.SubItems.Add(o.Narodowość);
                lv.SubItems.Add(o.Pozycja);
                lv.SubItems.Add(o.Wartosc);
                lv.SubItems.Add(o.Zarobki);
                lv.SubItems.Add(o.Nazwaklubu);
                listView2.Items.Add(lv);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
