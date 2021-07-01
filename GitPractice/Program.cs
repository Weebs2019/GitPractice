using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GetNameOfFiles
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Path");
            Console.WriteLine("Day times kids");
            var dirPath = @"" + Console.ReadLine();

            if (Directory.Exists(dirPath))
            {
                var path = new DirectoryInfo(dirPath);
                var files = path.GetFiles();
            }
            string[] fileArray = Directory.GetFiles(dirPath);
            for (int i = 0; i < fileArray.Length; i++)
            {

                Console.WriteLine(fileArray[i]);
            }
            Console.ReadLine();
        }
    }
}
