﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console01_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Código by: Letícia França
            int numero = 0, contador = 0;
            Console.WriteLine("Digite um número inteiro: ");

            while (contador < 20)
            {
                numero = int.Parse(Console.ReadLine());

                contador = contador + 1;
            }
            Console.WriteLine("Foram inseridos " + contador + " números.");
            Console.ReadKey();
        }
    }
}