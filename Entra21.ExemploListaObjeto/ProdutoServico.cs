namespace Entra21.ExemploListaObjeto
{
    internal class ProdutoServico
    {
        private List<Produto> produtos = new List<Produto>();

        // Armazenar o código do próximo produto
        private int codigoAtual = 1;

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
            int codigoAtual = 1;

            // Atribuir o código novo para o objeto do produto
            produto.Codigo = codigoAtual;

            // Adicionar 1 no código atual para quando criar um novo produto o produto conter outro código
            codigoAtual = codigoAtual + 1;

            // Adicionar o produto instaciado na lista de produtos
            produtos.Add(produto);
        }
        public bool Editar(int codigoParaAlterar, string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        {
            // Obtém o produto desejado da lista de produto
            Produto produtoParaAlterar = ObterPorCodigo(codigoParaAlterar);

            // Verifica senão foi possível encontrar o produto
            if(produtoParaAlterar == null)
            {
                // Retornar falso pq não existe produto com o código dos parâmetros.
                return false;
            }

            // Atualiza as propriedades (campos) do produto desejado
            produtoParaAlterar.Nome = nome;
            produtoParaAlterar.Localizacao = localizacao;
            produtoParaAlterar.PrecoUnitario = precoUnitario;
            produtoParaAlterar.Quantidade = quantidade;

            // Retornar falso pq não existe produto  com código dos parâmetros
            return false;

        }
        public bool Apagar(int codigo)
        {
            for(int i = 0; i < produtos.Count; i++)
            {
                // Resgatando de uma lista de tipos primitivos
                // int numero = numeros[i];

                //Resgatando de uma lista de objetos
                Produto produto = produtos[i];
                if(produto.Codigo == codigo)
                {
                    // posso remover com o indice do objeto desejado
                    // produtos.RemoverAt(i);

                    // Posso remover com objeto desejado
                    produtos.Remove(produto);
                    // Retorna vardadeiro pq o produto com o código desejado foi removido da lista
                    return true;
                }
            }
            // Retornar falso pq não foi encontrado produto com o código desejado foi removido da lista
            return false;
        }

        public List<Produto> ObterTodos()
        {
            return produtos;
        }
        public Produto ObterPorCodigo(int codigo)
        {
            // Percorrer todos os elementos para encontrar o produto
            // filtrando por código
            for(int i = 0; i < produtos.Count; i++)
            {
                // Obterr o produto da lista de produtos em determinado indice
                var produtoAtual = produtos[i];

                // Verificar se o produto atual da lista percorrida é o desejado
                if(produtoAtual.Codigo == codigo)
                {
                    //Retornar o produto encontrado
                    return produtoAtual;
                }
            }

            // Retorna null, caso não encontre um produto com o código passado como parâmetro
            return null;
        }

        public Produto ObterPorCodigo(int codigo);

        public Produto ObterMenorPrecoUnitario()
        {
            double menorPrecoUnitario = double.MaxValue;
            Produto produtoMenorPrecoUnitario = null;

            // Percorre a lista de produtos para obter o produto com o menor preço unitario
            for(int i = 0;i < produtos.Count; i++)
            {
                // Obtém o produto atual da lista que está sendo percorrida
                Produto produto = produtos[i];

                // Verificar se produto atual possui o menor preço unitário
                if(produto.PrecoUnitario < menorPrecoUnitario)
                {
                    // armazena o preço unitário, pois é o menor preço unitário até o momento
                    menorPrecoUnitario = produto.PrecoUnitario;

                    //armazena p produto para posteriormente saber qual é o produto com o menor preço unitário
                    produtoMenorPrecoUnitario = produto;
                }
            }

            return produtoMenorPrecoUnitario;
        }

        public List<double> ObterTodosPrecos()
        {
            // Criar uma lista de preço totais
            var precos = new List<double>();
            // Percorre todos os produtos
            for(int i = 0; i < produtos.Count; i++)
            {
                //Otém o produto atual da lista de produtos
                var produto = produtos[i];

                // Adiciona o preço total na lista de preços
                precos.Add(produto.CalcularPrecoTotal());
            }

            return precos;
        }

        public List<double> ObterPrecoTotaisFiltrandoPorLocalizacao(ProdutoLocalizacao localizacao)
        {
            //Criar uma lista de preços totais
            var precos = new List<double>();

            for (int i = 0; i < produtos.Count; i++)
            {
                // Criar uma lista de preços totais
                var produto = produtos[i];

                // Percorre todos os produto atual da lista de produtos
                if(produto.Localizacao == localizacao)
                {
                    // Adiciona o preço total do produto atual que foi filtradio por localização
                    precos.Add(produto.CalcularPrecoTotal());
                }
            }

            return precos;
        }

        public List<double> ObterPrecoTotaisDoArmazem()
        {
            // Criar uma lista de preços totais
            var precos = new List<double>();
            
            // Percorre todos os produtos
            for(int i = 0; i < produtos.Count; i++)
            {
                // Obtém o produto atual da lisra de produtos
                var produto = produtos[i];

                //Verifica se a localização do produto atual é Armazem
                if(produto.Localizacao == ProdutoLocalizacao.Armazem)
                {
                    //Adiciona o preço total do produto atual que foi filtrado por armázem
                    precos.Add(produto.CalcularPrecoTotal());
                }
            }

            return precos;
        }

        public double ObterMediaPrecosTotais()
        {
            var SomaPrecoTotais = 0.0;

            // Percorre todos os produtos
            for(int i = 0;i < produtos.Count; i++)
            {
                // Obtém o produto atual da lista de produtos
                var produto = produtos[i];

                // Adiciona o preço total do produto na variável soma de preços totais
                SomaPrecoTotais += SomaPrecoTotais / produto.Count;
            }

            //Calcula a média de acordo com a quantidade de produtos
            var media = SomaPrecoTotais / produtos.Count;

            return media;
        }
    }
}
