using SB1.Apontamentos.Controller;
using System.ComponentModel;
using SB1.Apontamentos.Model;
using System;
using System.Windows.Forms;


namespace SB1.Apontamentos.View
{
    public partial class frConsultarColaboradorView : Form
    {
        public frConsultarColaboradorView()
        {
            InitializeComponent();
            cbTipoColab.Text = "Todos";
        }

        private void Consultar(int codigo, string usuario, string tipoColaborador)
        {
            try
            {
                if (tipoColaborador == "Pessoa Física")
                {
                    tipoColaborador = "PF";
                }
                else if (tipoColaborador == "Pessoa Jurídica")
                {
                    tipoColaborador = "PJ";
                }
                else if (tipoColaborador == "Todos")
                {
                    tipoColaborador = "";
                }

                BindingSource bindigSourceColaborador;
                if (codigo > 0)
                {
                    bindigSourceColaborador = CadastroColaboradorController.ConsultarColab(codigo, usuario);
                }
                else
                {
                    bindigSourceColaborador = CadastroColaboradorController.ConsultarColab(null, usuario);
                }
                if (bindigSourceColaborador.Count != 0)
                {
                    dgColaborador.DataSource = bindigSourceColaborador;
                }
                else
                {
                    dgColaborador.Rows.Clear();
                }

            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao consultar. Erro: " + ex.Message;
                string titulo = "Erro";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txId.Text))
                {
                    Consultar(0, txId.Text, txUsuario.Text);
                }
                else
                {
                    Consultar(Convert.ToInt32(txId.Text), null, null);
                }
            }
            catch (Exception ex)
            {
                string mensagem = "Erro Converter o codigo. Erro: " + ex.Message;
                string titulo = "Erro";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
    }
}
