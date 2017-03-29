using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula16
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4 = 0;
            string frase = "Digite {0}º nota: ";

            Console.WriteLine(frase, 1);
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(frase, 2);
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(frase, 3);
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(frase, 4);
            nota4 = Convert.ToDouble(Console.ReadLine());

            double total, media = 0;

            total = nota1 + nota2 + nota3 + nota4;
            media = total / 4;

            Console.WriteLine("A média é: " + media);

            if (media >= 7)
            {
                Console.WriteLine("O aluno está aprovado");
            }
            else if (media < 4)
            {
                Console.WriteLine("O aluno está reprovado");
            }
            else {
                Console.WriteLine("O aluno está de exame");
            }


        }
    }
}
