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
    public partial class Home : Form
    {
        string file = @"A:\stories.txt";
        String name = null;
        int leftcontrol = 1;
        int j = 1000;
        public Home()
        {
            InitializeComponent();
            ChatRoom t = new ChatRoom();
            t.load(file);
        }
        public void setName(String title)
        {
            this.Text = title;
            name = title;
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            FormMain form = new FormMain();
            string comCat = " " + Client.variableSession + "--- " + ChatRoom.topicSession;
            form.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new AddForm().Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
