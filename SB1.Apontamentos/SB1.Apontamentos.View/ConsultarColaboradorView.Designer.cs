

namespace SB1.Apontamentos.View
{
    partial class frConsultarColaboradorView
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
            txId = new TextBox();
            txUsuario = new TextBox();
            btConsultar = new Button();
            dgColaborador = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            usuario = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            btAbrir = new Button();
            lbId = new Label();
            lbUsuario = new Label();
            cbTipoColab = new ComboBox();
            lbTipoColab = new Label();
            ((System.ComponentModel.ISupportInitialize)dgColaborador).BeginInit();
            SuspendLayout();
            // 
            // txId
            // 
            txId.Location = new Point(12, 21);
            txId.Name = "txId";
            txId.Size = new Size(66, 23);
            txId.TabIndex = 0;
            // 
            // txUsuario
            // 
            txUsuario.Location = new Point(84, 21);
            txUsuario.Name = "txUsuario";
            txUsuario.Size = new Size(175, 23);
            txUsuario.TabIndex = 1;
            // 
            // btConsultar
            // 
            btConsultar.Location = new Point(419, 21);
            btConsultar.Name = "btConsultar";
            btConsultar.Size = new Size(75, 23);
            btConsultar.TabIndex = 2;
            btConsultar.Text = "Consultar";
            btConsultar.UseVisualStyleBackColor = true;
            btConsultar.Click += btConsultar_Click;
            // 
            // dgColaborador
            // 
            dgColaborador.AllowUserToAddRows = false;
            dgColaborador.AllowUserToDeleteRows = false;
            dgColaborador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgColaborador.Columns.AddRange(new DataGridViewColumn[] { ID, usuario, email });
            dgColaborador.Location = new Point(12, 50);
            dgColaborador.Name = "dgColaborador";
            dgColaborador.ReadOnly = true;
            dgColaborador.RowTemplate.Height = 25;
            dgColaborador.Size = new Size(482, 243);
            dgColaborador.TabIndex = 3;
            // 
            // ID
            // 
            ID.DataPropertyName = "id";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 50;
            // 
            // usuario
            // 
            usuario.DataPropertyName = "usuario";
            usuario.HeaderText = "Usuário";
            usuario.Name = "usuario";
            usuario.ReadOnly = true;
            usuario.Width = 150;
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "E-Mail";
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 239;
            // 
            // btAbrir
            // 
            btAbrir.Location = new Point(12, 299);
            btAbrir.Name = "btAbrir";
            btAbrir.Size = new Size(75, 23);
            btAbrir.TabIndex = 4;
            btAbrir.Text = "Abrir";
            btAbrir.UseVisualStyleBackColor = true;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(12, 3);
            lbId.Name = "lbId";
            lbId.Size = new Size(18, 15);
            lbId.TabIndex = 5;
            lbId.Text = "ID";
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Location = new Point(84, 3);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(47, 15);
            lbUsuario.TabIndex = 6;
            lbUsuario.Text = "Usuário";
            // 
            // cbTipoColab
            // 
            cbTipoColab.FormattingEnabled = true;
            cbTipoColab.Items.AddRange(new object[] { "Pessoa Física", "Pessoa Jurídica", "Todos" });
            cbTipoColab.Location = new Point(265, 21);
            cbTipoColab.Name = "cbTipoColab";
            cbTipoColab.Size = new Size(143, 23);
            cbTipoColab.TabIndex = 7;
            // 
            // lbTipoColab
            // 
            lbTipoColab.AutoSize = true;
            lbTipoColab.Location = new Point(265, 3);
            lbTipoColab.Name = "lbTipoColab";
            lbTipoColab.Size = new Size(99, 15);
            lbTipoColab.TabIndex = 8;
            lbTipoColab.Text = "Tipo Colaborador";
            // 
            // frConsultarColaboradorView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 334);
            Controls.Add(lbTipoColab);
            Controls.Add(cbTipoColab);
            Controls.Add(lbUsuario);
            Controls.Add(lbId);
            Controls.Add(btAbrir);
            Controls.Add(dgColaborador);
            Controls.Add(btConsultar);
            Controls.Add(txUsuario);
            Controls.Add(txId);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frConsultarColaboradorView";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar ";
            ((System.ComponentModel.ISupportInitialize)dgColaborador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txId;
        private TextBox txUsuario;
        private Button btConsultar;
        private DataGridView dgColaborador;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn usuario;
        private DataGridViewTextBoxColumn email;
        private Button btAbrir;
        private Label lbId;
        private Label lbUsuario;
        private ComboBox cbTipoColab;
        private Label lbTipoColab;
    }
}