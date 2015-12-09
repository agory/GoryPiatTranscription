using FileLib;
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
            tbPasswordEncrypt.Text = "";
            tbTextEncrypt.Text = "";
        }

        private void btValidationEncrypt_Click(object sender, EventArgs e)
        {
            String pasword = tbPasswordEncrypt.Text;
            String text = tbTextEncrypt.Text;
            // TODO ENCrypt(password,text)
            Form fshow = new Fshow("tosqdgvqegdbgfsdgfzegvfgdhbgvqsdrfdcdswgbfwchbvdwv vnbfdsfdcds nxfdgfvfcxbwcxbgvfdwwdcxbdxwfcxvnbxwcqsgv");
            fshow.Show();
        }

        private void btOpenEncrypt_Click(object sender, EventArgs e)
        {
            tbTextEncrypt.Text = openFile();
        }

        private void btOpenDecrypt_Click(object sender, EventArgs e)
        {
            tbTextDecrypt.Text = openFile();
        }

        private String openFile() {
            string content = "";
            FileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fichiers texte|*.txt|Tous les fichiers|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                File file = new File(path);
                try
                {
                    content= file.read();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de l'écriture du fichier: {0}.", ex.Message);
                }

            }
            return content;
        }

        private void Ftranscription_Load(object sender, EventArgs e)
        {
            Transcription maTranscription = new Transcription();
            Dictionary<int, int> transpo = maTranscription.computeTranspoSequence("ISTIL");
            MessageBox.Show(transpo[0].ToString() + " - " + transpo[1].ToString() + " - " + transpo[2].ToString() + " - " + transpo[3].ToString() + " - " + transpo[4].ToString() + " - ");
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
