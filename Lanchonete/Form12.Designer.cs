namespace Lanchonete
{
    partial class MenuPedidos
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
            this.listaPedidos = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClienteEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClienteCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClienteBairro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDataCriacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDataEntrega = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboCidades = new System.Windows.Forms.ComboBox();
            this.comboEstados = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoFiltrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.valorMenorQue = new System.Windows.Forms.TextBox();
            this.valorMaiorQue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtCriacaoInicio = new System.Windows.Forms.DateTimePicker();
            this.dtEntregaFim = new System.Windows.Forms.DateTimePicker();
            this.dtEntregaInicio = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtCriacaoFim = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.clienteNome = new System.Windows.Forms.ComboBox();
            this.clienteBairro = new System.Windows.Forms.ComboBox();
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
            this.botaoCriarTipoProduto.TabIndex = 23;
            this.botaoCriarTipoProduto.Text = "CRIAR";
            this.botaoCriarTipoProduto.UseVisualStyleBackColor = false;
            this.botaoCriarTipoProduto.Click += new System.EventHandler(this.botaoCriarTipoProduto_Click);
            // 
            // botaoVoltarMenu
            // 
            this.botaoVoltarMenu.BackColor = System.Drawing.Color.Red;
            this.botaoVoltarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltarMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoVoltarMenu.Location = new System.Drawing.Point(12, 431);
            this.botaoVoltarMenu.Name = "botaoVoltarMenu";
            this.botaoVoltarMenu.Size = new System.Drawing.Size(105, 43);
            this.botaoVoltarMenu.TabIndex = 22;
            this.botaoVoltarMenu.Text = "VOLTAR";
            this.botaoVoltarMenu.UseVisualStyleBackColor = false;
            this.botaoVoltarMenu.Click += new System.EventHandler(this.botaoVoltarMenu_Click);
            // 
            // listaPedidos
            // 
            this.listaPedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colCliente,
            this.colClienteEstado,
            this.colClienteCidade,
            this.colClienteBairro,
            this.colValor,
            this.colStatus,
            this.colDataCriacao,
            this.colDataEntrega});
            this.listaPedidos.GridLines = true;
            this.listaPedidos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listaPedidos.HideSelection = false;
            this.listaPedidos.Location = new System.Drawing.Point(12, 112);
            this.listaPedidos.MultiSelect = false;
            this.listaPedidos.Name = "listaPedidos";
            this.listaPedidos.Size = new System.Drawing.Size(860, 313);
            this.listaPedidos.TabIndex = 21;
            this.listaPedidos.UseCompatibleStateImageBehavior = false;
            this.listaPedidos.View = System.Windows.Forms.View.Details;
            this.listaPedidos.SelectedIndexChanged += new System.EventHandler(this.listaPedidos_SelectedIndexChanged);
            // 
            // colId
            // 
            this.colId.Text = "Id";
            this.colId.Width = 30;
            // 
            // colCliente
            // 
            this.colCliente.Text = "Cliente";
            this.colCliente.Width = 140;
            // 
            // colClienteEstado
            // 
            this.colClienteEstado.Text = "Estado";
            this.colClienteEstado.Width = 45;
            // 
            // colClienteCidade
            // 
            this.colClienteCidade.Text = "Cidade";
            this.colClienteCidade.Width = 140;
            // 
            // colClienteBairro
            // 
            this.colClienteBairro.Text = "Bairro";
            this.colClienteBairro.Width = 140;
            // 
            // colValor
            // 
            this.colValor.Text = "Valor";
            this.colValor.Width = 68;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            // 
            // colDataCriacao
            // 
            this.colDataCriacao.Text = "Data de Criação";
            this.colDataCriacao.Width = 115;
            // 
            // colDataEntrega
            // 
            this.colDataEntrega.Text = "Data de Entrega";
            this.colDataEntrega.Width = 115;
            // 
            // comboCidades
            // 
            this.comboCidades.Enabled = false;
            this.comboCidades.FormattingEnabled = true;
            this.comboCidades.Location = new System.Drawing.Point(323, 8);
            this.comboCidades.Name = "comboCidades";
            this.comboCidades.Size = new System.Drawing.Size(153, 21);
            this.comboCidades.Sorted = true;
            this.comboCidades.TabIndex = 48;
            this.comboCidades.SelectedIndexChanged += new System.EventHandler(this.comboCidades_SelectedIndexChanged);
            // 
            // comboEstados
            // 
            this.comboEstados.FormattingEnabled = true;
            this.comboEstados.Location = new System.Drawing.Point(88, 36);
            this.comboEstados.Name = "comboEstados";
            this.comboEstados.Size = new System.Drawing.Size(153, 21);
            this.comboEstados.Sorted = true;
            this.comboEstados.TabIndex = 47;
            this.comboEstados.SelectedIndexChanged += new System.EventHandler(this.comboEstados_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(247, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Bairro:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(247, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Cidade:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Estado:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Cliente:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botaoFiltrar
            // 
            this.botaoFiltrar.BackColor = System.Drawing.Color.Blue;
            this.botaoFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoFiltrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoFiltrar.Location = new System.Drawing.Point(767, 63);
            this.botaoFiltrar.Name = "botaoFiltrar";
            this.botaoFiltrar.Size = new System.Drawing.Size(105, 43);
            this.botaoFiltrar.TabIndex = 50;
            this.botaoFiltrar.Text = "FILTRAR";
            this.botaoFiltrar.UseVisualStyleBackColor = false;
            this.botaoFiltrar.Click += new System.EventHandler(this.botaoFiltrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(682, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 72;
            this.label5.Text = "e";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(482, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Valor: Entre";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valorMenorQue
            // 
            this.valorMenorQue.Location = new System.Drawing.Point(707, 8);
            this.valorMenorQue.Name = "valorMenorQue";
            this.valorMenorQue.Size = new System.Drawing.Size(83, 20);
            this.valorMenorQue.TabIndex = 70;
            this.valorMenorQue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valorMenorQue.TextChanged += new System.EventHandler(this.valorMenorQue_TextChanged);
            // 
            // valorMaiorQue
            // 
            this.valorMaiorQue.Location = new System.Drawing.Point(593, 8);
            this.valorMaiorQue.Name = "valorMaiorQue";
            this.valorMaiorQue.Size = new System.Drawing.Size(83, 20);
            this.valorMaiorQue.TabIndex = 69;
            this.valorMaiorQue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valorMaiorQue.TextChanged += new System.EventHandler(this.valorMaiorQue_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(313, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 76;
            this.label6.Text = "e";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(12, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 20);
            this.label8.TabIndex = 75;
            this.label8.Text = "Data de Criação: Entre";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtCriacaoInicio
            // 
            this.dtCriacaoInicio.CustomFormat = "";
            this.dtCriacaoInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCriacaoInicio.Location = new System.Drawing.Point(211, 62);
            this.dtCriacaoInicio.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dtCriacaoInicio.Name = "dtCriacaoInicio";
            this.dtCriacaoInicio.Size = new System.Drawing.Size(96, 20);
            this.dtCriacaoInicio.TabIndex = 77;
            this.dtCriacaoInicio.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtCriacaoInicio.ValueChanged += new System.EventHandler(this.dtCriacaoInicio_ValueChanged);
            // 
            // dtEntregaFim
            // 
            this.dtEntregaFim.CustomFormat = "";
            this.dtEntregaFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEntregaFim.Location = new System.Drawing.Point(338, 86);
            this.dtEntregaFim.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dtEntregaFim.Name = "dtEntregaFim";
            this.dtEntregaFim.Size = new System.Drawing.Size(96, 20);
            this.dtEntregaFim.TabIndex = 82;
            this.dtEntregaFim.Value = new System.DateTime(2023, 10, 11, 0, 0, 0, 0);
            // 
            // dtEntregaInicio
            // 
            this.dtEntregaInicio.CustomFormat = "";
            this.dtEntregaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEntregaInicio.Location = new System.Drawing.Point(211, 86);
            this.dtEntregaInicio.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dtEntregaInicio.Name = "dtEntregaInicio";
            this.dtEntregaInicio.Size = new System.Drawing.Size(98, 20);
            this.dtEntregaInicio.TabIndex = 81;
            this.dtEntregaInicio.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(313, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 20);
            this.label9.TabIndex = 80;
            this.label9.Text = "e";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(12, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 20);
            this.label10.TabIndex = 79;
            this.label10.Text = "Data de Entrega: Entre";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Aberto",
            "Ambos",
            "Finalizado"});
            this.status.Location = new System.Drawing.Point(555, 36);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(95, 21);
            this.status.Sorted = true;
            this.status.TabIndex = 84;
            this.status.SelectedIndexChanged += new System.EventHandler(this.status_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(482, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 83;
            this.label11.Text = "Status:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtCriacaoFim
            // 
            this.dtCriacaoFim.CustomFormat = "";
            this.dtCriacaoFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCriacaoFim.Location = new System.Drawing.Point(338, 62);
            this.dtCriacaoFim.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dtCriacaoFim.Name = "dtCriacaoFim";
            this.dtCriacaoFim.Size = new System.Drawing.Size(96, 20);
            this.dtCriacaoFim.TabIndex = 85;
            this.dtCriacaoFim.Value = new System.DateTime(2023, 10, 11, 0, 0, 0, 0);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(656, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 43);
            this.button2.TabIndex = 86;
            this.button2.Text = "REMOVER FILTROS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // clienteNome
            // 
            this.clienteNome.FormattingEnabled = true;
            this.clienteNome.Location = new System.Drawing.Point(88, 8);
            this.clienteNome.Name = "clienteNome";
            this.clienteNome.Size = new System.Drawing.Size(153, 21);
            this.clienteNome.TabIndex = 87;
            // 
            // clienteBairro
            // 
            this.clienteBairro.Enabled = false;
            this.clienteBairro.FormattingEnabled = true;
            this.clienteBairro.Location = new System.Drawing.Point(323, 36);
            this.clienteBairro.Name = "clienteBairro";
            this.clienteBairro.Size = new System.Drawing.Size(153, 21);
            this.clienteBairro.Sorted = true;
            this.clienteBairro.TabIndex = 88;
            // 
            // exportarExcel
            // 
            this.exportarExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.exportarExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportarExcel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exportarExcel.Location = new System.Drawing.Point(656, 36);
            this.exportarExcel.Name = "exportarExcel";
            this.exportarExcel.Size = new System.Drawing.Size(216, 25);
            this.exportarExcel.TabIndex = 89;
            this.exportarExcel.Text = "EXPORTAR PARA EXCEL";
            this.exportarExcel.UseVisualStyleBackColor = false;
            this.exportarExcel.Click += new System.EventHandler(this.exportarExcel_Click);
            // 
            // MenuPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 486);
            this.Controls.Add(this.exportarExcel);
            this.Controls.Add(this.clienteBairro);
            this.Controls.Add(this.clienteNome);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtCriacaoFim);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtEntregaFim);
            this.Controls.Add(this.dtEntregaInicio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtCriacaoInicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.valorMenorQue);
            this.Controls.Add(this.valorMaiorQue);
            this.Controls.Add(this.botaoFiltrar);
            this.Controls.Add(this.comboCidades);
            this.Controls.Add(this.comboEstados);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoCriarTipoProduto);
            this.Controls.Add(this.botaoVoltarMenu);
            this.Controls.Add(this.listaPedidos);
            this.MaximizeBox = false;
            this.Name = "MenuPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu/Pedidos";
            this.Load += new System.EventHandler(this.MenuPedidos_Load);
            this.EnabledChanged += new System.EventHandler(this.OnEnabledChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoCriarTipoProduto;
        private System.Windows.Forms.Button botaoVoltarMenu;
        private System.Windows.Forms.ListView listaPedidos;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colCliente;
        private System.Windows.Forms.ColumnHeader colValor;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colDataCriacao;
        private System.Windows.Forms.ColumnHeader colDataEntrega;
        private System.Windows.Forms.ColumnHeader colClienteEstado;
        private System.Windows.Forms.ColumnHeader colClienteCidade;
        private System.Windows.Forms.ColumnHeader colClienteBairro;
        private System.Windows.Forms.ComboBox comboCidades;
        private System.Windows.Forms.ComboBox comboEstados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoFiltrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox valorMenorQue;
        private System.Windows.Forms.TextBox valorMaiorQue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtCriacaoInicio;
        private System.Windows.Forms.DateTimePicker dtEntregaFim;
        private System.Windows.Forms.DateTimePicker dtEntregaInicio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtCriacaoFim;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox clienteNome;
        private System.Windows.Forms.ComboBox clienteBairro;
        private System.Windows.Forms.Button exportarExcel;
    }
}