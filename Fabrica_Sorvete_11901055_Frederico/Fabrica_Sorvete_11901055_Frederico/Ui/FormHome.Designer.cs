namespace Fabrica_Sorvete_11901055_Frederico.Ui
{
    partial class FormHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarSorvetesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarEntregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarSorvetesToolStripMenuItem,
            this.agendarEntregaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarSorvetesToolStripMenuItem
            // 
            this.cadastrarSorvetesToolStripMenuItem.Name = "cadastrarSorvetesToolStripMenuItem";
            this.cadastrarSorvetesToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.cadastrarSorvetesToolStripMenuItem.Text = "Cadastrar Sorvetes";
            this.cadastrarSorvetesToolStripMenuItem.Click += new System.EventHandler(this.cadastrarSorvetesToolStripMenuItem_Click);
            // 
            // agendarEntregaToolStripMenuItem
            // 
            this.agendarEntregaToolStripMenuItem.Name = "agendarEntregaToolStripMenuItem";
            this.agendarEntregaToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.agendarEntregaToolStripMenuItem.Text = "Agendar Entrega";
            this.agendarEntregaToolStripMenuItem.Click += new System.EventHandler(this.agendarEntregaToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Captura de tela 2021-11-07 171815.png");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Image = global::Fabrica_Sorvete_11901055_Frederico.Properties.Resources.Captura_de_tela_2021_11_07_171815;
            this.button1.Location = new System.Drawing.Point(0, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(800, 400);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarSorvetesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarEntregaToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
    }
}