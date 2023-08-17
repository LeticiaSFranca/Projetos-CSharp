using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console03_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Código by: Letícia França
            int qntNumero = 0;
            double acumulador = 0, numsDigitados = 0;
            Console.WriteLine("Digite um número inteiro: ");

            while (qntNumero < 10)
            {

                Console.WriteLine("Digite um número: ");
                numsDigitados = double.Parse(Console.ReadLine());

                Console.WriteLine("");
                qntNumero++;

                acumulador = acumulador + numsDigitados;
            }

            Console.WriteLine("Soma total dos números: " + acumulador.ToString());
            Console.ReadKey();
        }
    }
}