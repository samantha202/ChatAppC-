using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FormPrivate : Form
    {
        TcpClient clientSocket = new TcpClient();
        String friend, myName;
        public FormPrivate()
        {
            InitializeComponent();
        }

        private void FormPrivate_Load(object sender, EventArgs e)
        {

        }
        public FormPrivate(String friend, TcpClient c, String name)
        {
        }
        public void setHistory(String message)
        {
        }
    }
}
