﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console02_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, contador = 0;
            Console.WriteLine("Digite um número inteiro: ");

            while (numero != -1)
            {
                numero = int.Parse(Console.ReadLine());

                contador = contador + 1;
            }

            Console.WriteLine("Foram inseridos " + contador + " números.");
            Console.ReadKey();
        }
    }
}