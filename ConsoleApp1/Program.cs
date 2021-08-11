using System;
using System.Linq;
namespace MatrixPrinter
{
    class Program
    {
        private static char[,] matrix = new char[5, 3]
        {
            {'*','*','*'},
            {'*','0','*'},
            {'*','0','*'},
            {'*','0','*'},
            {'*','*','*'}
        };
        static void Main(string[] args)
        {
            for(int col = 0; col < matrix.GetLength(0);col++)
            {
                string prt = String.Join("  ", Enumerable.Range(0, matrix.GetLength(1)).Select(x => matrix[col, x]).ToArray()).Trim(' ');
                Console.WriteLine(prt);
            }
        }
    }
}
