using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = 0;
            double somaN = 0;
            double count = 0;
            double result = 0;
            
            while (true)
            {
                Console.WriteLine("Digite um valor: ");
                n = double.Parse(Console.ReadLine());

                if (n < 0)
                {
                    break;
                }
                else
                {
                    somaN += n;
                    count++;
                }
            }
             result = (count > 0)? somaN / count:0;

            Console.WriteLine("A media dos numeros digitados é: {0}", result);
        }
    }
}
