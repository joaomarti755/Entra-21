using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioListaObjeto.ExercicioAluno
{
    internal class Aluno
    {
        public string Nome;
        public int CodigoMatricula;
        public int idade;
        public string MateriaFavorita;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double CalcularMedia()
        {
            var media = Nota1 + Nota2 + Nota3 / 3;

            return media;
        }

        public AlunoStatus ObterStatus()
        {
            if(CalcularMedia() >= 7)
            {
                return AlunoStatus.Aprovado;
            }
            else if(CalcularMedia() >= 5)
            {
                return AlunoStatus.EmExame;
            }
            else
            {
                return AlunoStatus.Reprovado;
            }
        }
    }
}
