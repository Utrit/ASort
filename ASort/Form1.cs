using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            GPath = PathBox.Text;
        }

        private void ASort_Shown(object sender, EventArgs e)
        {
            PathBox.Text = Environment.CurrentDirectory;
            Upd();
        }
    }
}
