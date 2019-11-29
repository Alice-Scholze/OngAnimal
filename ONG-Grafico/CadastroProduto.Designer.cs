namespace ONG_Grafico
{
    partial class CadastroProduto
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
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.rbMedicamento = new System.Windows.Forms.RadioButton();
			this.rbHigiene = new System.Windows.Forms.RadioButton();
			this.rbAlimento = new System.Windows.Forms.RadioButton();
			this.rbOutro = new System.Windows.Forms.RadioButton();
			this.gbTipo = new System.Windows.Forms.GroupBox();
			this.tbCodigo = new System.Windows.Forms.TextBox();
			this.tbTamanho = new System.Windows.Forms.TextBox();
			this.tbNome = new System.Windows.Forms.TextBox();
			this.tbOutro = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbObservacao = new System.Windows.Forms.TextBox();
			this.btConfirmar = new System.Windows.Forms.Button();
			this.btCancelar = new System.Windows.Forms.Button();
			this.gbTipo.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Codigo:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nome:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(252, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Tamanho";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(252, 108);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(228, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Caso marque a opção \'Outro\' descreva abaixo:";
			// 
			// rbMedicamento
			// 
			this.rbMedicamento.AutoSize = true;
			this.rbMedicamento.Location = new System.Drawing.Point(11, 19);
			this.rbMedicamento.Name = "rbMedicamento";
			this.rbMedicamento.Size = new System.Drawing.Size(89, 17);
			this.rbMedicamento.TabIndex = 5;
			this.rbMedicamento.TabStop = true;
			this.rbMedicamento.Text = "Medicamento";
			this.rbMedicamento.UseVisualStyleBackColor = true;
			// 
			// rbHigiene
			// 
			this.rbHigiene.AutoSize = true;
			this.rbHigiene.Location = new System.Drawing.Point(123, 19);
			this.rbHigiene.Name = "rbHigiene";
			this.rbHigiene.Size = new System.Drawing.Size(61, 17);
			this.rbHigiene.TabIndex = 6;
			this.rbHigiene.TabStop = true;
			this.rbHigiene.Text = "Higiene";
			this.rbHigiene.UseVisualStyleBackColor = true;
			// 
			// rbAlimento
			// 
			this.rbAlimento.AutoSize = true;
			this.rbAlimento.Location = new System.Drawing.Point(11, 59);
			this.rbAlimento.Name = "rbAlimento";
			this.rbAlimento.Size = new System.Drawing.Size(65, 17);
			this.rbAlimento.TabIndex = 7;
			this.rbAlimento.TabStop = true;
			this.rbAlimento.Text = "Alimento";
			this.rbAlimento.UseVisualStyleBackColor = true;
			// 
			// rbOutro
			// 
			this.rbOutro.AutoSize = true;
			this.rbOutro.Location = new System.Drawing.Point(123, 59);
			this.rbOutro.Name = "rbOutro";
			this.rbOutro.Size = new System.Drawing.Size(51, 17);
			this.rbOutro.TabIndex = 8;
			this.rbOutro.TabStop = true;
			this.rbOutro.Text = "Outro";
			this.rbOutro.UseVisualStyleBackColor = true;
			// 
			// gbTipo
			// 
			this.gbTipo.Controls.Add(this.rbHigiene);
			this.gbTipo.Controls.Add(this.rbOutro);
			this.gbTipo.Controls.Add(this.rbMedicamento);
			this.gbTipo.Controls.Add(this.rbAlimento);
			this.gbTipo.Location = new System.Drawing.Point(30, 108);
			this.gbTipo.Name = "gbTipo";
			this.gbTipo.Size = new System.Drawing.Size(200, 100);
			this.gbTipo.TabIndex = 9;
			this.gbTipo.TabStop = false;
			this.gbTipo.Text = "Tipo";
			// 
			// tbCodigo
			// 
			this.tbCodigo.Enabled = false;
			this.tbCodigo.Location = new System.Drawing.Point(76, 23);
			this.tbCodigo.Name = "tbCodigo";
			this.tbCodigo.Size = new System.Drawing.Size(170, 20);
			this.tbCodigo.TabIndex = 10;
			// 
			// tbTamanho
			// 
			this.tbTamanho.Location = new System.Drawing.Point(310, 23);
			this.tbTamanho.Name = "tbTamanho";
			this.tbTamanho.Size = new System.Drawing.Size(170, 20);
			this.tbTamanho.TabIndex = 11;
			// 
			// tbNome
			// 
			this.tbNome.Location = new System.Drawing.Point(76, 62);
			this.tbNome.Name = "tbNome";
			this.tbNome.Size = new System.Drawing.Size(404, 20);
			this.tbNome.TabIndex = 12;
			// 
			// tbOutro
			// 
			this.tbOutro.Location = new System.Drawing.Point(255, 136);
			this.tbOutro.Multiline = true;
			this.tbOutro.Name = "tbOutro";
			this.tbOutro.Size = new System.Drawing.Size(225, 72);
			this.tbOutro.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 230);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Observação:";
			// 
			// tbObservacao
			// 
			this.tbObservacao.Location = new System.Drawing.Point(110, 230);
			this.tbObservacao.Multiline = true;
			this.tbObservacao.Name = "tbObservacao";
			this.tbObservacao.Size = new System.Drawing.Size(370, 72);
			this.tbObservacao.TabIndex = 15;
			// 
			// btConfirmar
			// 
			this.btConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btConfirmar.Location = new System.Drawing.Point(297, 324);
			this.btConfirmar.Name = "btConfirmar";
			this.btConfirmar.Size = new System.Drawing.Size(75, 23);
			this.btConfirmar.TabIndex = 51;
			this.btConfirmar.Text = "Confirmar";
			this.btConfirmar.UseVisualStyleBackColor = true;
			this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
			// 
			// btCancelar
			// 
			this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btCancelar.Location = new System.Drawing.Point(405, 324);
			this.btCancelar.Name = "btCancelar";
			this.btCancelar.Size = new System.Drawing.Size(75, 23);
			this.btCancelar.TabIndex = 50;
			this.btCancelar.Text = "Cancelar";
			this.btCancelar.UseVisualStyleBackColor = true;
			this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
			// 
			// CadastroProduto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 359);
			this.Controls.Add(this.btConfirmar);
			this.Controls.Add(this.btCancelar);
			this.Controls.Add(this.tbObservacao);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbOutro);
			this.Controls.Add(this.tbNome);
			this.Controls.Add(this.tbTamanho);
			this.Controls.Add(this.tbCodigo);
			this.Controls.Add(this.gbTipo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "CadastroProduto";
			this.Text = "Produto";
			this.Load += new System.EventHandler(this.CadastroProduto_Load);
			this.gbTipo.ResumeLayout(false);
			this.gbTipo.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbMedicamento;
        private System.Windows.Forms.RadioButton rbHigiene;
        private System.Windows.Forms.RadioButton rbAlimento;
        private System.Windows.Forms.RadioButton rbOutro;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbTamanho;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbOutro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbObservacao;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Button btCancelar;
    }
}