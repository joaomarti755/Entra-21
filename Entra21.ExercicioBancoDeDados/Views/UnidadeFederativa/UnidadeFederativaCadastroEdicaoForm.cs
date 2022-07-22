using Entra21.ExercicioBancoDeDados.Models;
using Entra21.ExercicioBancoDeDados.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.ExercicioBancoDeDados.Views.UnidadesFederativas
{
    public partial class UnidadeFederativaCadastroEdicaoForm : Form
    {
        private int idEdicao = -1;

        public UnidadeFederativaCadastroEdicaoForm()
        {
            InitializeComponent();
        }

        public UnidadeFederativaCadastroEdicaoForm(UnidadeFederativa unidadeFederativa) : this()
        {
            idEdicao = unidadeFederativa.Id;

            textBoxNome.Text = unidadeFederativa.Nome;
            textBoxSigla.Text = unidadeFederativa.Sigla;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var sigla = textBoxSigla.Text.Trim();

            var unidadeFederativa = new UnidadeFederativa();
            unidadeFederativa.Nome = nome;
            unidadeFederativa.Sigla = sigla;

            var unidadeFederativaService = new UnidadeFederativaService();

            if (idEdicao == -1)
            {
                unidadeFederativaService.Cadastrar(unidadeFederativa);

                MessageBox.Show("Unidade Federativa cadastrada com sucesso");

                Close();

                return;
            }

            unidadeFederativa.Id = idEdicao;
            unidadeFederativaService.Editar(unidadeFederativa);

            MessageBox.Show("Tipo de personagem alterado com sucesso!!");

            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
