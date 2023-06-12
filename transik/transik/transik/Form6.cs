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
    public partial class Form6 : Form
    {
        string sr = "";
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            listView3.Items.Clear();

            Model model = new Model(sr);
            model.STP1();
            foreach (var o in model.Menadżer)
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

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
