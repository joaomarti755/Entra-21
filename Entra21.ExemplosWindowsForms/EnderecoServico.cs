using Entra21.ExemplosWindowsForms.Exemplo01;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWindowsForms
{
    internal class EnderecoServico
    {
        private List<Endereco> enderecos;

        // Construtor:  mais para frente
        public EnderecoServico()
        {
            enderecos = new List<Endereco>();
        }

        //Método Adicionar recebe como parâmetro o objeto do endereço completo do Form(Controller)
        public void Adicionar(Endereco endereco)
        {
            enderecos.Add(endereco);

            SalvarArquivo();
        }

        public void Editar(Endereco enderecoParaAlterar)
        {
            // Percorre a lista de endereços afim de encontrar o enderelço que deve ser alterado
            for (int i = 0; i < enderecos.Count; i++)
            {
                // Obtém o endereço da lista de endereços
                var endereco = enderecos[i];

                // Verifica se o código do endereço percorrido é o mesmo do endereço que deve ser alterado
                if (endereco.Codigo == enderecoParaAlterar.Codigo)
                {
                    // Atualiza campos do endereço encontrado
                    endereco.EnderecoCompleto = enderecoParaAlterar.EnderecoCompleto;
                    endereco.Cep = enderecoParaAlterar.Cep;
                    endereco.Paciente = enderecoParaAlterar.Paciente;

                    SalvarArquivo();

                    return;
                }
            }
        }
        public void Apagar(int codigoParaApagar)
        {
            for (int i = 0; i < enderecos.Count; i++)
            {
                //Obtem o endereço percorrido
                var endereco = enderecos[i];

                if (endereco.Codigo == codigoParaApagar)
                {
                    // Remove o endereço encontrado da lista de endereços
                    enderecos.Remove(endereco);

                    SalvarArquivo();

                    return;
                }
            }
        }

        // Método que permite lista todos os endereços
        public List<Endereco> ObterTodos()
        {
            return enderecos;
        }

        public Endereco ObtemPorCodigo(int codigo)
        {
            //Percorre a lista de endereços afim de encontrar o endereço com o código desejado
            for (int i = 0; i < enderecos.Count; i++)
            {
                // Obtém o endereço percorrido
                var endereco = enderecos[i];

                // Verifica se o endereço contém o códifo desejado
                if (endereco.Codigo == codigo)
                {
                    return endereco;
                }

                // Retorna null pois não encontrou o endereço com o códifo desejado
            }
            return null;
        }

        public void SalvarArquivo()
        {
            var enderecosEmJson = JsonConvert.SerializeObject(enderecos);
            File.WriteAllText("endereco.json", enderecosEmJson);
        }

        public void LerArquivo()
        {
            // Verificar se o endereço não existe
            if (File.Exists("enderecos.json") == false)
                return;
            // Ler o arquivo JSON e converte para uma lista de objetos de endereços
            var enderecosEmJson = File.ReadAllText("endereco.json");
            enderecos = JsonConvert.DeserializeObject<List<Endereco>>(enderecosEmJson);
        }
    }
}

