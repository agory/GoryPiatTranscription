using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transposition;

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
            // TODO Decrypt(password,text)
            Form fshow = new Fshow("tosqdgvqegdbgfsdgfzegvfgdhbgvqsdrfdcdswgbfwchbvdwv vnbfdsfdcds nxfdgfvfcxbwcxbgvfdwwdcxbdxwfcxvnbxwcqsgv");
            fshow.Show();

        }

        private void btResetEncrypt_Click(object sender, EventArgs e)
        {
            tbPasswordEncrypt.Clear();
            tbTextEncrypt.Clear();
        }

        private void btValidationEncrypt_Click(object sender, EventArgs e)
        {
            String pasword = tbPasswordEncrypt.Text;
            String text = tbTextEncrypt.Text;
            // TODO ENCrypt(password,text)
            Form fshow = new Fshow("tosqdgvqegdbgfsdgfzegvfgdhbgvqsdrfdcdswgbfwchbvdwv vnbfdsfdcds nxfdgfvfcxbwcxbgvfdwwdcxbdxwfcxvnbxwcqsgv");
            fshow.Show();
        }

        private void Ftranscription_Load(object sender, EventArgs e)
        {
            Transcription maTranscription = new Transcription();
            /*            
            int[] transpoSeqTest = Transcription.computeTranspoSequence("istil");
            String transpo = "";
            for(int i=0;i<transpoSeqTest.Count();++i){
                transpo += transpoSeqTest[i].ToString();
            }

            MessageBox.Show(transpo);
            int valueChar = Convert.ToInt16('B');
            MessageBox.Show(valueChar.ToString());
             */
        }
    }
}
