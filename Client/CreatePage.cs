using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class CreatePage : Form
    {
        string file = @"A:\users.txt";
        public CreatePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            Client clt = new Client(firstname.Text, lastname.Text, email.Text, password.Text);
            clt.load(file, clt);
            clt.save(file);
            new Login().Show();
            this.Hide();
        }

        private void connexion_Click(object sender, EventArgs e)
        {
            Client c = new Client();
            c.getAll(file);
            new Login().Show();
            this.Hide();
        }
    }
}
