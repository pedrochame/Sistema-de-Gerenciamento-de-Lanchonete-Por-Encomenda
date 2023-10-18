namespace Lanchonete
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botaoProdutos = new System.Windows.Forms.Button();
            this.botaoClientes = new System.Windows.Forms.Button();
            this.botaoPedidos = new System.Windows.Forms.Button();
            this.botaoSairApp = new System.Windows.Forms.Button();
            this.botaoTiposProdutos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botaoProdutos
            // 
            this.botaoProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.botaoProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoProdutos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoProdutos.Location = new System.Drawing.Point(12, 236);
            this.botaoProdutos.Name = "botaoProdutos";
            this.botaoProdutos.Size = new System.Drawing.Size(127, 57);
            this.botaoProdutos.TabIndex = 1;
            this.botaoProdutos.Text = "PRODUTOS";
            this.botaoProdutos.UseVisualStyleBackColor = false;
            this.botaoProdutos.Click += new System.EventHandler(this.botaoProdutos_Click);
            // 
            // botaoClientes
            // 
            this.botaoClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.botaoClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoClientes.Location = new System.Drawing.Point(12, 110);
            this.botaoClientes.Name = "botaoClientes";
            this.botaoClientes.Size = new System.Drawing.Size(127, 57);
            this.botaoClientes.TabIndex = 2;
            this.botaoClientes.Text = "CLIENTES";
            this.botaoClientes.UseVisualStyleBackColor = false;
            this.botaoClientes.Click += new System.EventHandler(this.botaoClientes_Click);
            // 
            // botaoPedidos
            // 
            this.botaoPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.botaoPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoPedidos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoPedidos.Location = new System.Drawing.Point(12, 173);
            this.botaoPedidos.Name = "botaoPedidos";
            this.botaoPedidos.Size = new System.Drawing.Size(127, 57);
            this.botaoPedidos.TabIndex = 3;
            this.botaoPedidos.Text = "PEDIDOS";
            this.botaoPedidos.UseVisualStyleBackColor = false;
            this.botaoPedidos.Click += new System.EventHandler(this.botaoPedidos_Click);
            // 
            // botaoSairApp
            // 
            this.botaoSairApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.botaoSairApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSairApp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoSairApp.Location = new System.Drawing.Point(12, 417);
            this.botaoSairApp.Name = "botaoSairApp";
            this.botaoSairApp.Size = new System.Drawing.Size(127, 57);
            this.botaoSairApp.TabIndex = 4;
            this.botaoSairApp.Text = "SAIR";
            this.botaoSairApp.UseVisualStyleBackColor = false;
            this.botaoSairApp.Click += new System.EventHandler(this.botaoSairApp_Click);
            // 
            // botaoTiposProdutos
            // 
            this.botaoTiposProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.botaoTiposProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoTiposProdutos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoTiposProdutos.Location = new System.Drawing.Point(12, 299);
            this.botaoTiposProdutos.Name = "botaoTiposProdutos";
            this.botaoTiposProdutos.Size = new System.Drawing.Size(127, 57);
            this.botaoTiposProdutos.TabIndex = 5;
            this.botaoTiposProdutos.Text = "TIPOS DE PRODUTO";
            this.botaoTiposProdutos.UseVisualStyleBackColor = false;
            this.botaoTiposProdutos.Click += new System.EventHandler(this.botaoTiposProdutos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lanchonete.Properties.Resources.img_350x350;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(522, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titulo.Location = new System.Drawing.Point(26, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(833, 33);
            this.titulo.TabIndex = 6;
            this.titulo.Text = "Sistema de Gerenciamento de Lanchonete por Encomenda";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 486);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.botaoTiposProdutos);
            this.Controls.Add(this.botaoSairApp);
            this.Controls.Add(this.botaoPedidos);
            this.Controls.Add(this.botaoClientes);
            this.Controls.Add(this.botaoProdutos);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botaoProdutos;
        private System.Windows.Forms.Button botaoClientes;
        private System.Windows.Forms.Button botaoPedidos;
        private System.Windows.Forms.Button botaoSairApp;
        private System.Windows.Forms.Button botaoTiposProdutos;
        private System.Windows.Forms.Label titulo;
    }
}

