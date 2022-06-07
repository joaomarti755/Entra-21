using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioListas
{
    public class Exercicio01
    {
        public void Executar()
        {
            List <string> filmes = new List<string>();
            filmes.Add("Dragon Ball Evollution");
            filmes.Add("Titanic");
            filmes.Add("Lanterna verde");

            Console.WriteLine($"{filmes[0]}\n{filmes[1]}\n{filmes[2]}");

            filmes.Add("");
            filmes[0] = "Dragon Ball Super: Broly";
            filmes.RemoveAt(2);

            var contemLanternaVerde = filmes.Contains("Lanterna verde");

            if(contemLanternaVerde == false)
            {
                Console.WriteLine("Não esta cadastrado");
            }
            else
            {
                Console.WriteLine("Esta cadastrado");
            }

            filmes.Add("Quarteto fantástico");
            Console.WriteLine($"{filmes[0]}\n{filmes[1]}\n{filmes[2]}\n{filmes[3]}");

            filmes[1] = "Titanic 2";

            Console.WriteLine($"{filmes[0]}\n{filmes[1]}\n{filmes[2]}\n{filmes[3]}");

            var contemAlagoaAzul = filmes.Contains("A Lagoa Azul");

            if(contemAlagoaAzul == false)
            {
                Console.WriteLine("Não existe na lista");
            }
            else
            {
                Console.WriteLine("Existe na lista");
            }
        }

    }
}
