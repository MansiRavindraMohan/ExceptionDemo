using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    public class ExceptionClass
    {
        public void ExceptionMethod()
        {
            var filename = "words.txt";
            if(File.Exists(filename))
            {
                var content = File.ReadAllText(filename);
                Console.WriteLine(content);
            }
            try
            {
                var contentOne = File.ReadAllText(filename);
                Console.WriteLine(contentOne);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("failed to read file");
                Console.WriteLine(e.Message);
            }
        }
    }
}
