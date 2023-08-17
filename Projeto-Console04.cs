﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Código by: Letícia França
            Console.WriteLine("Teste do uso do Console...");

            string nome;
            int idade, quantidade = 0;
            double salario;
            char novoCandidato = 'S';

            while (novoCandidato == 'S')
            {
                Console.Write("Digite o nome do cadidato: ");
                nome = Console.ReadLine();
                Console.Write("Digite a idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.Write("Qual o salário pretendido: ");
                salario = double.Parse(Console.ReadLine());

                Console.WriteLine("*------ Dados armazenados com sucesso. ------*");

                quantidade++;  //contador

                Console.Write("Deseja inserir um novo candidato (S/N)?");
                novoCandidato = char.Parse(Console.ReadLine().ToUpper());
            }
            Console.WriteLine("Foram inseridos " + quantidade + " candidatos.");
            Console.ReadKey();

            /* while (quantidade < 10)
            {
                Console.Write("Digite o nome do cadidato: ");
                nome = Console.ReadLine();
                Console.Write("Digite a idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.Write("Qual o salário pretendido: ");
                salario = double.Parse(Console.ReadLine());

                Console.WriteLine("*------ Dados armazenados com sucesso. ------*");

                quantidade++;  //contador
            }
            Console.ReadKey(); */
        }
    }
}