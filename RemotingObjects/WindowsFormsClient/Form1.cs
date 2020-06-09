using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class Form1 : Form
    {
        private RemotingObjects.IRemoteObject remoteObject;
        public Form1()
        {
            try
            {
                // tp1 & tp2
                //TcpChannel channel = new TcpChannel();
                //ChannelServices.RegisterChannel(channel, true);
                //remoteObject = (RemotingObjects.IRemoteObject) Activator.GetObject(typeof(RemotingObjects.IRemoteObject),
                //                                                                    "tcp://localhost:12000/HostObject");

                // tp3
                HttpChannel channel = new HttpChannel();
                ChannelServices.RegisterChannel(channel, false);
                remoteObject = (RemotingObjects.IRemoteObject) Activator.GetObject(typeof(RemotingObjects.IRemoteObject),
                                                                                   "http://localhost:14000/HostObject");

            }
            catch
            {
                MessageBox.Show("Error connecting to the server");
            }
            InitializeComponent();
        }

        private void btn_remote_client_Click(object sender, EventArgs e)
        {
            if (remoteObject != null)
            {
                String result = remoteObject.sayHello(txt_name.Text);
                MessageBox.Show("Result : " + result);
            } else
            {
                MessageBox.Show("Error: remote object not available");
            }
        }
    }
}
