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
            if ((tbPasswordDecrypt.Text != "") && (tbTextDecrypt.Text != ""))
            {
                String key = tbPasswordDecrypt.Text;
                String cypher = tbTextDecrypt.Text;
                Transcription myTranscription = new Transcription(key);
                String cleartext = myTranscription.decrypt(cypher);
                Form fshow = new Fshow(cleartext);
                fshow.Show();
            }
            else
            {
                MessageBox.Show("Merci d'entrer un texte et une clé afin de procéder à l'encryptage");
            }

        }

        private void btResetEncrypt_Click(object sender, EventArgs e)
        {
            tbPasswordEncrypt.Text = "";
            tbTextEncrypt.Text = "";
        }

        private void btValidationEncrypt_Click(object sender, EventArgs e)
        {
            if((tbPasswordEncrypt.Text != "")&&(tbTextEncrypt.Text != ""))
            {
                String key = tbPasswordEncrypt.Text;
                String cleartext = tbTextEncrypt.Text;
                Transcription myTranscription = new Transcription(key);
                String cypher = myTranscription.encrypt(cleartext);
                Form fshow = new Fshow(cypher);
                fshow.Show();
            }
            else
            {
                MessageBox.Show("Merci d'entrer un texte et une clé afin de procéder à l'encryptage");
            }
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
            tbTextEncrypt.Text = "L’ISTIL DEVIENT UNE ECOLE POLYTECHNIQUE ";
            tbPasswordEncrypt.Text = "ISTIL";
            tbTextDecrypt.Text = "’D OYQIE PHL TCLIIEULTULNEONSVNEEETIE C ";
            tbPasswordDecrypt.Text = "hamster";
            
        }

    }
}
