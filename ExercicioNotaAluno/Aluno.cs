using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioNotaAluno
{
    class Aluno
    {
        public string Nome;
        public double[] Notas = new double[3];
        public double MediaFinal;

        public double NotaFinal()
        {
            MediaFinal = 0;
            for (int i = 0; i < 3; i++)
            {
                MediaFinal += Notas[i];
            }
            return MediaFinal;
        }

        public string Aprovado()
        {
            if (MediaFinal > 60.0)
            {
                return "APROVADO!";
            }
            else
            {
                return "REPROVADO!";
            }
        }

        public double PontosFaltantes()
        {
            return 60.0 - MediaFinal;
        }
    }
}
