using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseDirectory = @"C:\Users\zohal\OneDrive\Documents";
            //string[] allFiles = Directory.GetFiles(baseDirectory,"*.*",
            //SearchOption.AllDirectories);
            //string filter = "*.exe";
            //string[] allFiles = Directory.GetFileSystemEntries(baseDirectory, filter);
            //foreach (var file in allFiles)
            //{
            //    Console.WriteLine(file);
            //}
            DirectoryInfo dinfo = new DirectoryInfo(baseDirectory);
            //FileInfo[] fi = new string[] { "*.txt", "*.doc", "*.pdf","*.exe" }.
            //    SelectMany(i => dinfo.GetFiles(i, SearchOption.AllDirectories)).ToArray();
            
            //foreach (var file in fi)
            //{
            //    Console.WriteLine(file);
            //}
            FileInfo [] fiAttr = dinfo.GetFiles();
            foreach (FileInfo f in fiAttr)
            {
                Console.WriteLine("The size of {0} is {1} bytes", f.Name, f.Length);
            }
            string s = "homework.txt 999  ";
            //parse s into file names and sizes the save to each category music, image, movies
            string [] temp = s.Split(' ');
            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine("The file {0} has size of {1} ",temp[i],temp[++i]);
            }
            Console.ReadLine();
        }
    }
}
