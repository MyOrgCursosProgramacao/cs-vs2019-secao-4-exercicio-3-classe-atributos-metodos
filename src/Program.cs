using System;
using System.Globalization;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resolução do Exercício proposto 3 da Seção 4" + Environment.NewLine);
            Console.WriteLine("Entre com os dados do aluno.");

            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as notas do aluno (3): ");
            Console.Write("Nota 1: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 2: ");
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 3: ");
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine(aluno.ToString());

        }
    }
}
