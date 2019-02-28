using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ASort
{
    class SortClass
    {
        public SortClass(string path, string sorttype)
        {
            int separator = sorttype.IndexOf('>');
            string folder = sorttype.Substring(separator+1);
            string format = sorttype.Substring(0, separator);
            string sortfolder = path + "\\" + folder;
            string[] formats = format.Split(',');
            string expect = System.Reflection.Assembly.GetEntryAssembly().Location;
            if (!Directory.Exists(sortfolder)){
                Directory.CreateDirectory(sortfolder);
            }
            for (int i = 0; i < formats.Length; i++) {
                string[] tosort = Directory.GetFiles(path, "*"+formats[i]);
                for (int k = 0; k <tosort.Length; k++) {
                    
                    if (tosort[k] != expect && !Path.GetFileName(tosort[k]).Equals("Data.txt"))
                    {
                        File.Move(tosort[k], sortfolder+"\\"+Path.GetFileName(tosort[k]));
                    }
                }
            }
        }
    }
}
