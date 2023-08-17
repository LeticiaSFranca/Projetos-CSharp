using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pag57_Ex3_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empregados = 0, minimo = 0, contagem = 0;
            string sair = "";
            double salario = 0, gastos = 0, media = 0, porcentagem = 0;

            while (sair != "0")
            {
                Console.Write("Digite o seu salário: ");
                salario = double.Parse(Console.ReadLine());
                Console.WriteLine();

                if (salario < 1212)
                {
                    Console.WriteLine("Erro! Digite um valor acima do salário mínimo.");
                    Console.Write("Digite 0 para sair ou 1 para continuar: ");
                    sair = Console.ReadLine();
                    Console.WriteLine();
                }

                else
                {
                    gastos = salario + gastos;
                    Console.Write("Digite 0 para sair ou 1 para continuar: ");
                    sair = Console.ReadLine();
                    Console.WriteLine();
                    empregados++;
                }

                if (salario == 1212)
                {
                    minimo++;
                }

                if (salario <= 3500)
                {
                    contagem++;
                    porcentagem = (contagem * 100) / empregados;
                }
            }

            media = gastos / empregados;
            Console.WriteLine("");
            Console.WriteLine("Quantidade de empregados que recebem um salário mínimo: " + minimo);
            Console.WriteLine("Porcentagem de empregados que ganham entre R$ 1500,00 e R$ 3500,00: " + porcentagem + "%");
            Console.WriteLine("O gasto total da firma é de: " + "R$ " + Math.Round(media, 2));
            Console.WriteLine("");

            Console.ReadKey();

        }
    }
}
