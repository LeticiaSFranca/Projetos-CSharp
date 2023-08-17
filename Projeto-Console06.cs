using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pag59Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "", sexo = "", sair = "";
            int idade, homens = 0, mulheres = 0;
            double total = 0, media = 0, porcentagem = 0, contagem = 0;

            while (sair != "exit")
            {
                Console.Write("Digite seu nome: ");
                nome = Console.ReadLine();
                Console.Write("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.Write("Digite seu sexo (m/f): ");
                sexo = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Digite 'exit' para sair ou 'enter' para continuar");
                sair = Console.ReadLine();

                if (sexo == "M".ToUpper())
                {
                    homens++;
                }

                if (sexo == "F".ToUpper() && idade >= 18)
                {
                    mulheres++;
                }

                if (sexo == "F".ToUpper() && idade >= 20 && idade <= 29)
                {
                    contagem++;
                }
                total = idade + total;
            }

            media = total / homens;
            porcentagem = (contagem * 100) / mulheres;

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Mulheres maiores de 18 anos: " + mulheres);
            Console.WriteLine("Média de idade dos homens: " + Math.Round(media, 2));
            Console.WriteLine("Porcentagem de mulheres entre 20 e 29 anos: " + porcentagem + "%");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------");
            Console.ReadKey();
        }
    }
}