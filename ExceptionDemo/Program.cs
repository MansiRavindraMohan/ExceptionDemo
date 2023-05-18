using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ExceptionClass exception=new ExceptionClass();
            exception.ExceptionMethod();
            Console.ReadLine();
        }
    }
}
