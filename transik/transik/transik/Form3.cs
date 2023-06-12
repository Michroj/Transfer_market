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
    using static Model;

    public partial class Form3 : Form
    {
       public static Form3 instance;
        public Form3()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Model model = new Model();
            model.STP5();
            foreach (var o in model.Piłkarze)
            {

                ListViewItem lv = new ListViewItem(o.Imię);
                lv.SubItems.Add(o.Nazwisko);
                lv.SubItems.Add(o.Wiek.ToString());
                lv.SubItems.Add(o.Wzrost.ToString());
                lv.SubItems.Add(o.Narodowość);
                lv.SubItems.Add(o.Pozycja);
                lv.SubItems.Add(o.Wartosc);
                lv.SubItems.Add(o.Zarobki);
                listView1.Items.Add(lv);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
