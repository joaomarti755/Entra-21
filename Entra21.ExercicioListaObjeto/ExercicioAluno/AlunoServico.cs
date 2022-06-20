using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioListaObjeto.ExercicioAluno
{
    internal class AlunoServico
    {
        private List<Aluno> alunos = new List<Aluno>();

        public void Adicionar(string nome, int idade, string materiaFavorita, int codigoMatricula, double nota1, double nota2, double nota3)
        {
            Aluno aluno = new Aluno();

            aluno.Nome = nome;
            aluno.Idade = idade;
            aluno.MateriaFavorita = materiaFavorita;
            aluno.CodigoMatricula = codigoMatricula;
            aluno.Nota1 = nota1;
            aluno.Nota2 = nota2;
            aluno.Nota3 = nota3;

            int codigoAtual = 1;

            aluno.CodigoMatricula = codigoAtual;

            codigoAtual = codigoAtual + 1;

            alunos.Add(aluno);
        }

        public bool RemoverAluno(string nome)
        {
            for(int i = 0; i < alunos.Count; i++)
            {
                Aluno aluno = alunos[i];

                if(aluno.Nome == nome)
                {
                    alunos.Remove(aluno);
                    
                    return true;
                }
            }

            return false;
        }

        public bool EditarDadosCadastrais(int codigoMatricula, string nome, int idade, string materiaFavorita)
        {
            Aluno alunoParaAlterar = ObterPorCodigo(codigoMatricula);

            if(alunoParaAlterar == null)
            {
                return false;
            }

            alunoParaAlterar.Nome = nome;
            alunoParaAlterar.Idade = idade;
            alunoParaAlterar.MateriaFavorita = materiaFavorita;

            return false;

        }
        public bool EditarNotasAluno(int codigoMatricula, double nota1, double nota2, double nota3)
        {
            Aluno alunoParaAlterar = ObterPorCodigo(codigoMatricula);

            if(alunoParaAlterar == null)
            {
                return false;
            }

            alunoParaAlterar.Nota1 = nota1;
            alunoParaAlterar.Nota2 = nota2;
            alunoParaAlterar.Nota3 = nota3;

            return false;
        }

        public List<string> ObterNomes()
        {
            var nomes = new List<string>();

            for(var i = 0; i < alunos.Count; i++)
            {
                var aluno = alunos[i];

                nomes.Add(aluno.Nome);
            }

            return nomes;
        }

        public List<double> ObterMedia()
        {
            var media = new List<double>();

            for(var i = 0;i < alunos.Count; i++)
            {
                var aluno = alunos[i];

                media.Add(aluno.CalcularMedia());
            }

            return media;
        }

        public List<string> Aprovados()
        {
            Aluno aluno = new Aluno();

            var Aprovados = new List<string>();

            for(var i = 0;i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];

                if(aluno.ObterStatus() == AlunoStatus.Aprovado)
                {
                    Aprovados.Add(alunoAtual.Nome);
                }
            }

            return Aprovados;
        }

        public List<string> Reprovados()
        {
            Aluno aluno = new Aluno();

            var Reprovados = new List<string>();

            for (var i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];

                if (aluno.ObterStatus() == AlunoStatus.Reprovado)
                {
                    Reprovados.Add(alunoAtual.Nome);
                }
            }

            return Reprovados;
        }

        public List<string> EmExame()
        {
            Aluno aluno = new Aluno();

            var EmExame = new List<string>();

            for (var i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];

                if (aluno.ObterStatus() == AlunoStatus.EmExame)
                {
                    EmExame.Add(alunoAtual.Nome);
                }
            }

            return EmExame;
        }

        public double ObterMediaPorCodigoMatricula(int codigoMatricula)
        {
            var mediaAlunoAtual = 0.0;

            for(var i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];

                if (alunoAtual.CodigoMatricula == codigoMatricula)
                {
                    mediaAlunoAtual = alunoAtual.CalcularMedia();
                }
            }

            return mediaAlunoAtual;
        }

        //public AlunoStatus ObterSatusPorCodigoMatricula(int codigoMatricula)
        //{
        //    Aluno aluno = new Aluno();

        //    var statusAlunoAtual = ;

        //    for (var i = 0; i < alunos.Count; i++)
        //    {
        //        var alunoAtual = alunos[i];

        //        if (alunoAtual.CodigoMatricula == codigoMatricula)
        //        {
        //            statusAlunoAtual = aluno.ObterStatus();
        //        }
        //    }

        //    return statusAlunoAtual;
        //}

        public double ObterMediaIdade()
        {
            var mediaIdade = 0.0;
            var somaIdade = 0;

            for (var i = 0; i < alunos.Count; i++)
            {
                var idade = 0;
                var aluno = alunos[i];

                idade = aluno.Idade;

                somaIdade = somaIdade + idade;
            }
            mediaIdade = somaIdade / alunos.Count;

            return mediaIdade;
        }

        public Aluno ObterPorCodigo(int codigoMatricula)
        {
            for(var i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];

                if(alunoAtual.CodigoMatricula == codigoMatricula)
                {
                    return alunoAtual;
                }
            }
            return null;
        }
    }
}
