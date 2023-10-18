namespace Lanchonete
{
    partial class EditarPedido
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
            this.valorTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboClientes = new System.Windows.Forms.ComboBox();
            this.listaItemPedido = new System.Windows.Forms.ListView();
            this.colNomeItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQtdItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValorItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.qtdProduto = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboProdutos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.botaoVoltarMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoNovoProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qtdProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // valorTotal
            // 
            this.valorTotal.Location = new System.Drawing.Point(126, 339);
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.ReadOnly = true;
            this.valorTotal.Size = new System.Drawing.Size(184, 20);
            this.valorTotal.TabIndex = 59;
            this.valorTotal.TextChanged += new System.EventHandler(this.valorTotal_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(13, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Valor Total:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboClientes
            // 
            this.comboClientes.Enabled = false;
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.Location = new System.Drawing.Point(105, 67);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(205, 21);
            this.comboClientes.TabIndex = 57;
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
            this.listaItemPedido.Location = new System.Drawing.Point(17, 147);
            this.listaItemPedido.MultiSelect = false;
            this.listaItemPedido.Name = "listaItemPedido";
            this.listaItemPedido.Size = new System.Drawing.Size(293, 183);
            this.listaItemPedido.TabIndex = 56;
            this.listaItemPedido.UseCompatibleStateImageBehavior = false;
            this.listaItemPedido.View = System.Windows.Forms.View.Details;
            this.listaItemPedido.SelectedIndexChanged += new System.EventHandler(this.listaItemPedido_SelectedIndexChanged);
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(270, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 20);
            this.button2.TabIndex = 55;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // qtdProduto
            // 
            this.qtdProduto.Location = new System.Drawing.Point(126, 121);
            this.qtdProduto.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.qtdProduto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qtdProduto.Name = "qtdProduto";
            this.qtdProduto.Size = new System.Drawing.Size(138, 20);
            this.qtdProduto.TabIndex = 54;
            this.qtdProduto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Quantidade:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboProdutos
            // 
            this.comboProdutos.FormattingEnabled = true;
            this.comboProdutos.Location = new System.Drawing.Point(105, 94);
            this.comboProdutos.Name = "comboProdutos";
            this.comboProdutos.Size = new System.Drawing.Size(205, 21);
            this.comboProdutos.Sorted = true;
            this.comboProdutos.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(13, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Produto:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(205, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 43);
            this.button1.TabIndex = 50;
            this.button1.Text = "SALVAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // botaoVoltarMenu
            // 
            this.botaoVoltarMenu.BackColor = System.Drawing.Color.Red;
            this.botaoVoltarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltarMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoVoltarMenu.Location = new System.Drawing.Point(17, 375);
            this.botaoVoltarMenu.Name = "botaoVoltarMenu";
            this.botaoVoltarMenu.Size = new System.Drawing.Size(105, 43);
            this.botaoVoltarMenu.TabIndex = 49;
            this.botaoVoltarMenu.Text = "VOLTAR";
            this.botaoVoltarMenu.UseVisualStyleBackColor = false;
            this.botaoVoltarMenu.Click += new System.EventHandler(this.botaoVoltarMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lanchonete.Properties.Resources.img_350x350;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(523, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Cliente:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botaoNovoProduto
            // 
            this.botaoNovoProduto.BackColor = System.Drawing.Color.Black;
            this.botaoNovoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoNovoProduto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoNovoProduto.Location = new System.Drawing.Point(316, 95);
            this.botaoNovoProduto.Name = "botaoNovoProduto";
            this.botaoNovoProduto.Size = new System.Drawing.Size(40, 20);
            this.botaoNovoProduto.TabIndex = 60;
            this.botaoNovoProduto.Text = "+";
            this.botaoNovoProduto.UseVisualStyleBackColor = false;
            this.botaoNovoProduto.Click += new System.EventHandler(this.botaoNovoProduto_Click);
            // 
            // EditarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 486);
            this.Controls.Add(this.botaoNovoProduto);
            this.Controls.Add(this.valorTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboClientes);
            this.Controls.Add(this.listaItemPedido);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.qtdProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboProdutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botaoVoltarMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "EditarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu/Pedidos/Editar";
            this.Load += new System.EventHandler(this.Form14_Load);
            this.EnabledChanged += new System.EventHandler(this.OnEnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.qtdProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valorTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboClientes;
        private System.Windows.Forms.ListView listaItemPedido;
        private System.Windows.Forms.ColumnHeader colNomeItem;
        private System.Windows.Forms.ColumnHeader colQtdItem;
        private System.Windows.Forms.ColumnHeader colValorItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown qtdProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboProdutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botaoVoltarMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoNovoProduto;
    }
}