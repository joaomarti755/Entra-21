using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio12
    {
        public void Executar()
        {
			int codigoProduto = 0;

			while (codigoProduto != 16)
            {
				Console.WriteLine(" Código   | Tipo        | Nome                                         | Valor      ");
				Console.WriteLine(" -----------------------------------------------------------------------------------");
				Console.WriteLine(" 1        | Bolos       | Bolo Brigadeiro                              | R$ 29,50   ");
				Console.WriteLine(" -----------------------------------------------------------------------------------");
				Console.WriteLine(" 2        | Bolos       | Bolo Floresta Negra                          | R$ 2,00    ");
				Console.WriteLine(" -----------------------------------------------------------------------------------");
				Console.WriteLine(" 3        | Bolos       | Bolo Leite com Nutella                       | R$ 29,23   ");
				Console.WriteLine(" -----------------------------------------------------------------------------------");
				Console.WriteLine(" 4        | Bolos       | Bolo Mousse de Chocolate                     | R$ 7,10    ");
				Console.WriteLine(" -----------------------------------------------------------------------------------");
				Console.WriteLine(" 5        | Bolos       | Bolo Nega Maluca                             | R$ 19,33   ");
				Console.WriteLine(" -----------------------------------------------------------------------------------");
				Console.WriteLine(" 6        | Doces       | Bolo de Creme                                | R$ 17,71   ");
				Console.WriteLine(" -----------------------------------------------------------------------------------");
				Console.WriteLine(" 7        | Doces       | Bolo de Morango                              | R$ 4,82    ");
				Console.WriteLine(" -----------------------------------------------------------------------------------");
				Console.WriteLine(" 8        | Sanduíches  | Filé-Mignon com fritas e cheddar             | R$ 21,16   ");
				Console.WriteLine(" -----------------------------------------------------------------------------------");
				Console.WriteLine(" 9        | Sanduíches  | Hambúrguer com queijos,champignon e rúcula   | R$ 12,70   ");
				Console.WriteLine(" -----------------------------------------------------------------------------------");
				Console.WriteLine(" 10       | Sanduíches  | Provolone com salame                         | R$ 19,70   ");
				Console.WriteLine(" -----------------------------------------------------------------------------------");
				Console.WriteLine(" 11       | Sanduíches  | Vegetariano de berinjela                     | R$ 28,22   ");
				Console.WriteLine(" -----------------------------------------------------------------------------------");
				Console.WriteLine(" 12       | Pizzas      | Calabresa                                    | R$ 8,98    ");
				Console.WriteLine(" -----------------------------------------------------------------------------------");
				Console.WriteLine(" 13       | Pizzas      | Napolitana                                   | R$ 0,42    ");
				Console.WriteLine(" -----------------------------------------------------------------------------------");
				Console.WriteLine(" 14       | Pizzas      | Peruana                                      | R$ 18,36   ");
				Console.WriteLine(" -----------------------------------------------------------------------------------");
				Console.WriteLine(" 15       | Pizzas      | Portuguesa                                   | R$ 27,50   ");
				Console.WriteLine(" -----------------------------------------------------------------------------------");
				Console.WriteLine(" 16                     | Sair                                                      ");

				Console.Write("Digite o código do produto: ");
				codigoProduto = Convert.ToInt32(Console.ReadLine());

            }
		}
	}
}
