namespace Entra21.ExemploListaObjeto
{
    internal class ProdutoServico
    {
        private List<Produto> produtos = new List<Produto>();
        // encapsulamento + tipoRetorno + NomeMetodo(parametor)
        public void Adicionar(string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade) 
        {
            // Instanciar um objeto da classe Produto
            Produto produto = new Produto();

            // Atribuir valor para as Propriedades com os dados passados como paramétro
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Localizacao = localizacao;
            produto.Quantidade = quantidade;

            // Adicionar o produto instaciado na lista de produtos
            produtos.Add(produto);
        }
        public void Editar() { }
        public void Apagar() { }

        public List<Produto> ObterTodos()
        {
            return produtos;
        }
        public Produto obterPorCodigo()
        {
            return null;
        }
    }
}
