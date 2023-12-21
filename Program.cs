using static System.Net.Mime.MediaTypeNames;
using System.Linq.Expressions;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 1;

            for (i = 5; 1 >= 1; i--)
                for (j = 1; j <= 5; j++)
                {
                    Console.Write("*");
                }
            Console.WriteLine(" ");
        }
     }
   }