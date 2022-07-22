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
    public partial class UnidadeFederativaListagemForm : Form
    {
        private UnidadeFederativaService unidadeFederativaService;

        public UnidadeFederativaListagemForm()
        {
            InitializeComponent();

            unidadeFederativaService = new UnidadeFederativaService();
        }

        private void UnidadeFederativaListagemForm_Load(object sender, EventArgs e)
        {
            AtualizarRegistrosDataGriedView();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var unidadeFederativaCadastroEdicaoForm =
                new UnidadeFederativaCadastroEdicaoForm();

            unidadeFederativaCadastroEdicaoForm.ShowDialog();

            AtualizarRegistrosDataGriedView();
        }

        private void AtualizarRegistrosDataGriedView()
        {
            var unidadesFederativas = unidadeFederativaService.ObterTodos();

            dataGridView1.Rows.Clear();

            for(int i = 0; i < unidadesFederativas.Count; i++)
            {
                var unidadeFederativa = unidadesFederativas[i];

                dataGridView1.Rows.Add(new object[]
                {
                    unidadeFederativa.Id,
                    unidadeFederativa.Nome,
                    unidadeFederativa.Sigla
                });
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            unidadeFederativaService.Apagar(id);

            AtualizarRegistrosDataGriedView();

            MessageBox.Show("Registro apagado com sucesso");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre alguma unidade federativa");
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione algum registro");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var unidadeFederativa = unidadeFederativaService.ObterPorId(id);

            var unidadeFerderativaForm = new UnidadeFederativaCadastroEdicaoForm
                (unidadeFederativa);
            unidadeFerderativaForm.ShowDialog();

            AtualizarRegistrosDataGriedView();
        }
    }
}
