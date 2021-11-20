namespace Fabrica_Sorvete_11901055_Frederico.Ui
{
    partial class FormSorvetes
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
            this.lblSabor = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtSabor = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dtgListarSorvetes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListarSorvetes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSabor
            // 
            this.lblSabor.AutoSize = true;
            this.lblSabor.Location = new System.Drawing.Point(437, 39);
            this.lblSabor.Name = "lblSabor";
            this.lblSabor.Size = new System.Drawing.Size(46, 15);
            this.lblSabor.TabIndex = 1;
            this.lblSabor.Text = "SABOR:";
            this.lblSabor.Click += new System.EventHandler(this.lblSabor_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(204, 39);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(188, 15);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "TIPO(EX: CASQUINHA, MILKSHAKE):";
            this.lblTipo.Click += new System.EventHandler(this.lblTipo_Click);
            // 
            // txtSabor
            // 
            this.txtSabor.Location = new System.Drawing.Point(438, 58);
            this.txtSabor.Name = "txtSabor";
            this.txtSabor.Size = new System.Drawing.Size(159, 22);
            this.txtSabor.TabIndex = 4;
            this.txtSabor.TextChanged += new System.EventHandler(this.txtSabor_TextChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCadastrar.Location = new System.Drawing.Point(41, 171);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(193, 51);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEditar.Location = new System.Drawing.Point(240, 171);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(177, 51);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExcluir.Location = new System.Drawing.Point(423, 171);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(178, 52);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(38, 105);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(46, 15);
            this.lblPreco.TabIndex = 12;
            this.lblPreco.Text = "PREÇO:";
            this.lblPreco.Click += new System.EventHandler(this.lblPreco_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(41, 123);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 22);
            this.txtPreco.TabIndex = 13;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(207, 58);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(169, 22);
            this.txtTipo.TabIndex = 15;
            this.txtTipo.TextChanged += new System.EventHandler(this.txtTipo_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(41, 58);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 16;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(38, 39);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 15);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "ID:";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // dtgListarSorvetes
            // 
            this.dtgListarSorvetes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgListarSorvetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListarSorvetes.Location = new System.Drawing.Point(41, 246);
            this.dtgListarSorvetes.Name = "dtgListarSorvetes";
            this.dtgListarSorvetes.Size = new System.Drawing.Size(556, 239);
            this.dtgListarSorvetes.TabIndex = 18;
            this.dtgListarSorvetes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListarSorvetes_CellClick);
            this.dtgListarSorvetes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListarSorvetes_CellContentClick);
            // 
            // FormSorvetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(648, 497);
            this.Controls.Add(this.dtgListarSorvetes);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtSabor);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblSabor);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormSorvetes";
            this.Text = "FormSorvetes";
            this.Load += new System.EventHandler(this.FormSorvetes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListarSorvetes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSabor;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtSabor;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dtgListarSorvetes;
    }
}