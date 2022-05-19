using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioForEtry
{
    internal class Exercicio06
    {
        public void Executar()
        {
            var valorValido = false;
            var jogadorMenorPeso = double.MaxValue;
            var nomeMenorPeso = "";
            var jogadorMaiorPeso = double.MinValue;
            var nomeMaiorPeso = "";
            var jogadorMaiorAltura = double.MinValue;
            var nomeMaiorAltura = "";
            var jogadorMenorNome = int.MaxValue;
            var nomeMenorNome = "";
            var JogadorMaiorNome = int.MinValue;
            var nomeMaiorNome = "";
            var jogadoresF = 0;
            var jogadoresM = 0;
            var menorQuantidadeCartoesAmarelos = int.MaxValue;
            var nomeMenorQuantidadeCartoesAmarelos = "";
            var maiorQuantidadeCartoesAmarelos = int.MinValue;
            var nomeMaiorQuantidadeCartoesAmarelos = "";
            var menorQuantidadeCartoesVermelhos = int.MaxValue;
            var nomeMenorQuantidadeCartoesVermelhos = "";
            var MaiorQuantidadeCartoesVermelhos = int.MinValue;
            var nomeMaiorQuantidadeCartoesVermelhos = "";
            for(var i = 0; i < 22; i++)
            {
                Console.Write("Digite o nome: ");
                var nome = Console.ReadLine().ToLower().Trim();
                var peso = 0.0;
                var sexo = "";
                var altura = 0.0;
                var quantidadeGols = 0;
                var quantidadeCartoesAmarelos = 0;
                var quantidadeCartoesVermelhos = 0;
                while (valorValido == false)
                {
                    try
                    {
                        Console.Write("Digite a idade: ");
                        var idade = Convert.ToInt32(Console.ReadLine());
                        valorValido = true;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Valor invalido");
                    }
                }
                valorValido = false;
                while(valorValido == false)
                {
                    try{
                        Console.Write("Digite o peso: ");
                        peso = Convert.ToDouble(Console.ReadLine());
                        valorValido = true;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Valor invalido");
                    }
                }
                valorValido = false;
                while(valorValido == false)
                {
                    try
                    {
                        Console.Write("Digite o sexo( F ou M ): ");
                        sexo = Console.ReadLine();
                        valorValido = true;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Valor invalido");
                    }
                }
                valorValido = false;
                while(valorValido == false)
                {
                    try
                    {
                        Console.Write("Digite a altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        valorValido = true;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Valor invalido");
                    }
                }
                valorValido = false;
                while (valorValido == false)
                {
                    try
                    {
                        Console.Write("Digite a quantidade de gols marcados: ");
                        quantidadeGols = Convert.ToInt32(Console.ReadLine());
                        valorValido = true;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Valor invalido");
                    }
                }
                valorValido = false;
                while (valorValido == false)
                {
                    try
                    {
                        Console.Write("Digite a quantidade de cartões amarelos recebidos: ");
                        quantidadeCartoesAmarelos = Convert.ToInt32(Console.ReadLine());
                        valorValido = true;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Valor invalido");
                    }
                }
                valorValido = false;
                while (valorValido == false)
                {
                    try
                    {
                        Console.Write("Digite a quantidade de cartões vermelhos recebidos: ");
                        quantidadeCartoesVermelhos = Convert.ToInt32(Console.ReadLine());
                        valorValido = true;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Valor invalido");
                    }
                }
                valorValido = false;
                var quantidadeLetrar = nome.Length;

                if(peso < jogadorMenorPeso)
                {
                    jogadorMenorPeso = peso;
                    nomeMenorPeso = nome;
                }
                if(peso > jogadorMaiorPeso)
                {
                    jogadorMaiorPeso = peso;
                    nomeMaiorPeso = nome;
                }
                if(altura > jogadorMaiorAltura)
                {
                    jogadorMaiorAltura = altura;
                    nomeMaiorAltura = nome;
                }
                if(quantidadeLetrar < jogadorMenorNome)
                {
                    jogadorMenorNome = quantidadeLetrar;
                    nomeMenorNome = nome;
                }
                if(quantidadeLetrar > JogadorMaiorNome)
                {
                    JogadorMaiorNome = quantidadeLetrar;
                    nomeMaiorNome = nome;
                }
                if(sexo == "f")
                {
                    ++jogadoresF;
                }
                else if(sexo == "m")
                {
                    ++jogadoresM;
                }
                if(quantidadeCartoesAmarelos < menorQuantidadeCartoesAmarelos)
                {
                    menorQuantidadeCartoesAmarelos = quantidadeCartoesAmarelos;
                    nomeMenorQuantidadeCartoesAmarelos = nome;
                }
                if(quantidadeCartoesAmarelos > maiorQuantidadeCartoesAmarelos)
                {
                    maiorQuantidadeCartoesAmarelos = quantidadeCartoesAmarelos;
                    nomeMaiorQuantidadeCartoesAmarelos = nome;
                }
                if(quantidadeCartoesVermelhos < menorQuantidadeCartoesVermelhos)
                {
                    menorQuantidadeCartoesVermelhos = quantidadeCartoesVermelhos;
                    nomeMenorQuantidadeCartoesVermelhos = nome;
                }
                if(quantidadeCartoesVermelhos > MaiorQuantidadeCartoesVermelhos)
                {
                    MaiorQuantidadeCartoesVermelhos = quantidadeCartoesVermelhos;
                    nomeMaiorQuantidadeCartoesVermelhos = nome;
                }
            }
            Console.WriteLine("O jogador com menor peso é: " + nomeMenorPeso + " com: " + jogadorMenorPeso);
            Console.WriteLine("O jogador com a maior altura é: " + nomeMaiorAltura + " com: " + jogadorMaiorAltura);
            Console.WriteLine("O jogador com o maior nome é: " + nomeMaiorNome + " com: " + JogadorMaiorNome + " letras");
            Console.WriteLine("A quantidade de jogadores do sexo F é: " + jogadoresF);
            Console.WriteLine("A quantidade de jogadores do sexo M é: " + jogadoresM);
            Console.WriteLine("O jogador com a menor quantidade de cartões amarelos recebidos é: " + nomeMenorQuantidadeCartoesAmarelos + " com: " + menorQuantidadeCartoesAmarelos);
            Console.WriteLine("O jogador com menor nome é: " + nomeMenorNome + " com: " + jogadorMenorNome + " letras");
            Console.WriteLine("O jogador com o maior peso é: " + nomeMaiorPeso + " com: " + jogadorMaiorPeso);
            Console.WriteLine("O jogador com a maior quantidade de cartões vermelhos é: " + nomeMaiorQuantidadeCartoesVermelhos + " com: " + MaiorQuantidadeCartoesVermelhos);
            Console.WriteLine("O jogador com a maior quantidade de cartões amarelos recebidos é: " + nomeMaiorQuantidadeCartoesAmarelos + " com: " + maiorQuantidadeCartoesAmarelos);
            Console.WriteLine("O jogador com a menor quantidade de cartões vermelhos recebidos é: " + nomeMenorQuantidadeCartoesVermelhos + " com: " + menorQuantidadeCartoesVermelhos);
        }
    }
}
