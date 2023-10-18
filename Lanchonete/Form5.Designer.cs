namespace Lanchonete
{
    partial class EditarCliente2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.botaoVoltarMenu = new System.Windows.Forms.Button();
            this.comboCidades = new System.Windows.Forms.ComboBox();
            this.comboEstados = new System.Windows.Forms.ComboBox();
            this.clienteEndereco = new System.Windows.Forms.TextBox();
            this.clienteEmail = new System.Windows.Forms.TextBox();
            this.clienteNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clienteBairro = new System.Windows.Forms.TextBox();
            this.clienteTel = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lanchonete.Properties.Resources.img_350x350;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(522, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(204, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 43);
            this.button1.TabIndex = 32;
            this.button1.Text = "SALVAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // botaoVoltarMenu
            // 
            this.botaoVoltarMenu.BackColor = System.Drawing.Color.Red;
            this.botaoVoltarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltarMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoVoltarMenu.Location = new System.Drawing.Point(16, 371);
            this.botaoVoltarMenu.Name = "botaoVoltarMenu";
            this.botaoVoltarMenu.Size = new System.Drawing.Size(105, 43);
            this.botaoVoltarMenu.TabIndex = 31;
            this.botaoVoltarMenu.Text = "VOLTAR";
            this.botaoVoltarMenu.UseVisualStyleBackColor = false;
            this.botaoVoltarMenu.Click += new System.EventHandler(this.botaoVoltarMenu_Click);
            // 
            // comboCidades
            // 
            this.comboCidades.Enabled = false;
            this.comboCidades.FormattingEnabled = true;
            this.comboCidades.Location = new System.Drawing.Point(104, 144);
            this.comboCidades.Name = "comboCidades";
            this.comboCidades.Size = new System.Drawing.Size(205, 21);
            this.comboCidades.Sorted = true;
            this.comboCidades.TabIndex = 30;
            this.comboCidades.SelectedIndexChanged += new System.EventHandler(this.comboCidades_SelectedIndexChanged);
            // 
            // comboEstados
            // 
            this.comboEstados.FormattingEnabled = true;
            this.comboEstados.Location = new System.Drawing.Point(104, 104);
            this.comboEstados.Name = "comboEstados";
            this.comboEstados.Size = new System.Drawing.Size(205, 21);
            this.comboEstados.Sorted = true;
            this.comboEstados.TabIndex = 28;
            this.comboEstados.SelectedIndexChanged += new System.EventHandler(this.comboEstados_SelectedIndexChanged);
            // 
            // clienteEndereco
            // 
            this.clienteEndereco.Location = new System.Drawing.Point(104, 231);
            this.clienteEndereco.Name = "clienteEndereco";
            this.clienteEndereco.Size = new System.Drawing.Size(205, 20);
            this.clienteEndereco.TabIndex = 27;
            // 
            // clienteEmail
            // 
            this.clienteEmail.Location = new System.Drawing.Point(104, 321);
            this.clienteEmail.Name = "clienteEmail";
            this.clienteEmail.Size = new System.Drawing.Size(205, 20);
            this.clienteEmail.TabIndex = 25;
            // 
            // clienteNome
            // 
            this.clienteNome.Location = new System.Drawing.Point(104, 64);
            this.clienteNome.Name = "clienteNome";
            this.clienteNome.Size = new System.Drawing.Size(205, 20);
            this.clienteNome.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(11, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Bairro:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(11, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Endereço:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(11, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Telefone:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Email:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cidade:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(11, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Estado:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clienteBairro
            // 
            this.clienteBairro.Location = new System.Drawing.Point(104, 189);
            this.clienteBairro.Name = "clienteBairro";
            this.clienteBairro.Size = new System.Drawing.Size(205, 20);
            this.clienteBairro.TabIndex = 33;
            // 
            // clienteTel
            // 
            this.clienteTel.Location = new System.Drawing.Point(104, 276);
            this.clienteTel.Mask = "(99) 99999-9999";
            this.clienteTel.Name = "clienteTel";
            this.clienteTel.Size = new System.Drawing.Size(205, 20);
            this.clienteTel.TabIndex = 34;
            // 
            // EditarCliente2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 486);
            this.Controls.Add(this.clienteTel);
            this.Controls.Add(this.clienteBairro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botaoVoltarMenu);
            this.Controls.Add(this.comboCidades);
            this.Controls.Add(this.comboEstados);
            this.Controls.Add(this.clienteEndereco);
            this.Controls.Add(this.clienteEmail);
            this.Controls.Add(this.clienteNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "EditarCliente2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu/Clientes/Editar";
            this.Load += new System.EventHandler(this.EditarCliente2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botaoVoltarMenu;
        private System.Windows.Forms.ComboBox comboCidades;
        private System.Windows.Forms.ComboBox comboEstados;
        private System.Windows.Forms.TextBox clienteEndereco;
        private System.Windows.Forms.TextBox clienteEmail;
        private System.Windows.Forms.TextBox clienteNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clienteBairro;
        private System.Windows.Forms.MaskedTextBox clienteTel;
    }
}