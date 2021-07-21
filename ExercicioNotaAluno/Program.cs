using System;
using System.Globalization;

namespace ExercicioNotaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Digite as três notas do aluno: ");
            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < s.Length; i++)
            {
                aluno.Notas[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            Console.WriteLine("\nNota final = " + aluno.NotaFinal());
            Console.WriteLine("Situação " + aluno.Aprovado());

            if (aluno.Aprovado() == "Reprovado")
            {
                Console.WriteLine("Faltaram " + aluno.PontosFaltantes().ToString("F2", CultureInfo.InvariantCulture) + " pontos");
            }
        }
    }
}
