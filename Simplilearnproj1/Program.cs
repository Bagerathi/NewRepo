using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplilearnproj1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"D:\simplilearnproject1\test.txt";

            //  string[] lines = File.ReadAllines(filepath);
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filepath).ToList();

              foreach  (string line in lines)
             {

                Console.WriteLine(line);
            }
            Console.ReadLine();


        }
    }
}
