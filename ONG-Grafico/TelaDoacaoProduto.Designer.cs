namespace ONG_Grafico
{
    partial class TelaDoacaoProduto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.btAttGrid = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btRemovProd = new System.Windows.Forms.Button();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.btAddProduto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgProdutos);
            this.groupBox1.Controls.Add(this.btAttGrid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btRemovProd);
            this.groupBox1.Controls.Add(this.cbProduto);
            this.groupBox1.Controls.Add(this.btAddProduto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbQuantidade);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 443);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // dgProdutos
            // 
            this.dgProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Location = new System.Drawing.Point(11, 112);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.Size = new System.Drawing.Size(572, 268);
            this.dgProdutos.TabIndex = 15;
            // 
            // btAttGrid
            // 
            this.btAttGrid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAttGrid.Location = new System.Drawing.Point(360, 396);
            this.btAttGrid.Name = "btAttGrid";
            this.btAttGrid.Size = new System.Drawing.Size(75, 23);
            this.btAttGrid.TabIndex = 22;
            this.btAttGrid.Text = "Atualizar";
            this.btAttGrid.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produto";
            // 
            // btRemovProd
            // 
            this.btRemovProd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btRemovProd.Location = new System.Drawing.Point(455, 396);
            this.btRemovProd.Name = "btRemovProd";
            this.btRemovProd.Size = new System.Drawing.Size(128, 23);
            this.btRemovProd.TabIndex = 21;
            this.btRemovProd.Text = "Remover Produto";
            this.btRemovProd.UseVisualStyleBackColor = false;
            this.btRemovProd.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbProduto
            // 
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(79, 21);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(365, 21);
            this.cbProduto.TabIndex = 9;
            // 
            // btAddProduto
            // 
            this.btAddProduto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAddProduto.Location = new System.Drawing.Point(474, 21);
            this.btAddProduto.Name = "btAddProduto";
            this.btAddProduto.Size = new System.Drawing.Size(109, 66);
            this.btAddProduto.TabIndex = 20;
            this.btAddProduto.Text = "Adicionar Produto";
            this.btAddProduto.UseVisualStyleBackColor = false;
            this.btAddProduto.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Quantidade:";
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(79, 64);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(126, 20);
            this.tbQuantidade.TabIndex = 17;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(120, 461);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 25;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btConfirmar
            // 
            this.btConfirmar.Location = new System.Drawing.Point(12, 461);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btConfirmar.TabIndex = 24;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // TelaDoacaoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 507);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btConfirmar);
            this.Name = "TelaDoacaoProduto";
            this.Text = "DoacaoProduto";
            this.Load += new System.EventHandler(this.DoacaoProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.Button btAttGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btRemovProd;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.Button btAddProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btConfirmar;
    }
}