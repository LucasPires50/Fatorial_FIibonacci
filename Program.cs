using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial_FIibonacci_Divisivel3ou4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FIBONACCI");

            int numAnt = 1;
            int numAtual = 0;
            int numProx = 0;

            for(int i = 1; i <=10; i++ )
            {

                numProx = numAnt + numAtual;

                numAnt = numAtual;
                numAtual = numProx;

                Console.WriteLine($"{numProx} = {numAnt} + {numAtual}");
            }

            Console.WriteLine("----------------------------------------------------------------------------");

            Console.WriteLine("FATORIAL");

            long fatorail = 1;

            Console.WriteLine("Informe um número: ");
            string numInfor = Console.ReadLine();
            long numInformado = long.Parse(numInfor);

            for(long i = numInformado; i >=1; i--)
            {
                fatorail = fatorail * i;

                Console.WriteLine($"{i} *");
               
            }

            
            Console.WriteLine($"Fatorial: {fatorail}");


            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("DIVISIVEL POR 3 OU POR 4");

            int num = 0;

            for (int i = 0; i <= 30; i++)
            {
                if(i % 3 == 0 || i % 4 ==0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
