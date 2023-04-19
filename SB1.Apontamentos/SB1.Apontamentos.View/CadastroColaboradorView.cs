using SB1.Apontamentos.Model;
using SB1.Apontamentos.Controller;
using System.ComponentModel;
using System.Text.RegularExpressions;


namespace SB1.Apontamentos.View
{
    public partial class frCadastroColaboradorView : Form
    {
        public frCadastroColaboradorView()
        {
            InitializeComponent();


        }

        private void DefinirMascaraDocumento()
        {
            try
            {
                if (cbTipoColaborador.Text == "Pessoa Jurídica")
                {
                    txDocumento.Mask = "00.000.000/0000-00";
                    txDocumento.ReadOnly = false;
                }
                else if (cbTipoColaborador.Text == "Pessoa Física")
                {
                    txDocumento.Mask = "000.000.000-00";
                    txDocumento.ReadOnly = false;
                }
            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao atribuir máscara de documento. Erro: " + ex.Message;
                string titulo = "Erro";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }

        private void Gravar()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txNome.Text))
                {
                    throw new Exception("Insira um nome.");
                }
                if (string.IsNullOrWhiteSpace(cbTipoColaborador.Text))
                {
                    throw new Exception("Selecione um tipo de Colaborador.");
                }
                if (string.IsNullOrWhiteSpace(txDtNascimento.Text))
                {
                    throw new Exception("Insira a data de nascimento.");
                }
                if (string.IsNullOrWhiteSpace(txEmail.Text))
                {
                    throw new Exception("Insira um E-Mail válido.");
                }
                if (string.IsNullOrWhiteSpace(txUsuario.Text))
                {
                    throw new Exception("Insira o nome para usuário.");
                }
                if (string.IsNullOrWhiteSpace(txSenha.Text))
                {
                    throw new Exception("Insira uma senha.");
                }
                if (string.IsNullOrWhiteSpace(txDocumento.Text) || txDocumento.Equals("   ,   ,   -") || txDocumento.Equals("  ,   ,   /    -"))
                {
                    throw new Exception("Insira um documento.");
                }

                CadastroColaborador cadastroColaborador = new CadastroColaborador();
                cadastroColaborador.Nome = txNome.Text;
                cadastroColaborador.Id = !string.IsNullOrEmpty(txId.Text) ? Convert.ToInt32(txId.Text) : 0;

                if (cbTipoColaborador.Text == "Pessoa Física")
                {
                    cadastroColaborador.TipoColaborador = "PF";
                }
                else if (cbTipoColaborador.Text == "Pessoa Jurídica")
                {
                    cadastroColaborador.TipoColaborador = "PJ";
                }

                if (cbTipoColaborador.Text == "Pessoa Física")
                {
                    cadastroColaborador.TipoDoc = "CPF";
                }
                else if (cbTipoColaborador.Text == "Pessoa Jurídica")
                {
                    cadastroColaborador.TipoDoc = "CNPJ";
                }

                cadastroColaborador.Doc = txDocumento.Text;
                cadastroColaborador.DtNascimento = Convert.ToDateTime(txDtNascimento.Text);
                cadastroColaborador.DtInsercao = (!txDtInsercao.Text.Equals("  /  /       :")) ? Convert.ToDateTime(txDtInsercao.Text) : DateTime.Now;
                cadastroColaborador.DtAtualizacao = DateTime.Now;
                cadastroColaborador.Email = txEmail.Text;
                cadastroColaborador.Usuario = txUsuario.Text;
                cadastroColaborador.Senha = txSenha.Text;
                cadastroColaborador.Ativo = true;

                if (CadastroColaboradorController.GravarColaborador(cadastroColaborador))
                {
                    txId.Text = cadastroColaborador.Id.ToString();
                    txDtInsercao.Text = cadastroColaborador.DtInsercao.ToString();
                    txDtAtualizacao.Text = cadastroColaborador.DtAtualizacao.ToString();

                    string mensagem = "Sucesso ao gravar Colaborador: " + cadastroColaborador.Id.ToString() + " - " + cadastroColaborador.Nome;
                    string titulo = "Sucesso";
                    MessageBoxButtons botoes = MessageBoxButtons.OK;
                    MessageBoxIcon icone = MessageBoxIcon.Information;
                    MessageBox.Show(mensagem, titulo, botoes, icone);

                }

            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao Gravar o Colaborador. Erro: " + ex.Message;
                string titulo = "Erro";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }

        private void calendarButton_Click(object sender, EventArgs e)
        {
            mcCalendario.Visible = true;
        }

        private void mcCalendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            txDtNascimento.Text = mcCalendario.SelectionStart.ToShortDateString();
            mcCalendario.Visible = false;
        }

        private void frCadastroColaboradorView_Click(object sender, EventArgs e)
        {
            mcCalendario.Visible = false;
        }

        private void cbTipoColaborador_SelectedValueChanged(object sender, EventArgs e)
        {
            DefinirMascaraDocumento();
        }

        private void txSenha_Validating(object sender, CancelEventArgs e)
        {
            string senha = txSenha.Text;

            bool senhaValida = Regex.IsMatch(senha, @"^(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$");

            if (!senhaValida)
            {
                // Exibe uma mensagem de erro ao usuário usando o ErrorProvider
                errorProviderSenha.SetError(txSenha, "A senha deve ter pelo menos 8 caracteres, uma letra maiúscula, um número e um caractere especial.");
                /*e.Cancel = true; // impede que o foco seja removido do TextBox*/
            }
            else
            {
                errorProviderSenha.SetError(txSenha, ""); // remove a mensagem de erro, se houver
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Gravar();
        }
    }
}
