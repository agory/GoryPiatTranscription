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
    public partial class Fshow : Form
    {
        public Fshow(String text)
        {
            InitializeComponent();
            tbResult.Text = text;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {

        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbResult.Text);
        }

    }
}
