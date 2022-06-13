namespace Entra21.ExercicioListaObjeto
{
    internal class TrianguloServico
    {
        private List<Triangulo> triangulos = new List<Triangulo>();

        public bool Adicionar(int lado1, int lado2, int lado3)
        {
            Triangulo triangulo = new Triangulo();

            triangulo.Lado1 = lado1;
            triangulo.Lado2 = lado2;
            triangulo.Lado3 = lado3;

            int codigoAtual = 1;

            

            if(triangulo.ValidarTriangulo() == true)
            {

            triangulo.Codigo = codigoAtual;

            codigoAtual = codigoAtual + 1;

            triangulos.Add(triangulo);

                return true;
            }
            else
            {
                return false;
            }

        }
        public bool Editar(int codigoParaAlterar, int lado1, int lado2, int lado3)
        {
            Triangulo trianguloParaAlterar = ObterPorCodigo(codigoParaAlterar);

            if(trianguloParaAlterar == null)
            {
                return false;
            }

            trianguloParaAlterar.Lado1 = lado1;
            trianguloParaAlterar.Lado2 = lado2;
            trianguloParaAlterar.Lado3 = lado3;

            return false;
        }

        public bool Apagar(int codigo)
        {
            for(var i = 0; i < triangulos.Count; i++)
            {
                Triangulo triangulo = triangulos[i];

                if(triangulo.Codigo == codigo)
                {
                    triangulos.Remove(triangulo);

                    return true;
                }
            }

            return false;
        }

        public List<Triangulo> ObterTodos()
        {
            return triangulos;
        }

        public Triangulo ObterPorCodigo(int codigo)
        {
            for(var i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];

                if(trianguloAtual.Codigo == codigo)
                {
                    return trianguloAtual;
                }
            }
            return null;
        }

    }
}
