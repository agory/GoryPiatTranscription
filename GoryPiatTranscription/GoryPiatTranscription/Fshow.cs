using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileLib;

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
            FileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fichiers texte|*.txt|Tous les fichiers|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                File file = new File(path);
                try{
                    file.write(tbResult.Text);
                    MessageBox.Show("Enregistrement effectué.");
                }
                catch (Exception ex){
                    MessageBox.Show("Une erreur est survenue lors de l'écriture du fichier: " + ex.Message);
                }

            }
        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbResult.Text);
        }

    }
}
