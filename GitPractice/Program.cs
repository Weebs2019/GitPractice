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
            string[] fileArray = Directory.GetFiles(@"C:\Users\swibowi\Documents\");
            for (int i = 0; i < fileArray.Length; i++)
            {

                Console.WriteLine(fileArray[i]);
            }
            Console.ReadLine();
        }
    }
}
