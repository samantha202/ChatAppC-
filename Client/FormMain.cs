using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FormMain : Form
    {
        public TcpClient clientSocket; //client connection for TCP network services
        public NetworkStream serverStream = default(NetworkStream); //Provides the underlying data flow for network access
        string readData = null;
        Thread ctThread;
        String name = null;
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
        }

        //this function allows you to connect to the server
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                clientSocket.Connect("127.0.0.1", 5000);
                readData = "Connected to Server ";
                msg();

                serverStream = clientSocket.GetStream();

                byte[] outStream = Encoding.ASCII.GetBytes(name + "$");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();
                btnConnect.Enabled = false;

                ctThread = new Thread(getMessage);
                ctThread.Start();
            }
            catch (Exception er)
            {
                MessageBox.Show("Server Not Started");
            }

        }
        private void getMessage()
        {
        }
        //this function allows to display message on TextBox
        private void msg()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg));
            else
                history.Text = history.Text + Environment.NewLine + " >> " + readData;
        }
        //converting object to ByteArray
        public byte[] ObjectToByteArray(object _Object)
        {
            using (var stream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, _Object);
                return stream.ToArray();
            }
        }
        //converting ByteArray to object
        public Object ByteArrayToObject(byte[] arrBytes)
        {
            using (var memStream = new MemoryStream())
            {
                var binForm = new BinaryFormatter();
                memStream.Write(arrBytes, 0, arrBytes.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                var obj = binForm.Deserialize(memStream);
                return obj;
            }
        }
    }
}
