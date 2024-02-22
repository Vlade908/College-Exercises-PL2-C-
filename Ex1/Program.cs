using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Setando Variaveis
            int continuar = 0;
            double n = 0;
            double soma = 0;


            //-------------------------


            while(continuar <= 4) 
            {
                Console.Write("Digite um numero: ");
                n = double.Parse(Console.ReadLine());
                if(n>0)
                {
                    soma+=n;
                    
                }
                else 
                {
                    Console.WriteLine("O número digitado é invalido, digite um numero positivo Por Favor!");
                }

                continuar++;

            }

            Console.WriteLine("O valor dos 5 n somados é {0}", soma);
        }
    }
}
