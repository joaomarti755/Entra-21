using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioListas
{
    public class Exercicio02
    {
        public void Executar()
        {
            List <string> conteudos = new List<string>();
            conteudos.Add("Como fazer bolo");

            Console.WriteLine(conteudos[0]);

            conteudos[0] = "Algoritmos onde vivem? Do que se alimentam”";

            conteudos.Add("Variáveis");
            conteudos.Add("Mais para frente");

            conteudos[2] = "If com E";

            conteudos.Add("If com OU");
            conteudos.Add("While");
            conteudos.Add("For");

            Console.WriteLine($"{conteudos[0]}\n{conteudos[1]}\n{conteudos[2]}\n{conteudos[3]}\n{conteudos[4]}\n{conteudos[5]}");

            conteudos.Add("Vetor");
            conteudos.Add("Vetor");

            conteudos.Remove("Vetor");
            conteudos.Remove("Vetor");

            conteudos.Add("Vetor");

            conteudos[6] = "Vetor com For um amor na minha vida";

            Console.WriteLine($"{conteudos[0]}\n{conteudos[1]}\n{conteudos[2]}\n{conteudos[3]}\n{conteudos[4]}\n{conteudos[5]}\n{conteudos[6]}");

            conteudos.Add("Classe propriedades e métodos");

            Console.WriteLine($"{conteudos[0]}\n{conteudos[1]}\n{conteudos[2]}\n{conteudos[3]}\n{conteudos[4]}\n{conteudos[5]}\n{conteudos[6]}\n{conteudos[7]}");
        }
    }
}
