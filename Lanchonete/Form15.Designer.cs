namespace Lanchonete
{
    partial class VerPedido
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
            this.clienteTel = new System.Windows.Forms.MaskedTextBox();
            this.clienteBairro = new System.Windows.Forms.TextBox();
            this.botaoVoltarMenu = new System.Windows.Forms.Button();
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
            this.valorPedido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listaItemPedido = new System.Windows.Forms.ListView();
            this.colNomeItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQtdItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValorItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clienteEstado = new System.Windows.Forms.TextBox();
            this.clienteCidade = new System.Windows.Forms.TextBox();
            this.dtEntregaPedido = new System.Windows.Forms.TextBox();
            this.dtCriacaoPedido = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.botaoFinalizar = new System.Windows.Forms.Button();
            this.statusPedido = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteTel
            // 
            this.clienteTel.Location = new System.Drawing.Point(667, 229);
            this.clienteTel.Mask = "(99) 99999-9999";
            this.clienteTel.Name = "clienteTel";
            this.clienteTel.ReadOnly = true;
            this.clienteTel.Size = new System.Drawing.Size(205, 20);
            this.clienteTel.TabIndex = 34;
            // 
            // clienteBairro
            // 
            this.clienteBairro.Location = new System.Drawing.Point(667, 163);
            this.clienteBairro.Name = "clienteBairro";
            this.clienteBairro.ReadOnly = true;
            this.clienteBairro.Size = new System.Drawing.Size(205, 20);
            this.clienteBairro.TabIndex = 33;
            // 
            // botaoVoltarMenu
            // 
            this.botaoVoltarMenu.BackColor = System.Drawing.Color.Red;
            this.botaoVoltarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltarMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoVoltarMenu.Location = new System.Drawing.Point(14, 403);
            this.botaoVoltarMenu.Name = "botaoVoltarMenu";
            this.botaoVoltarMenu.Size = new System.Drawing.Size(105, 43);
            this.botaoVoltarMenu.TabIndex = 31;
            this.botaoVoltarMenu.Text = "VOLTAR";
            this.botaoVoltarMenu.UseVisualStyleBackColor = false;
            this.botaoVoltarMenu.Click += new System.EventHandler(this.botaoVoltarMenu_Click);
            // 
            // clienteEndereco
            // 
            this.clienteEndereco.Location = new System.Drawing.Point(667, 196);
            this.clienteEndereco.Name = "clienteEndereco";
            this.clienteEndereco.ReadOnly = true;
            this.clienteEndereco.Size = new System.Drawing.Size(205, 20);
            this.clienteEndereco.TabIndex = 28;
            // 
            // clienteEmail
            // 
            this.clienteEmail.Location = new System.Drawing.Point(667, 264);
            this.clienteEmail.Name = "clienteEmail";
            this.clienteEmail.ReadOnly = true;
            this.clienteEmail.Size = new System.Drawing.Size(205, 20);
            this.clienteEmail.TabIndex = 27;
            // 
            // clienteNome
            // 
            this.clienteNome.Location = new System.Drawing.Point(667, 68);
            this.clienteNome.Name = "clienteNome";
            this.clienteNome.ReadOnly = true;
            this.clienteNome.Size = new System.Drawing.Size(205, 20);
            this.clienteNome.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(599, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Bairro:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(570, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Endereço:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(577, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Telefone:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(603, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Email:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(591, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cidade:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(590, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Estado:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(601, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valorPedido
            // 
            this.valorPedido.Location = new System.Drawing.Point(160, 328);
            this.valorPedido.Name = "valorPedido";
            this.valorPedido.ReadOnly = true;
            this.valorPedido.Size = new System.Drawing.Size(145, 20);
            this.valorPedido.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(56, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Valor Total:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listaItemPedido
            // 
            this.listaItemPedido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNomeItem,
            this.colQtdItem,
            this.colValorItem});
            this.listaItemPedido.GridLines = true;
            this.listaItemPedido.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listaItemPedido.HideSelection = false;
            this.listaItemPedido.Location = new System.Drawing.Point(12, 66);
            this.listaItemPedido.MultiSelect = false;
            this.listaItemPedido.Name = "listaItemPedido";
            this.listaItemPedido.Size = new System.Drawing.Size(293, 183);
            this.listaItemPedido.TabIndex = 47;
            this.listaItemPedido.UseCompatibleStateImageBehavior = false;
            this.listaItemPedido.View = System.Windows.Forms.View.Details;
            // 
            // colNomeItem
            // 
            this.colNomeItem.Text = "Produto";
            this.colNomeItem.Width = 150;
            // 
            // colQtdItem
            // 
            this.colQtdItem.Text = "Qtd.";
            // 
            // colValorItem
            // 
            this.colValorItem.Text = "Valor";
            this.colValorItem.Width = 75;
            // 
            // clienteEstado
            // 
            this.clienteEstado.Location = new System.Drawing.Point(667, 97);
            this.clienteEstado.Name = "clienteEstado";
            this.clienteEstado.ReadOnly = true;
            this.clienteEstado.Size = new System.Drawing.Size(205, 20);
            this.clienteEstado.TabIndex = 50;
            // 
            // clienteCidade
            // 
            this.clienteCidade.Location = new System.Drawing.Point(667, 130);
            this.clienteCidade.Name = "clienteCidade";
            this.clienteCidade.ReadOnly = true;
            this.clienteCidade.Size = new System.Drawing.Size(205, 20);
            this.clienteCidade.TabIndex = 51;
            // 
            // dtEntregaPedido
            // 
            this.dtEntregaPedido.Location = new System.Drawing.Point(160, 295);
            this.dtEntregaPedido.Name = "dtEntregaPedido";
            this.dtEntregaPedido.ReadOnly = true;
            this.dtEntregaPedido.Size = new System.Drawing.Size(145, 20);
            this.dtEntregaPedido.TabIndex = 55;
            // 
            // dtCriacaoPedido
            // 
            this.dtCriacaoPedido.Location = new System.Drawing.Point(160, 262);
            this.dtCriacaoPedido.Name = "dtCriacaoPedido";
            this.dtCriacaoPedido.ReadOnly = true;
            this.dtCriacaoPedido.Size = new System.Drawing.Size(145, 20);
            this.dtCriacaoPedido.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(10, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 20);
            this.label9.TabIndex = 53;
            this.label9.Text = "Data de Entrega:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(10, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 20);
            this.label10.TabIndex = 52;
            this.label10.Text = "Data de Criação:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botaoFinalizar
            // 
            this.botaoFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.botaoFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoFinalizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoFinalizar.Location = new System.Drawing.Point(200, 403);
            this.botaoFinalizar.Name = "botaoFinalizar";
            this.botaoFinalizar.Size = new System.Drawing.Size(105, 43);
            this.botaoFinalizar.TabIndex = 56;
            this.botaoFinalizar.Text = "FINALIZAR";
            this.botaoFinalizar.UseVisualStyleBackColor = false;
            this.botaoFinalizar.Visible = false;
            this.botaoFinalizar.Click += new System.EventHandler(this.botaoFinalizar_Click);
            // 
            // statusPedido
            // 
            this.statusPedido.Location = new System.Drawing.Point(160, 361);
            this.statusPedido.Name = "statusPedido";
            this.statusPedido.ReadOnly = true;
            this.statusPedido.Size = new System.Drawing.Size(145, 20);
            this.statusPedido.TabIndex = 58;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(87, 361);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 57;
            this.label11.Text = "Status:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(656, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 37);
            this.label12.TabIndex = 59;
            this.label12.Text = "Cliente";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(84, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 37);
            this.label13.TabIndex = 60;
            this.label13.Text = "Pedido";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lanchonete.Properties.Resources.img_161x151;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(711, 295);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // VerPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 486);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.statusPedido);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.botaoFinalizar);
            this.Controls.Add(this.dtEntregaPedido);
            this.Controls.Add(this.dtCriacaoPedido);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.clienteCidade);
            this.Controls.Add(this.clienteEstado);
            this.Controls.Add(this.valorPedido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listaItemPedido);
            this.Controls.Add(this.clienteTel);
            this.Controls.Add(this.clienteBairro);
            this.Controls.Add(this.botaoVoltarMenu);
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
            this.Name = "VerPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu/Pedidos/Detalhes";
            this.Load += new System.EventHandler(this.VerPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox clienteTel;
        private System.Windows.Forms.TextBox clienteBairro;
        private System.Windows.Forms.Button botaoVoltarMenu;
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
        private System.Windows.Forms.TextBox valorPedido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listaItemPedido;
        private System.Windows.Forms.ColumnHeader colNomeItem;
        private System.Windows.Forms.ColumnHeader colQtdItem;
        private System.Windows.Forms.ColumnHeader colValorItem;
        private System.Windows.Forms.TextBox clienteEstado;
        private System.Windows.Forms.TextBox clienteCidade;
        private System.Windows.Forms.TextBox dtEntregaPedido;
        private System.Windows.Forms.TextBox dtCriacaoPedido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button botaoFinalizar;
        private System.Windows.Forms.TextBox statusPedido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}