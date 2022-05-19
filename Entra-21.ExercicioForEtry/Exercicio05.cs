using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioForEtry
{
    internal class Exercicio05
    {
        public void Executar()
        {
			var codigoProduto = 0;
			var quantidadeBolos = 0;
			var quantidadeDoces = 0;
			var quantidadeSanduiches = 0;
			var quantidadePizza = 0;
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
			for(var i = 0; i < 5; i++)
            {
				var valorValido = false;
				while(valorValido == false)
                {
					try
					{
						Console.Write("Digite o código do produto: ");
						codigoProduto = Convert.ToInt32(Console.ReadLine());
						valorValido = true;
					}
					catch(Exception ex)
                    {
						Console.WriteLine("Valor invalido");
                    }
                }
				if ((codigoProduto == 1) || (codigoProduto == 2) || (codigoProduto == 3) || (codigoProduto == 4) || (codigoProduto == 5))
				{
					++quantidadeBolos;
				}
				else if ((codigoProduto == 6) || (codigoProduto == 7))
				{
					++quantidadeDoces;
				}
				else if ((codigoProduto == 8) || (codigoProduto == 9) || (codigoProduto == 10) || (codigoProduto == 11))
				{
					++quantidadeSanduiches;
				}
				else if ((codigoProduto == 12) || (codigoProduto == 13) || (codigoProduto == 14) || (codigoProduto == 15))
				{
					++quantidadePizza;
				}

			}
		}
    }
}
