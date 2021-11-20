namespace Fabrica_Sorvete_11901055_Frederico.Ui
{
    partial class FormEntrega
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
            this.dtgListarEntregas = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.txtIDEntrega = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNumTelefone = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.mskNumTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.cmbxTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSabor = new System.Windows.Forms.Label();
            this.cmbxSabor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListarEntregas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgListarEntregas
            // 
            this.dtgListarEntregas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgListarEntregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListarEntregas.Location = new System.Drawing.Point(31, 302);
            this.dtgListarEntregas.Name = "dtgListarEntregas";
            this.dtgListarEntregas.Size = new System.Drawing.Size(552, 239);
            this.dtgListarEntregas.TabIndex = 30;
            this.dtgListarEntregas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListarEntregas_CellClick);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(28, 37);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 29;
            this.lblId.Text = "ID:";
            // 
            // txtIDEntrega
            // 
            this.txtIDEntrega.Location = new System.Drawing.Point(31, 56);
            this.txtIDEntrega.Name = "txtIDEntrega";
            this.txtIDEntrega.Size = new System.Drawing.Size(100, 20);
            this.txtIDEntrega.TabIndex = 28;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(197, 56);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(390, 20);
            this.txtEndereco.TabIndex = 27;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(28, 166);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(81, 13);
            this.lblQuantidade.TabIndex = 25;
            this.lblQuantidade.Text = "QUANTIDADE:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExcluir.Location = new System.Drawing.Point(413, 227);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(174, 52);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEditar.Location = new System.Drawing.Point(230, 227);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(173, 51);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCadastrar.Location = new System.Drawing.Point(31, 227);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(189, 51);
            this.btnCadastrar.TabIndex = 22;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(194, 37);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(186, 13);
            this.lblTipo.TabIndex = 20;
            this.lblTipo.Text = "ENDERECO(CIDADE,BAIRRO,RUA):";
            // 
            // lblNumTelefone
            // 
            this.lblNumTelefone.AutoSize = true;
            this.lblNumTelefone.Location = new System.Drawing.Point(28, 105);
            this.lblNumTelefone.Name = "lblNumTelefone";
            this.lblNumTelefone.Size = new System.Drawing.Size(135, 13);
            this.lblNumTelefone.TabIndex = 19;
            this.lblNumTelefone.Text = "NÚMERO DE TELEFONE:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(194, 104);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 32;
            this.lblCEP.Text = "CEP:";
            // 
            // mskNumTelefone
            // 
            this.mskNumTelefone.Location = new System.Drawing.Point(31, 121);
            this.mskNumTelefone.Mask = "(99)0000-9999";
            this.mskNumTelefone.Name = "mskNumTelefone";
            this.mskNumTelefone.Size = new System.Drawing.Size(132, 20);
            this.mskNumTelefone.TabIndex = 33;
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(197, 120);
            this.mskCEP.Mask = "999999-999";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(62, 20);
            this.mskCEP.TabIndex = 34;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(31, 182);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 35;
            // 
            // cmbxTipo
            // 
            this.cmbxTipo.FormattingEnabled = true;
            this.cmbxTipo.Location = new System.Drawing.Point(301, 119);
            this.cmbxTipo.Name = "cmbxTipo";
            this.cmbxTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbxTipo.TabIndex = 36;
            this.cmbxTipo.SelectedIndexChanged += new System.EventHandler(this.cmbxTipo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "TIPO:";
            // 
            // lblSabor
            // 
            this.lblSabor.AutoSize = true;
            this.lblSabor.Location = new System.Drawing.Point(463, 104);
            this.lblSabor.Name = "lblSabor";
            this.lblSabor.Size = new System.Drawing.Size(47, 13);
            this.lblSabor.TabIndex = 39;
            this.lblSabor.Text = "SABOR:";
            // 
            // cmbxSabor
            // 
            this.cmbxSabor.FormattingEnabled = true;
            this.cmbxSabor.Location = new System.Drawing.Point(466, 119);
            this.cmbxSabor.Name = "cmbxSabor";
            this.cmbxSabor.Size = new System.Drawing.Size(121, 21);
            this.cmbxSabor.TabIndex = 38;
            // 
            // FormEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(620, 580);
            this.Controls.Add(this.lblSabor);
            this.Controls.Add(this.cmbxSabor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxTipo);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.mskCEP);
            this.Controls.Add(this.mskNumTelefone);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.dtgListarEntregas);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtIDEntrega);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNumTelefone);
            this.Name = "FormEntrega";
            this.Text = "FormEntrega";
            this.Load += new System.EventHandler(this.FormEntrega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListarEntregas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgListarEntregas;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtIDEntrega;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNumTelefone;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.MaskedTextBox mskNumTelefone;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.ComboBox cmbxTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSabor;
        private System.Windows.Forms.ComboBox cmbxSabor;
    }
}