using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioListaObjeto
{
    internal class TrianguloControlador
    {
        private TrianguloServico trianguloServico = new TrianguloServico();

        public void GerenciarMenu()
        {
            int codigo = 0;
            
            while(codigo != 6)
            {
                Console.Clear();

                codigo = ApresentarSolicitarMenu();

                Console.Clear();

                if (codigo == 1)
                {
                    ApresentarTriangulos();
                }
                else if(codigo == 2)
                {
                    Cadastrar();
                }
                else if(codigo == 3)
                {
                    Editar();
                }
                else if(codigo == 4)
                {
                    Apagar();
                }
                else if(codigo == 5)
                {
                    ApresentarTrinangulo();
                }

                Console.WriteLine("\n\nAperte alguma tecla para continuar...");
                Console.ReadKey();
            }
        }

        private void ApresentarTrinangulo()
        {
            ApresentarTrinangulo();

            Console.Write("Digite o código do triangulo a ser detalhado: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var triangulo = trianguloServico.ObterPorCodigo(codigo);

            if(triangulo == null)
            {
                Console.WriteLine("Triangulo não cadastrado");

                return;
            }

            Console.Clear();
            Console.WriteLine(@$"Código: {triangulo.Codigo}
Lado1: {triangulo.Lado1}
Lado1: {triangulo.Lado2}
Lado3: {triangulo.Lado3}");
        }

        private void Apagar()
        {
            ApresentarTriangulos();

            Console.Write("Digite o código do triangulo que deseja apagar");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var registroApagado = trianguloServico.Apagar(codigo);

            Console.WriteLine(registroApagado == true
                ? "Registro removido com sucesso"
                : "Nenhum triangulo cadastrado com o código informado");
        }

        private void Editar()
        {
            ApresentarTriangulos();

            Console.Write("Código do triangulo desejado: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lado1: ");
            var lado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lado2: ");
            var lado2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lado3: ");
            var lado3 = Convert.ToInt32(Console.ReadLine());
                
            var alterou = trianguloServico.Editar(codigo, lado1, lado2, lado3);

            if( alterou == false)
            {
                Console.WriteLine("Código digitado não existe");
            }
            else
            {
                Console.WriteLine("Triangolo alterado com sucesso");
            }

        }

        public int ApresentarSolicitarMenu()
        {
            Console.WriteLine(@" MENU
1 - Listar todos
2 - Cadastrar
3 - Editar
4 - Apagar
5 - Apresentar triangulo desejado
6 - Sair");
            int codigo = SolicitarCodigo();
            return codigo;
        }

        private int SolicitarCodigo()
        {
            int codigo = 0;
            while(codigo < 1 || codigo > 6)
            {
                try
                {
                    Console.Write("Digite o código: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Digite um menu válido");
                }
            }
            return codigo;
        }

        private void Cadastrar()
        {
            Console.Write("Lado1: ");
            var lado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lado2: ");
            var lado2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lado3: ");
            var lado3 = Convert.ToInt32(Console.ReadLine());

            trianguloServico.Adicionar(lado1, lado2, lado3);
        }

        private void ApresentarTriangulos()
        {
            var triangulos = trianguloServico.ObterTodos();

            if(triangulos.Count == 0)
            {
                Console.WriteLine("Nenhum triangulo cadastrado");

                return;
            }

            Console.WriteLine("Listas triangulos");

            for(var i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];

                Console.WriteLine(
                    "\nCódigo: " + trianguloAtual.Codigo +
                    "\nLado1: " + trianguloAtual.Lado1 +
                    "\nLado2: " + trianguloAtual.Lado2 +
                    "\nLado3: " + trianguloAtual.Lado3 + "\n");
            }
        }
    }
}
