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
            string jogadorMaiorPeso = "";

            int menorQuantidadeCartoesAmarelos = int.MaxValue;
            string jogadorMenorQuantidadeCartoesAmarelos = "";

            int maiorQuantidadeCartoesAmarelos = int.MinValue;
            string jogadorMaiorQuantidadeCartoesAmarelos = "";

            int maiorQuantidadeCartoesVermelhoa = int.MinValue;
            string jogadorMaiorQuantidadeCartoesVermelhoa = "";

            int menorQuantidadeCartoesVermelhos = int.MaxValue;
            string jogadorMenorQuantidadeCartoesVermelhos = "";

            int quantidadeSexoF = 0;
            int quantidadeSexoM = 0;
            int quantidadeLetrasNome = 0;

            int maiorQuantidadeLetrasNome = int.MinValue;
            string jogadorMaiorQuantidadeLetrasNome = "";

            int menorQuantidadeLetrasNome = int.MaxValue;
            string jogadorMenorQuantidadeLetrasNome = "";

            while (jogadores < 22)
            {
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite a idade: ");
                int idade = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o peso: ");
                double peso = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o sexo M ou F: ");
                string sexo = Console.ReadLine().ToLower().Trim();

                Console.Write("Digite a altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a quantidade de gols marcados: ");
                int quantidadesGolsMarcados = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite a quantidade de cartões amarelos recebidos: ");
                int quantidadeCartoesAmarelos = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite a quantidade de cartões vermelhos recebidos: ");
                int quantidadeCartoesVermelhos = Convert.ToInt32(Console.ReadLine());

                quantidadeLetrasNome = nome.Length;

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
                else if(sexo == "m")
                {
                    quantidadeSexoM = quantidadeSexoM + 1;
                }
                if(quantidadeCartoesAmarelos < menorQuantidadeCartoesAmarelos)
                {
                    jogadorMenorQuantidadeCartoesAmarelos = nome;
                    menorQuantidadeCartoesAmarelos = quantidadeCartoesAmarelos;
                }
                if(peso > maiorPeso)
                {
                    jogadorMaiorPeso = nome;
                    maiorPeso = peso;
                }
                if(quantidadeCartoesVermelhos < menorQuantidadeCartoesVermelhos)
                {
                    jogadorMenorQuantidadeCartoesVermelhos = nome;
                    menorQuantidadeCartoesVermelhos = quantidadeCartoesVermelhos;
                }
                if(quantidadeCartoesAmarelos > maiorQuantidadeCartoesAmarelos)
                {
                    jogadorMaiorQuantidadeCartoesAmarelos = nome;
                    maiorQuantidadeCartoesAmarelos = quantidadeCartoesAmarelos;
                }
                if(quantidadeCartoesVermelhos > maiorQuantidadeCartoesVermelhoa)
                {
                    jogadorMaiorQuantidadeCartoesVermelhoa = nome;
                    maiorQuantidadeCartoesVermelhoa = quantidadeCartoesVermelhos;
                }
                if(quantidadeLetrasNome < menorQuantidadeLetrasNome)
                {
                    jogadorMenorQuantidadeLetrasNome = nome;
                    menorQuantidadeLetrasNome = quantidadeLetrasNome;
                }
                if(quantidadeLetrasNome > maiorQuantidadeLetrasNome)
                {
                    jogadorMaiorQuantidadeLetrasNome = nome;
                    maiorQuantidadeLetrasNome = quantidadeLetrasNome;
                }
                jogadores = jogadores + 1;
            }
            Console.WriteLine("Jogador com menor peso é: " + jogadorMenorPeso + " com: " + menorPeso);
            Console.WriteLine("Jogador com maior peso é: " + jogadorMaiorPeso + " com: " + maiorPeso);
            Console.WriteLine("Jogador com maior altura é: " + jogadorMaiorAltura + " com: " + maiorAltura);
            Console.WriteLine("Quantidade de jogadores do sexo F é: " + quantidadeSexoF);
            Console.WriteLine("Quantidade de jogadores do sexo M é: " + quantidadeSexoM);
            Console.WriteLine("Jogador com menor quantidade de cartões amarelos é: " + jogadorMenorQuantidadeCartoesAmarelos + " com: " + menorQuantidadeCartoesAmarelos);
            Console.WriteLine("Jogador com maior quantidade de cartões amarelos é: " + jogadorMaiorQuantidadeCartoesAmarelos + " com: " + maiorQuantidadeCartoesAmarelos);
            Console.WriteLine("Jogador com menor quantidade de cartões vermelhos é: " + jogadorMenorQuantidadeCartoesVermelhos + " com: " + menorQuantidadeCartoesVermelhos);
            Console.WriteLine("Jogador com maior quantidade de cartões vermelhos é: " + jogadorMaiorQuantidadeCartoesVermelhoa + " com: " + maiorQuantidadeCartoesVermelhoa);
            Console.WriteLine("Jogador com menor nome é: " + jogadorMenorQuantidadeLetrasNome + " com: " + menorQuantidadeLetrasNome);
            Console.WriteLine("Jogador com maior nome é: " + jogadorMaiorQuantidadeLetrasNome + " com: " + maiorQuantidadeLetrasNome);
        }
    }
}
