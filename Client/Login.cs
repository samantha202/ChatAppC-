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
    public partial class Login : Form
    {
        string file = @"A:\users.txt";
        bool inter = false;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client c = new Client();
            List<Client> cltL = new List<Client>();
            cltL = c.getClient(file);
            foreach (Client ct in cltL)
            {
                if (log.Text == ct.getEmail() && pass.Text == ct.getPass())
                {
                    inter = true;
                    Client.variableSession = ct.getFirstName();
                    Client.cltSession = ct;
                    Home home = new Home();
                    home.setName(ct.getFirstName());
                    home.Show();
                    this.Hide();
                }
            }
            if (inter == false)
            {
                MessageBox.Show("the userName and the password you entered is not correct please check");
            }
        }
    }
}
