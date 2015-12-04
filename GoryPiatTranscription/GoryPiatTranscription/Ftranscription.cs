using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoryPiatTranscription
{
    public partial class Ftranscription : Form
    {
        public Ftranscription()
        {
            InitializeComponent();
        }

        private void btResetDecrypt_Click(object sender, EventArgs e)
        {
            tbPasswordDecrypt.Text = "";
            tbTextDecrypt.Text = "";

        }

        private void btValidationDecrypt_Click(object sender, EventArgs e)
        {
            String pasword = tbPasswordDecrypt.Text;
            String text = tbTextDecrypt.Text;

            // TODO Crypt(password,text)
        }

        private void btResetEncrypt_Click(object sender, EventArgs e)
        {
            tbPasswordEncrypt.Text = "";
            tbTextEncrypt.Text = "";
        }

        private void btValidationEncrypt_Click(object sender, EventArgs e)
        {
            String pasword = tbPasswordEncrypt.Text;
            String text = tbTextEncrypt.Text;
            // TODO Crypt(password,text)
        }
    }
}
