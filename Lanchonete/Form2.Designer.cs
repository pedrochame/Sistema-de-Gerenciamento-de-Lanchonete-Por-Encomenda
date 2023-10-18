namespace Lanchonete
{
    partial class MenuClientes
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
            this.botaoAddCliente = new System.Windows.Forms.Button();
            this.botaoEditarCliente = new System.Windows.Forms.Button();
            this.botaoExcluirCliente = new System.Windows.Forms.Button();
            this.botaoVoltarMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botaoAddCliente
            // 
            this.botaoAddCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.botaoAddCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoAddCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoAddCliente.Location = new System.Drawing.Point(12, 64);
            this.botaoAddCliente.Name = "botaoAddCliente";
            this.botaoAddCliente.Size = new System.Drawing.Size(127, 69);
            this.botaoAddCliente.TabIndex = 2;
            this.botaoAddCliente.Text = "ADICIONAR";
            this.botaoAddCliente.UseVisualStyleBackColor = false;
            this.botaoAddCliente.Click += new System.EventHandler(this.botaoAddCliente_Click);
            // 
            // botaoEditarCliente
            // 
            this.botaoEditarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.botaoEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoEditarCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoEditarCliente.Location = new System.Drawing.Point(12, 158);
            this.botaoEditarCliente.Name = "botaoEditarCliente";
            this.botaoEditarCliente.Size = new System.Drawing.Size(127, 69);
            this.botaoEditarCliente.TabIndex = 3;
            this.botaoEditarCliente.Text = "EDITAR";
            this.botaoEditarCliente.UseVisualStyleBackColor = false;
            this.botaoEditarCliente.Click += new System.EventHandler(this.botaoEditarCliente_Click);
            // 
            // botaoExcluirCliente
            // 
            this.botaoExcluirCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.botaoExcluirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoExcluirCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoExcluirCliente.Location = new System.Drawing.Point(12, 249);
            this.botaoExcluirCliente.Name = "botaoExcluirCliente";
            this.botaoExcluirCliente.Size = new System.Drawing.Size(127, 69);
            this.botaoExcluirCliente.TabIndex = 4;
            this.botaoExcluirCliente.Text = "EXCLUIR";
            this.botaoExcluirCliente.UseVisualStyleBackColor = false;
            // 
            // botaoVoltarMenu
            // 
            this.botaoVoltarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.botaoVoltarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltarMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoVoltarMenu.Location = new System.Drawing.Point(12, 345);
            this.botaoVoltarMenu.Name = "botaoVoltarMenu";
            this.botaoVoltarMenu.Size = new System.Drawing.Size(127, 69);
            this.botaoVoltarMenu.TabIndex = 5;
            this.botaoVoltarMenu.Text = "VOLTAR";
            this.botaoVoltarMenu.UseVisualStyleBackColor = false;
            this.botaoVoltarMenu.Click += new System.EventHandler(this.botaoVoltarMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lanchonete.Properties.Resources.img_350x350;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(522, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MenuClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 486);
            this.Controls.Add(this.botaoVoltarMenu);
            this.Controls.Add(this.botaoExcluirCliente);
            this.Controls.Add(this.botaoEditarCliente);
            this.Controls.Add(this.botaoAddCliente);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "MenuClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu/Clientes";
            this.Load += new System.EventHandler(this.MenuClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botaoAddCliente;
        private System.Windows.Forms.Button botaoEditarCliente;
        private System.Windows.Forms.Button botaoExcluirCliente;
        private System.Windows.Forms.Button botaoVoltarMenu;
    }
}