namespace Lanchonete
{
    partial class MenuTiposProduto
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
            this.botaoCriarTipoProduto = new System.Windows.Forms.Button();
            this.botaoVoltarMenu = new System.Windows.Forms.Button();
            this.listaTiposProduto = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoFiltrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.exportarExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botaoCriarTipoProduto
            // 
            this.botaoCriarTipoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.botaoCriarTipoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCriarTipoProduto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoCriarTipoProduto.Location = new System.Drawing.Point(767, 431);
            this.botaoCriarTipoProduto.Name = "botaoCriarTipoProduto";
            this.botaoCriarTipoProduto.Size = new System.Drawing.Size(105, 43);
            this.botaoCriarTipoProduto.TabIndex = 20;
            this.botaoCriarTipoProduto.Text = "CRIAR";
            this.botaoCriarTipoProduto.UseVisualStyleBackColor = false;
            this.botaoCriarTipoProduto.Click += new System.EventHandler(this.button1_Click);
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
            // listaTiposProduto
            // 
            this.listaTiposProduto.BackColor = System.Drawing.SystemColors.Window;
            this.listaTiposProduto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colNome});
            this.listaTiposProduto.GridLines = true;
            this.listaTiposProduto.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listaTiposProduto.HideSelection = false;
            this.listaTiposProduto.Location = new System.Drawing.Point(12, 85);
            this.listaTiposProduto.MultiSelect = false;
            this.listaTiposProduto.Name = "listaTiposProduto";
            this.listaTiposProduto.Size = new System.Drawing.Size(860, 340);
            this.listaTiposProduto.TabIndex = 18;
            this.listaTiposProduto.UseCompatibleStateImageBehavior = false;
            this.listaTiposProduto.View = System.Windows.Forms.View.Details;
            this.listaTiposProduto.SelectedIndexChanged += new System.EventHandler(this.listaTiposProduto_SelectedIndexChanged);
            // 
            // colId
            // 
            this.colId.Text = "Id";
            this.colId.Width = 30;
            // 
            // colNome
            // 
            this.colNome.Text = "Nome";
            this.colNome.Width = 115;
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(104, 9);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(205, 20);
            this.nome.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botaoFiltrar
            // 
            this.botaoFiltrar.BackColor = System.Drawing.Color.Blue;
            this.botaoFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoFiltrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoFiltrar.Location = new System.Drawing.Point(767, 36);
            this.botaoFiltrar.Name = "botaoFiltrar";
            this.botaoFiltrar.Size = new System.Drawing.Size(105, 43);
            this.botaoFiltrar.TabIndex = 27;
            this.botaoFiltrar.Text = "FILTRAR";
            this.botaoFiltrar.UseVisualStyleBackColor = false;
            this.botaoFiltrar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(656, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 43);
            this.button1.TabIndex = 28;
            this.button1.Text = "REMOVER FILTROS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // exportarExcel
            // 
            this.exportarExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.exportarExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportarExcel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exportarExcel.Location = new System.Drawing.Point(656, 9);
            this.exportarExcel.Name = "exportarExcel";
            this.exportarExcel.Size = new System.Drawing.Size(216, 25);
            this.exportarExcel.TabIndex = 29;
            this.exportarExcel.Text = "EXPORTAR PARA EXCEL";
            this.exportarExcel.UseVisualStyleBackColor = false;
            this.exportarExcel.Click += new System.EventHandler(this.exportarExcel_Click);
            // 
            // MenuTiposProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 486);
            this.Controls.Add(this.exportarExcel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botaoFiltrar);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoCriarTipoProduto);
            this.Controls.Add(this.botaoVoltarMenu);
            this.Controls.Add(this.listaTiposProduto);
            this.MaximizeBox = false;
            this.Name = "MenuTiposProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu/Tipos de Produto";
            this.Load += new System.EventHandler(this.MenuTiposProduto_Load);
            this.EnabledChanged += new System.EventHandler(this.OnEnabledChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoCriarTipoProduto;
        private System.Windows.Forms.Button botaoVoltarMenu;
        private System.Windows.Forms.ListView listaTiposProduto;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colNome;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoFiltrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exportarExcel;
    }
}