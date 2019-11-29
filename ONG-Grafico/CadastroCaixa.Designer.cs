namespace ONG_Grafico
{
    partial class CadastroCaixa
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btConfirma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Location = new System.Drawing.Point(75, 19);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(130, 20);
            this.tbCodigo.TabIndex = 5;
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(279, 19);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(130, 20);
            this.tbData.TabIndex = 6;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(477, 19);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(130, 20);
            this.tbValor.TabIndex = 7;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(76, 63);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(531, 51);
            this.tbDescricao.TabIndex = 8;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(120, 131);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 10;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btConfirma
            // 
            this.btConfirma.Location = new System.Drawing.Point(12, 131);
            this.btConfirma.Name = "btConfirma";
            this.btConfirma.Size = new System.Drawing.Size(75, 23);
            this.btConfirma.TabIndex = 9;
            this.btConfirma.Text = "Confirmar";
            this.btConfirma.UseVisualStyleBackColor = true;
            this.btConfirma.Click += new System.EventHandler(this.btConfirma_Click);
            // 
            // CadastroCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 166);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btConfirma);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "CadastroCaixa";
            this.Text = "CadastroCaixa";
            this.Load += new System.EventHandler(this.CadastroCaixa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btConfirma;
    }
}