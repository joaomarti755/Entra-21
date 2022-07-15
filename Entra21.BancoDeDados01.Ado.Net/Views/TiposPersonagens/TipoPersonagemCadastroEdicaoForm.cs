using Entra21.BancoDeDados01.Ado.Net.Models;
using Entra21.BancoDeDados01.Ado.Net.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.BancoDeDados01.Ado.Net.Views.TiposPersonagens
{
    public partial class TipoPersonagemCadastroEdicaoForm : Form
    {
        public TipoPersonagemCadastroEdicaoForm()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var tipo = textBoxTipo.Text.Trim();

            var tipoPersonagem = new TipoPersonagem();
            tipoPersonagem.Tipo = tipo;

            // Instancia do objeto de TipoPersonagemService que permitirá
            // persistir o registro
            var tipoPersoagemService = new TipoPersonagemService();

            // Persistir a informação na tabela de tipos_personagens
            tipoPersoagemService.Cadastrar(tipoPersonagem);

            MessageBox.Show("Tipo de personagem cadastrado com sucesso");
        }
    }
}
