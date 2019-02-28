using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ASort
{
    
    public partial class ASort : Form
    {
        string GPath = "";
        public ASort()
        {
            InitializeComponent();
        }

        private void SelectB_Click(object sender, EventArgs e)
        {
            DialogResult Bool = FolderDial.ShowDialog();
            string Path = FolderDial.SelectedPath;
            if (Bool == DialogResult.OK && !string.IsNullOrWhiteSpace(Path))
            {
                PathBox.Text = Path;
                Upd();
            }
        }
        private void Upd()
        {
            if (Directory.Exists(PathBox.Text))
            {
                GPath = PathBox.Text;
                TruePath.Text = GPath;
            }
        }
        private void Readdata(string path)
        {
            bool first = true;
            string line;
            string allsort = "";
            using (StreamReader sr = new StreamReader(path))
            {
                if (sr.ReadToEnd().Length == 0)
                {
                    sr.Close();
                    StreamWriter sw = new StreamWriter(path);
                    sw.WriteLine("png,jpg,bmp>image;");
                    sw.WriteLine("mp3,wav>music;");
                    sw.WriteLine("exe,ink>program;");
                    sw.Close();
                }
            }
            using (StreamReader sr = new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    allsort += (first ? "" : "\n") + line;
                    first = false;
                }
            }
            ConvertTypes.Text = allsort;
            
        }
        private void ASort_Shown(object sender, EventArgs e)
        {
            string curpath = Environment.CurrentDirectory;
            string datapath = curpath + "\\Data.txt";
            PathBox.Text = curpath;
            if (File.Exists(datapath))
            {
                Readdata(datapath);
            }
            else
            {
                StreamWriter sw = new StreamWriter(datapath);
                sw.WriteLine("png,jpg,bmp>image;");
                sw.WriteLine("mp3,wav>music;");
                sw.WriteLine("exe,ink>program;");
                sw.Close();
                Readdata(datapath);
            }
            
            Upd();
        }

        private void PathBox_KeyUp(object sender, KeyEventArgs e)
        {
            Upd();
        }

        private void ConvertTypes_KeyUp(object sender, KeyEventArgs e)
        {
                string curpath = Environment.CurrentDirectory;
                string datapath = curpath + "\\Data.txt";
                using (StreamWriter sw = new StreamWriter(datapath, false))
                {
                    sw.Write(ConvertTypes.Text);
                }
        }

        private void SortB_Click(object sender, EventArgs e)
        {
            string[] sorts = ConvertTypes.Text.Split(';');
            for (int i = 0; i <sorts.Length; i++) {
                if (sorts[i].IndexOf("\n") != -1)
                {
                    sorts[i] = sorts[i].Substring(sorts[i].IndexOf("\n")+1);
                    
                }
                if (!string.IsNullOrWhiteSpace(sorts[i]))
                {
                    SortClass SortThis = new SortClass(GPath, sorts[i]);
                }
            }
        }
    }
}
