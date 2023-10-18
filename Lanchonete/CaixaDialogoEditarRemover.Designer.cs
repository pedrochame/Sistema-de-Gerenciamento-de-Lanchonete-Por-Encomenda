namespace Lanchonete
{
    partial class CaixaDialogoEditarRemover
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
            this.label1 = new System.Windows.Forms.Label();
            this.botaoEditar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.botaoFinalizar = new System.Windows.Forms.Button();
            this.botaoDetalhes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha uma opção:";
            // 
            // botaoEditar
            // 
            this.botaoEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.botaoEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botaoEditar.Location = new System.Drawing.Point(93, 57);
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(75, 23);
            this.botaoEditar.TabIndex = 1;
            this.botaoEditar.Text = "EDITAR";
            this.botaoEditar.UseVisualStyleBackColor = false;
            this.botaoEditar.Click += new System.EventHandler(this.botaoEditar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "REMOVER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(174, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "VOLTAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // botaoFinalizar
            // 
            this.botaoFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.botaoFinalizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botaoFinalizar.Location = new System.Drawing.Point(93, 86);
            this.botaoFinalizar.Name = "botaoFinalizar";
            this.botaoFinalizar.Size = new System.Drawing.Size(75, 23);
            this.botaoFinalizar.TabIndex = 4;
            this.botaoFinalizar.Text = "FINALIZAR";
            this.botaoFinalizar.UseVisualStyleBackColor = false;
            this.botaoFinalizar.Visible = false;
            this.botaoFinalizar.Click += new System.EventHandler(this.botaoFinalizar_Click);
            // 
            // botaoDetalhes
            // 
            this.botaoDetalhes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.botaoDetalhes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botaoDetalhes.Location = new System.Drawing.Point(93, 28);
            this.botaoDetalhes.Name = "botaoDetalhes";
            this.botaoDetalhes.Size = new System.Drawing.Size(75, 23);
            this.botaoDetalhes.TabIndex = 5;
            this.botaoDetalhes.Text = "DETALHES";
            this.botaoDetalhes.UseVisualStyleBackColor = false;
            this.botaoDetalhes.Visible = false;
            this.botaoDetalhes.Click += new System.EventHandler(this.botaoDetalhes_Click);
            // 
            // CaixaDialogoEditarRemover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 114);
            this.ControlBox = false;
            this.Controls.Add(this.botaoDetalhes);
            this.Controls.Add(this.botaoFinalizar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botaoEditar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CaixaDialogoEditarRemover";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atenção!";
            this.Load += new System.EventHandler(this.CaixaDialogoEditarRemover_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoEditar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button botaoFinalizar;
        private System.Windows.Forms.Button botaoDetalhes;
    }
}