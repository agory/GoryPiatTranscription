using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLib
{
    public class File
    {
        private string path;

        public File(string path)
        {
            this.path = path;
        }

        public string read() {
            string fileContent="";
            if (System.IO.File.Exists(path))
            {
                using (Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            else {
                throw new Exception("Chemin invalide");
            }

            return fileContent;
        }

        public void write(string fileContent) {
            Stream myStream = new FileStream(path, FileMode.Create);
            if (myStream != null)
            {
                using (myStream)
                {
                    using (StreamWriter writer = new StreamWriter(myStream, Encoding.UTF8))
                    {
                        writer.Write(fileContent);
                    }
                }
            }
        }
    }
}
