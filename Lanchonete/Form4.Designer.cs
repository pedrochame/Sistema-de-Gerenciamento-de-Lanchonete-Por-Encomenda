namespace Lanchonete
{
    partial class EditarCliente
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
            this.listaClientesEditar = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBairro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.botaoVoltarMenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboCidades = new System.Windows.Forms.ComboBox();
            this.comboEstados = new System.Windows.Forms.ComboBox();
            this.clienteNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoFiltrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.clienteBairro = new System.Windows.Forms.ComboBox();
            this.exportarExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaClientesEditar
            // 
            this.listaClientesEditar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colNome,
            this.colEstado,
            this.colCidade,
            this.colBairro,
            this.colEnd,
            this.colTel,
            this.colEmail});
            this.listaClientesEditar.GridLines = true;
            this.listaClientesEditar.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listaClientesEditar.HideSelection = false;
            this.listaClientesEditar.Location = new System.Drawing.Point(12, 85);
            this.listaClientesEditar.MultiSelect = false;
            this.listaClientesEditar.Name = "listaClientesEditar";
            this.listaClientesEditar.Size = new System.Drawing.Size(860, 340);
            this.listaClientesEditar.TabIndex = 3;
            this.listaClientesEditar.UseCompatibleStateImageBehavior = false;
            this.listaClientesEditar.View = System.Windows.Forms.View.Details;
            this.listaClientesEditar.SelectedIndexChanged += new System.EventHandler(this.listaClientesEditar_SelectedIndexChanged);
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
            // colEstado
            // 
            this.colEstado.Text = "Estado";
            this.colEstado.Width = 45;
            // 
            // colCidade
            // 
            this.colCidade.Text = "Cidade";
            this.colCidade.Width = 115;
            // 
            // colBairro
            // 
            this.colBairro.Text = "Bairro";
            this.colBairro.Width = 115;
            // 
            // colEnd
            // 
            this.colEnd.Text = "Endereço";
            this.colEnd.Width = 215;
            // 
            // colTel
            // 
            this.colTel.Text = "Telefone";
            this.colTel.Width = 90;
            // 
            // colEmail
            // 
            this.colEmail.Text = "Email";
            this.colEmail.Width = 125;
            // 
            // botaoVoltarMenu
            // 
            this.botaoVoltarMenu.BackColor = System.Drawing.Color.Red;
            this.botaoVoltarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltarMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoVoltarMenu.Location = new System.Drawing.Point(12, 431);
            this.botaoVoltarMenu.Name = "botaoVoltarMenu";
            this.botaoVoltarMenu.Size = new System.Drawing.Size(105, 43);
            this.botaoVoltarMenu.TabIndex = 16;
            this.botaoVoltarMenu.Text = "VOLTAR";
            this.botaoVoltarMenu.UseVisualStyleBackColor = false;
            this.botaoVoltarMenu.Click += new System.EventHandler(this.botaoVoltarMenu_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(767, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 43);
            this.button1.TabIndex = 17;
            this.button1.Text = "CRIAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboCidades
            // 
            this.comboCidades.Enabled = false;
            this.comboCidades.FormattingEnabled = true;
            this.comboCidades.Location = new System.Drawing.Point(391, 9);
            this.comboCidades.Name = "comboCidades";
            this.comboCidades.Size = new System.Drawing.Size(205, 21);
            this.comboCidades.Sorted = true;
            this.comboCidades.TabIndex = 40;
            this.comboCidades.SelectedIndexChanged += new System.EventHandler(this.comboCidades_SelectedIndexChanged);
            // 
            // comboEstados
            // 
            this.comboEstados.FormattingEnabled = true;
            this.comboEstados.Location = new System.Drawing.Point(104, 49);
            this.comboEstados.Name = "comboEstados";
            this.comboEstados.Size = new System.Drawing.Size(205, 21);
            this.comboEstados.Sorted = true;
            this.comboEstados.TabIndex = 39;
            this.comboEstados.SelectedIndexChanged += new System.EventHandler(this.comboEstados_SelectedIndexChanged);
            // 
            // clienteNome
            // 
            this.clienteNome.Location = new System.Drawing.Point(104, 9);
            this.clienteNome.Name = "clienteNome";
            this.clienteNome.Size = new System.Drawing.Size(205, 20);
            this.clienteNome.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(315, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Bairro:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(315, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Cidade:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Estado:";
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
            this.label1.TabIndex = 34;
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
            this.botaoFiltrar.TabIndex = 42;
            this.botaoFiltrar.Text = "FILTRAR";
            this.botaoFiltrar.UseVisualStyleBackColor = false;
            this.botaoFiltrar.Click += new System.EventHandler(this.botaoFiltrar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(656, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 43);
            this.button2.TabIndex = 70;
            this.button2.Text = "REMOVER FILTROS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // clienteBairro
            // 
            this.clienteBairro.Enabled = false;
            this.clienteBairro.FormattingEnabled = true;
            this.clienteBairro.Location = new System.Drawing.Point(391, 49);
            this.clienteBairro.Name = "clienteBairro";
            this.clienteBairro.Size = new System.Drawing.Size(205, 21);
            this.clienteBairro.Sorted = true;
            this.clienteBairro.TabIndex = 71;
            // 
            // exportarExcel
            // 
            this.exportarExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.exportarExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportarExcel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exportarExcel.Location = new System.Drawing.Point(656, 9);
            this.exportarExcel.Name = "exportarExcel";
            this.exportarExcel.Size = new System.Drawing.Size(216, 25);
            this.exportarExcel.TabIndex = 72;
            this.exportarExcel.Text = "EXPORTAR PARA EXCEL";
            this.exportarExcel.UseVisualStyleBackColor = false;
            this.exportarExcel.Click += new System.EventHandler(this.exportarExcel_Click);
            // 
            // EditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 486);
            this.Controls.Add(this.exportarExcel);
            this.Controls.Add(this.clienteBairro);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.botaoFiltrar);
            this.Controls.Add(this.comboCidades);
            this.Controls.Add(this.comboEstados);
            this.Controls.Add(this.clienteNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botaoVoltarMenu);
            this.Controls.Add(this.listaClientesEditar);
            this.MaximizeBox = false;
            this.Name = "EditarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu/Clientes";
            this.Load += new System.EventHandler(this.EditarCliente_Load);
            this.EnabledChanged += new System.EventHandler(this.OnEnabledChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listaClientesEditar;
        private System.Windows.Forms.Button botaoVoltarMenu;
        private System.Windows.Forms.ColumnHeader colNome;
        private System.Windows.Forms.ColumnHeader colEstado;
        private System.Windows.Forms.ColumnHeader colCidade;
        private System.Windows.Forms.ColumnHeader colBairro;
        private System.Windows.Forms.ColumnHeader colEnd;
        private System.Windows.Forms.ColumnHeader colTel;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboCidades;
        private System.Windows.Forms.ComboBox comboEstados;
        private System.Windows.Forms.TextBox clienteNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoFiltrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox clienteBairro;
        private System.Windows.Forms.Button exportarExcel;
    }
}