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
    public partial class AddForm : Form
    {
        string file = @"A:\stories.txt";
        public AddForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChatRoom t1 = new ChatRoom();
            String str = pictureBox1.ImageLocation;
            String titles = title.Text;
            ChatRoom t = new ChatRoom(titles, str, "");
            t1.addTopic(t);
            t1.load(file);
            t1.save(file);
        }
        //this function load an image
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *gif|*.jpg; *png; *gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
