using MySql.Data.MySqlClient;


namespace transik
{
   
    public partial class  Form1 : Form
    {
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
           

        }
        Model model=new Model();
        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void password_TextChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void loguj_Click(object sender, EventArgs e)
        {
            model.STP0();
            if (model.zalog(login.Text, password.Text))
            {
                Form2 fr2 = new Form2();
                fr2.ShowDialog();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    

   

    }
