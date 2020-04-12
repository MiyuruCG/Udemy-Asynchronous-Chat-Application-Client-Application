using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDP_Chat_Client_Form
{
    public partial class Form1 : Form
    {
        UDP_Asynchronous_Chat.UDPAsynchronousChatClient mChatClient;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSendBroadcast_Click(object sender, EventArgs e)
        {
            if (mChatClient == null)
            {
                int.TryParse(tbLocalPort.Text, out var nLocalPort);
                int.TryParse(tbRemotePort.Text, out var nRemotePort);

                mChatClient = new UDP_Asynchronous_Chat.UDPAsynchronousChatClient(nLocalPort, nRemotePort);
            }
            mChatClient.SendBroadcast(tbBroadcatText.Text);
        }
    }
}
