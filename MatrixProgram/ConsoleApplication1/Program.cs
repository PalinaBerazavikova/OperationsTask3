using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolveMatrix;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            matrix.ReadFromFileFirst();
            matrix.ReadFromFileSecond();
            matrix.MultiplayMatrix();
            Console.ReadKey();
        }
    }
}
