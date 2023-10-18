namespace Lanchonete
{
    partial class EditarProduto
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
            this.descProduto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.botaoVoltarMenu = new System.Windows.Forms.Button();
            this.comboTipos = new System.Windows.Forms.ComboBox();
            this.valorProduto = new System.Windows.Forms.TextBox();
            this.nomeProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botaoNovoTipo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // descProduto
            // 
            this.descProduto.Location = new System.Drawing.Point(105, 108);
            this.descProduto.Name = "descProduto";
            this.descProduto.Size = new System.Drawing.Size(205, 20);
            this.descProduto.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(205, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 43);
            this.button1.TabIndex = 49;
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
            this.botaoVoltarMenu.TabIndex = 48;
            this.botaoVoltarMenu.Text = "VOLTAR";
            this.botaoVoltarMenu.UseVisualStyleBackColor = false;
            this.botaoVoltarMenu.Click += new System.EventHandler(this.botaoVoltarMenu_Click);
            // 
            // comboTipos
            // 
            this.comboTipos.FormattingEnabled = true;
            this.comboTipos.Location = new System.Drawing.Point(105, 195);
            this.comboTipos.Name = "comboTipos";
            this.comboTipos.Size = new System.Drawing.Size(159, 21);
            this.comboTipos.Sorted = true;
            this.comboTipos.TabIndex = 47;
            // 
            // valorProduto
            // 
            this.valorProduto.Location = new System.Drawing.Point(105, 148);
            this.valorProduto.Name = "valorProduto";
            this.valorProduto.Size = new System.Drawing.Size(205, 20);
            this.valorProduto.TabIndex = 45;
            this.valorProduto.TextChanged += new System.EventHandler(this.valorProduto_TextChanged);
            // 
            // nomeProduto
            // 
            this.nomeProduto.Location = new System.Drawing.Point(105, 68);
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.Size = new System.Drawing.Size(205, 20);
            this.nomeProduto.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(12, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Tipo:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(13, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Valor:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Descrição:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lanchonete.Properties.Resources.img_350x350;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(523, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // botaoNovoTipo
            // 
            this.botaoNovoTipo.BackColor = System.Drawing.Color.Black;
            this.botaoNovoTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoNovoTipo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoNovoTipo.Location = new System.Drawing.Point(270, 196);
            this.botaoNovoTipo.Name = "botaoNovoTipo";
            this.botaoNovoTipo.Size = new System.Drawing.Size(40, 20);
            this.botaoNovoTipo.TabIndex = 58;
            this.botaoNovoTipo.Text = "+";
            this.botaoNovoTipo.UseVisualStyleBackColor = false;
            this.botaoNovoTipo.Click += new System.EventHandler(this.botaoNovoTipo_Click);
            // 
            // EditarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 486);
            this.Controls.Add(this.botaoNovoTipo);
            this.Controls.Add(this.descProduto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botaoVoltarMenu);
            this.Controls.Add(this.comboTipos);
            this.Controls.Add(this.valorProduto);
            this.Controls.Add(this.nomeProduto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "EditarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu/Produtos/Editar";
            this.Load += new System.EventHandler(this.EditarProduto_Load);
            this.EnabledChanged += new System.EventHandler(this.OnEnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descProduto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botaoVoltarMenu;
        private System.Windows.Forms.ComboBox comboTipos;
        private System.Windows.Forms.TextBox valorProduto;
        private System.Windows.Forms.TextBox nomeProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botaoNovoTipo;
    }
}