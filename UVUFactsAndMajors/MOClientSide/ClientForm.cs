using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOClientSide
{
    public partial class ClientForm : Form
    {
        SynchronousSocketClient ssc = new SynchronousSocketClient();
        public ClientForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// when pushing button, send request to server and wait for a response
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //whatever the server returns, assign it to our response textbox so we can see it
            TxtBoxResponse.Text = ssc.ContactServer(TxtBoxRequest.Text);
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
