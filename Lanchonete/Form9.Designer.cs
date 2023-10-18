namespace Lanchonete
{
    partial class MenuProdutos
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
            this.button1 = new System.Windows.Forms.Button();
            this.botaoVoltarMenu = new System.Windows.Forms.Button();
            this.listaProdutos = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.botaoFiltrar = new System.Windows.Forms.Button();
            this.valorMaiorQue = new System.Windows.Forms.TextBox();
            this.comboTipos = new System.Windows.Forms.ComboBox();
            this.descProduto = new System.Windows.Forms.TextBox();
            this.nomeProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.valorMenorQue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.exportarExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(767, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 43);
            this.button1.TabIndex = 20;
            this.button1.Text = "CRIAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // botaoVoltarMenu
            // 
            this.botaoVoltarMenu.BackColor = System.Drawing.Color.Red;
            this.botaoVoltarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltarMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoVoltarMenu.Location = new System.Drawing.Point(12, 431);
            this.botaoVoltarMenu.Name = "botaoVoltarMenu";
            this.botaoVoltarMenu.Size = new System.Drawing.Size(105, 43);
            this.botaoVoltarMenu.TabIndex = 19;
            this.botaoVoltarMenu.Text = "VOLTAR";
            this.botaoVoltarMenu.UseVisualStyleBackColor = false;
            this.botaoVoltarMenu.Click += new System.EventHandler(this.botaoVoltarMenu_Click);
            // 
            // listaProdutos
            // 
            this.listaProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colNome,
            this.colDescricao,
            this.colValor,
            this.colTipo});
            this.listaProdutos.GridLines = true;
            this.listaProdutos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listaProdutos.HideSelection = false;
            this.listaProdutos.Location = new System.Drawing.Point(12, 85);
            this.listaProdutos.MultiSelect = false;
            this.listaProdutos.Name = "listaProdutos";
            this.listaProdutos.Size = new System.Drawing.Size(860, 340);
            this.listaProdutos.TabIndex = 18;
            this.listaProdutos.UseCompatibleStateImageBehavior = false;
            this.listaProdutos.View = System.Windows.Forms.View.Details;
            this.listaProdutos.SelectedIndexChanged += new System.EventHandler(this.listaProdutos_SelectedIndexChanged);
            // 
            // colId
            // 
            this.colId.Text = "Id";
            this.colId.Width = 30;
            // 
            // colNome
            // 
            this.colNome.Text = "Nome";
            this.colNome.Width = 200;
            // 
            // colDescricao
            // 
            this.colDescricao.Text = "Descrição";
            this.colDescricao.Width = 450;
            // 
            // colValor
            // 
            this.colValor.Text = "Valor";
            this.colValor.Width = 70;
            // 
            // colTipo
            // 
            this.colTipo.Text = "Tipo";
            this.colTipo.Width = 100;
            // 
            // botaoFiltrar
            // 
            this.botaoFiltrar.BackColor = System.Drawing.Color.Blue;
            this.botaoFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoFiltrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoFiltrar.Location = new System.Drawing.Point(767, 36);
            this.botaoFiltrar.Name = "botaoFiltrar";
            this.botaoFiltrar.Size = new System.Drawing.Size(105, 43);
            this.botaoFiltrar.TabIndex = 28;
            this.botaoFiltrar.Text = "FILTRAR";
            this.botaoFiltrar.UseVisualStyleBackColor = false;
            this.botaoFiltrar.Click += new System.EventHandler(this.botaoFiltrar_Click);
            // 
            // valorMaiorQue
            // 
            this.valorMaiorQue.Location = new System.Drawing.Point(426, 9);
            this.valorMaiorQue.Name = "valorMaiorQue";
            this.valorMaiorQue.Size = new System.Drawing.Size(83, 20);
            this.valorMaiorQue.TabIndex = 65;
            this.valorMaiorQue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valorMaiorQue.TextChanged += new System.EventHandler(this.valorMaiorQue_TextChanged);
            // 
            // comboTipos
            // 
            this.comboTipos.FormattingEnabled = true;
            this.comboTipos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboTipos.Location = new System.Drawing.Point(369, 49);
            this.comboTipos.Name = "comboTipos";
            this.comboTipos.Size = new System.Drawing.Size(159, 21);
            this.comboTipos.Sorted = true;
            this.comboTipos.TabIndex = 64;
            // 
            // descProduto
            // 
            this.descProduto.Location = new System.Drawing.Point(104, 49);
            this.descProduto.Name = "descProduto";
            this.descProduto.Size = new System.Drawing.Size(205, 20);
            this.descProduto.TabIndex = 63;
            // 
            // nomeProduto
            // 
            this.nomeProduto.Location = new System.Drawing.Point(104, 9);
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.Size = new System.Drawing.Size(205, 20);
            this.nomeProduto.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(315, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 61;
            this.label7.Text = "Tipo:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Descrição:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valorMenorQue
            // 
            this.valorMenorQue.Location = new System.Drawing.Point(540, 9);
            this.valorMenorQue.Name = "valorMenorQue";
            this.valorMenorQue.Size = new System.Drawing.Size(83, 20);
            this.valorMenorQue.TabIndex = 66;
            this.valorMenorQue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valorMenorQue.TextChanged += new System.EventHandler(this.valorMenorQue_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(315, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 67;
            this.label4.Text = "Valor: Entre";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(515, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "e";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(656, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 43);
            this.button2.TabIndex = 69;
            this.button2.Text = "REMOVER FILTROS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // exportarExcel
            // 
            this.exportarExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.exportarExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportarExcel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exportarExcel.Location = new System.Drawing.Point(656, 9);
            this.exportarExcel.Name = "exportarExcel";
            this.exportarExcel.Size = new System.Drawing.Size(216, 25);
            this.exportarExcel.TabIndex = 70;
            this.exportarExcel.Text = "EXPORTAR PARA EXCEL";
            this.exportarExcel.UseVisualStyleBackColor = false;
            this.exportarExcel.Click += new System.EventHandler(this.exportarExcel_Click);
            // 
            // MenuProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 486);
            this.Controls.Add(this.exportarExcel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.valorMenorQue);
            this.Controls.Add(this.valorMaiorQue);
            this.Controls.Add(this.comboTipos);
            this.Controls.Add(this.descProduto);
            this.Controls.Add(this.nomeProduto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoFiltrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botaoVoltarMenu);
            this.Controls.Add(this.listaProdutos);
            this.MaximizeBox = false;
            this.Name = "MenuProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu/Produtos";
            this.Load += new System.EventHandler(this.MenuProdutos_Load);
            this.EnabledChanged += new System.EventHandler(this.OnEnabledChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botaoVoltarMenu;
        private System.Windows.Forms.ListView listaProdutos;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colNome;
        private System.Windows.Forms.ColumnHeader colDescricao;
        private System.Windows.Forms.ColumnHeader colValor;
        private System.Windows.Forms.ColumnHeader colTipo;
        private System.Windows.Forms.Button botaoFiltrar;
        private System.Windows.Forms.TextBox valorMaiorQue;
        private System.Windows.Forms.ComboBox comboTipos;
        private System.Windows.Forms.TextBox descProduto;
        private System.Windows.Forms.TextBox nomeProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valorMenorQue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button exportarExcel;
    }
}