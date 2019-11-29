namespace ONG_Grafico
{
    partial class TelaProcedimento
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAnimal = new System.Windows.Forms.ComboBox();
            this.cbVoluntario = new System.Windows.Forms.ComboBox();
            this.cbServico = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btRemover = new System.Windows.Forms.Button();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.btAdicionarProd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Animal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Voluntário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Serviço:";
            // 
            // cbAnimal
            // 
            this.cbAnimal.FormattingEnabled = true;
            this.cbAnimal.Location = new System.Drawing.Point(89, 67);
            this.cbAnimal.Name = "cbAnimal";
            this.cbAnimal.Size = new System.Drawing.Size(266, 21);
            this.cbAnimal.TabIndex = 6;
            // 
            // cbVoluntario
            // 
            this.cbVoluntario.FormattingEnabled = true;
            this.cbVoluntario.Location = new System.Drawing.Point(89, 112);
            this.cbVoluntario.Name = "cbVoluntario";
            this.cbVoluntario.Size = new System.Drawing.Size(598, 21);
            this.cbVoluntario.TabIndex = 7;
            // 
            // cbServico
            // 
            this.cbServico.FormattingEnabled = true;
            this.cbServico.Location = new System.Drawing.Point(421, 67);
            this.cbServico.Name = "cbServico";
            this.cbServico.Size = new System.Drawing.Size(266, 21);
            this.cbServico.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgProdutos);
            this.groupBox1.Controls.Add(this.btAtualizar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btRemover);
            this.groupBox1.Controls.Add(this.cbProduto);
            this.groupBox1.Controls.Add(this.btAdicionarProd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbQuantidade);
            this.groupBox1.Location = new System.Drawing.Point(29, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 443);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // dgProdutos
            // 
            this.dgProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Location = new System.Drawing.Point(6, 108);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.Size = new System.Drawing.Size(632, 268);
            this.dgProdutos.TabIndex = 15;
            // 
            // btAtualizar
            // 
            this.btAtualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAtualizar.Location = new System.Drawing.Point(413, 396);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btAtualizar.TabIndex = 22;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = false;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Produto";
            // 
            // btRemover
            // 
            this.btRemover.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btRemover.Location = new System.Drawing.Point(508, 396);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(128, 23);
            this.btRemover.TabIndex = 21;
            this.btRemover.Text = "Remover Produto";
            this.btRemover.UseVisualStyleBackColor = false;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // cbProduto
            // 
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(79, 21);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(365, 21);
            this.cbProduto.TabIndex = 9;
            // 
            // btAdicionarProd
            // 
            this.btAdicionarProd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAdicionarProd.Location = new System.Drawing.Point(529, 21);
            this.btAdicionarProd.Name = "btAdicionarProd";
            this.btAdicionarProd.Size = new System.Drawing.Size(109, 66);
            this.btAdicionarProd.TabIndex = 20;
            this.btAdicionarProd.Text = "Adicionar Produto";
            this.btAdicionarProd.UseVisualStyleBackColor = false;
            this.btAdicionarProd.Click += new System.EventHandler(this.btAdicionarProd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Quantidade:";
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(79, 64);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(189, 20);
            this.tbQuantidade.TabIndex = 17;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(140, 606);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 26;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click_1);
            // 
            // btConfirmar
            // 
            this.btConfirmar.Location = new System.Drawing.Point(32, 606);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btConfirmar.TabIndex = 25;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Location = new System.Drawing.Point(89, 25);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(266, 20);
            this.tbCodigo.TabIndex = 27;
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(421, 25);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(266, 20);
            this.tbData.TabIndex = 28;
            // 
            // TelaProcedimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 641);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbServico);
            this.Controls.Add(this.cbVoluntario);
            this.Controls.Add(this.cbAnimal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaProcedimento";
            this.Text = "Procedimento";
            this.Load += new System.EventHandler(this.TelaProcedimento_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAnimal;
        private System.Windows.Forms.ComboBox cbVoluntario;
        private System.Windows.Forms.ComboBox cbServico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.Button btAdicionarProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbData;
    }
}