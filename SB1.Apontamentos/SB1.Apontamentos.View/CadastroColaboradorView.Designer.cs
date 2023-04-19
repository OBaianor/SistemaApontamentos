namespace SB1.Apontamentos.View
{
    partial class frCadastroColaboradorView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frCadastroColaboradorView));
            txId = new TextBox();
            txNome = new TextBox();
            txEmail = new TextBox();
            txUsuario = new TextBox();
            txSenha = new TextBox();
            btSalvar = new Button();
            btCancelar = new Button();
            lbId = new Label();
            lbNome = new Label();
            lbDataNascimento = new Label();
            lbDataInsercao = new Label();
            lbDataAtualizacao = new Label();
            lbTipoColaborador = new Label();
            lbDocumento = new Label();
            lbEmail = new Label();
            lbUsuario = new Label();
            lbSenha = new Label();
            cbTipoColaborador = new ComboBox();
            btCalendario = new Button();
            mcCalendario = new MonthCalendar();
            txDtNascimento = new MaskedTextBox();
            txDtInsercao = new MaskedTextBox();
            txDtAtualizacao = new MaskedTextBox();
            txDocumento = new MaskedTextBox();
            errorProviderSenha = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderSenha).BeginInit();
            SuspendLayout();
            // 
            // txId
            // 
            txId.Enabled = false;
            txId.Location = new Point(20, 28);
            txId.Name = "txId";
            txId.Size = new Size(60, 23);
            txId.TabIndex = 0;
            // 
            // txNome
            // 
            txNome.Location = new Point(86, 28);
            txNome.Name = "txNome";
            txNome.Size = new Size(399, 23);
            txNome.TabIndex = 1;
            // 
            // txEmail
            // 
            txEmail.Location = new Point(20, 163);
            txEmail.Name = "txEmail";
            txEmail.Size = new Size(465, 23);
            txEmail.TabIndex = 7;
            // 
            // txUsuario
            // 
            txUsuario.Location = new Point(20, 207);
            txUsuario.Name = "txUsuario";
            txUsuario.Size = new Size(190, 23);
            txUsuario.TabIndex = 8;
            // 
            // txSenha
            // 
            txSenha.Location = new Point(216, 207);
            txSenha.Name = "txSenha";
            txSenha.Size = new Size(269, 23);
            txSenha.TabIndex = 9;
            txSenha.Validating += txSenha_Validating;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(20, 300);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 10;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(410, 300);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(75, 23);
            btCancelar.TabIndex = 11;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(20, 10);
            lbId.Name = "lbId";
            lbId.Size = new Size(17, 15);
            lbId.TabIndex = 12;
            lbId.Text = "Id";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(86, 10);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 13;
            lbNome.Text = "Nome";
            // 
            // lbDataNascimento
            // 
            lbDataNascimento.AutoSize = true;
            lbDataNascimento.Location = new Point(20, 54);
            lbDataNascimento.Name = "lbDataNascimento";
            lbDataNascimento.Size = new Size(114, 15);
            lbDataNascimento.TabIndex = 14;
            lbDataNascimento.Text = "Data de Nascimento";
            // 
            // lbDataInsercao
            // 
            lbDataInsercao.AutoSize = true;
            lbDataInsercao.Location = new Point(177, 54);
            lbDataInsercao.Name = "lbDataInsercao";
            lbDataInsercao.Size = new Size(94, 15);
            lbDataInsercao.TabIndex = 15;
            lbDataInsercao.Text = "Data de Inserção";
            // 
            // lbDataAtualizacao
            // 
            lbDataAtualizacao.AutoSize = true;
            lbDataAtualizacao.Location = new Point(334, 54);
            lbDataAtualizacao.Name = "lbDataAtualizacao";
            lbDataAtualizacao.Size = new Size(111, 15);
            lbDataAtualizacao.TabIndex = 16;
            lbDataAtualizacao.Text = "Data de Atualização";
            // 
            // lbTipoColaborador
            // 
            lbTipoColaborador.AutoSize = true;
            lbTipoColaborador.Location = new Point(20, 102);
            lbTipoColaborador.Name = "lbTipoColaborador";
            lbTipoColaborador.Size = new Size(116, 15);
            lbTipoColaborador.TabIndex = 17;
            lbTipoColaborador.Text = "Tipo do Colaborador";
            // 
            // lbDocumento
            // 
            lbDocumento.AutoSize = true;
            lbDocumento.Location = new Point(216, 102);
            lbDocumento.Name = "lbDocumento";
            lbDocumento.Size = new Size(70, 15);
            lbDocumento.TabIndex = 18;
            lbDocumento.Text = "Documento";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(20, 147);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(41, 15);
            lbEmail.TabIndex = 19;
            lbEmail.Text = "E-Mail";
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Location = new Point(20, 189);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(47, 15);
            lbUsuario.TabIndex = 20;
            lbUsuario.Text = "Usuário";
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Location = new Point(216, 189);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(39, 15);
            lbSenha.TabIndex = 21;
            lbSenha.Text = "Senha";
            // 
            // cbTipoColaborador
            // 
            cbTipoColaborador.FormattingEnabled = true;
            cbTipoColaborador.Items.AddRange(new object[] { "Pessoa Física", "Pessoa Jurídica" });
            cbTipoColaborador.Location = new Point(20, 120);
            cbTipoColaborador.Name = "cbTipoColaborador";
            cbTipoColaborador.Size = new Size(190, 23);
            cbTipoColaborador.TabIndex = 22;
            cbTipoColaborador.SelectedValueChanged += cbTipoColaborador_SelectedValueChanged;
            // 
            // btCalendario
            // 
            btCalendario.Image = (Image)resources.GetObject("btCalendario.Image");
            btCalendario.Location = new Point(146, 73);
            btCalendario.Name = "btCalendario";
            btCalendario.Size = new Size(25, 23);
            btCalendario.TabIndex = 23;
            btCalendario.UseVisualStyleBackColor = true;
            btCalendario.Click += calendarButton_Click;
            // 
            // mcCalendario
            // 
            mcCalendario.Location = new Point(258, 147);
            mcCalendario.Name = "mcCalendario";
            mcCalendario.TabIndex = 27;
            mcCalendario.Visible = false;
            mcCalendario.DateSelected += mcCalendario_DateSelected;
            // 
            // txDtNascimento
            // 
            txDtNascimento.Location = new Point(20, 74);
            txDtNascimento.Mask = "00/00/0000";
            txDtNascimento.Name = "txDtNascimento";
            txDtNascimento.Size = new Size(120, 23);
            txDtNascimento.TabIndex = 28;
            // 
            // txDtInsercao
            // 
            txDtInsercao.Enabled = false;
            txDtInsercao.Location = new Point(177, 72);
            txDtInsercao.Mask = "00/00/0000 90:00";
            txDtInsercao.Name = "txDtInsercao";
            txDtInsercao.Size = new Size(151, 23);
            txDtInsercao.TabIndex = 29;
            // 
            // txDtAtualizacao
            // 
            txDtAtualizacao.Enabled = false;
            txDtAtualizacao.Location = new Point(334, 73);
            txDtAtualizacao.Mask = "00/00/0000 90:00";
            txDtAtualizacao.Name = "txDtAtualizacao";
            txDtAtualizacao.Size = new Size(151, 23);
            txDtAtualizacao.TabIndex = 30;
            // 
            // txDocumento
            // 
            txDocumento.Location = new Point(216, 120);
            txDocumento.Name = "txDocumento";
            txDocumento.Size = new Size(269, 23);
            txDocumento.TabIndex = 31;
            // 
            // errorProviderSenha
            // 
            errorProviderSenha.ContainerControl = this;
            // 
            // frCadastroColaboradorView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 335);
            Controls.Add(txDocumento);
            Controls.Add(txDtAtualizacao);
            Controls.Add(txDtInsercao);
            Controls.Add(txDtNascimento);
            Controls.Add(mcCalendario);
            Controls.Add(btCalendario);
            Controls.Add(cbTipoColaborador);
            Controls.Add(lbSenha);
            Controls.Add(lbUsuario);
            Controls.Add(lbEmail);
            Controls.Add(lbDocumento);
            Controls.Add(lbTipoColaborador);
            Controls.Add(lbDataAtualizacao);
            Controls.Add(lbDataInsercao);
            Controls.Add(lbDataNascimento);
            Controls.Add(lbNome);
            Controls.Add(lbId);
            Controls.Add(btCancelar);
            Controls.Add(btSalvar);
            Controls.Add(txSenha);
            Controls.Add(txUsuario);
            Controls.Add(txEmail);
            Controls.Add(txNome);
            Controls.Add(txId);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frCadastroColaboradorView";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro Colaborador";
            Click += frCadastroColaboradorView_Click;
            ((System.ComponentModel.ISupportInitialize)errorProviderSenha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txId;
        private TextBox txNome;
        private TextBox txEmail;
        private TextBox txUsuario;
        private TextBox txSenha;
        private Button btSalvar;
        private Button btCancelar;
        private Label lbId;
        private Label lbNome;
        private Label lbDataNascimento;
        private Label lbDataInsercao;
        private Label lbDataAtualizacao;
        private Label lbTipoColaborador;
        private Label lbDocumento;
        private Label lbEmail;
        private Label lbUsuario;
        private Label lbSenha;
        private ComboBox cbTipoColaborador;
        private Button btCalendario;
        private MonthCalendar mcCalendario;
        private MaskedTextBox txDtNascimento;
        private MaskedTextBox txDtInsercao;
        private MaskedTextBox txDtAtualizacao;
        private MaskedTextBox txDocumento;
        private ErrorProvider errorProviderSenha;
    }
}