using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio13
    {
        public void Executar()
        {
            int jogadores = 0;
            double maiorAltura = double.MinValue;
            string jogadorMaiorAltura = "";
            double menorPeso = double.MaxValue;
            string jogadorMenorPeso = "";
            double maiorPeso = double.MinValue;
            int menorQuantidadeCartoesAmarelos = int.MaxValue;
            int maiorQuantidadeCatoesAmarelos = int.MinValue;
            int maiorQuantidadeCartoesVermelhoa = int.MaxValue;
            int menorQuantidadeCartoesVermelhos = int.MaxValue;
            int quantidadeSexoF = 0;
            int quantidadeSexoM = 0;

            while(jogadores < 22)
            {
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite a idade: ");
                int idade = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o peso: ");
                double peso = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o sexo: ");
                string sexo = Console.ReadLine().ToLower().Trim();

                Console.Write("Digite a altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a quantidade de gols marcados: ");
                int quantidadesGolsMarcados = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite a quantidade de cartões amarelos recebidos: ");
                int quantidadeCartoesAmarelos = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite a quantidade de cartões vermelhos recebidos: ");
                int quantidadeCartoesVermelhos = Convert.ToInt32(Console.ReadLine());

                if(peso < menorPeso)
                {
                    jogadorMenorPeso = nome;
                    menorPeso = peso;
                }
                if(altura > maiorAltura)
                {
                    jogadorMaiorAltura = nome;
                    maiorAltura = altura;
                }
                if(sexo == "f")
                {
                    quantidadeSexoF = quantidadeSexoF + 1;
                }
                if(sexo == "m")
                {
                    quantidadeSexoM = quantidadeSexoM + 1;
                }
                if(quantidadeCartoesAmarelos < menorQuantidadeCartoesAmarelos)
                {
                    menorQuantidadeCartoesAmarelos = quantidadeCartoesAmarelos;
                }
                if(peso > maiorPeso)
                {
                    maiorPeso = peso;
                }
                if(quantidadeCartoesVermelhos < menorQuantidadeCartoesVermelhos)
                {
                    menorQuantidadeCartoesVermelhos = quantidadeCartoesVermelhos;
                }
                if(quantidadeCartoesAmarelos > maiorQuantidadeCatoesAmarelos)
                {
                    maiorQuantidadeCatoesAmarelos = quantidadeCartoesAmarelos;
                }
                if(quantidadeCartoesVermelhos < menorQuantidadeCartoesVermelhos)
                {
                    menorQuantidadeCartoesVermelhos = quantidadeCartoesVermelhos;
                }

                jogadores = jogadores + 1;
            }
        }
    }
}
