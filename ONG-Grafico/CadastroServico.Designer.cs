namespace ONG_Grafico
{
    partial class CadastroServico
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
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbHigiene = new System.Windows.Forms.RadioButton();
            this.rbMedico = new System.Windows.Forms.RadioButton();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.cbVeterinario = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Location = new System.Drawing.Point(84, 19);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(282, 20);
            this.tbCodigo.TabIndex = 3;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(84, 70);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(282, 20);
            this.tbDescricao.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descrição:";
            // 
            // rbHigiene
            // 
            this.rbHigiene.AutoSize = true;
            this.rbHigiene.Location = new System.Drawing.Point(12, 31);
            this.rbHigiene.Name = "rbHigiene";
            this.rbHigiene.Size = new System.Drawing.Size(61, 17);
            this.rbHigiene.TabIndex = 7;
            this.rbHigiene.TabStop = true;
            this.rbHigiene.Text = "Higiene";
            this.rbHigiene.UseVisualStyleBackColor = true;
            // 
            // rbMedico
            // 
            this.rbMedico.AutoSize = true;
            this.rbMedico.Location = new System.Drawing.Point(174, 31);
            this.rbMedico.Name = "rbMedico";
            this.rbMedico.Size = new System.Drawing.Size(60, 17);
            this.rbMedico.TabIndex = 8;
            this.rbMedico.TabStop = true;
            this.rbMedico.Text = "Médico";
            this.rbMedico.UseVisualStyleBackColor = true;
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.label3);
            this.gbTipo.Controls.Add(this.rbMedico);
            this.gbTipo.Controls.Add(this.rbHigiene);
            this.gbTipo.Location = new System.Drawing.Point(29, 113);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(337, 57);
            this.gbTipo.TabIndex = 9;
            this.gbTipo.TabStop = false;
            // 
            // btConfirmar
            // 
            this.btConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btConfirmar.Location = new System.Drawing.Point(183, 248);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btConfirmar.TabIndex = 54;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.Location = new System.Drawing.Point(291, 248);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 53;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // cbVeterinario
            // 
            this.cbVeterinario.AutoSize = true;
            this.cbVeterinario.Location = new System.Drawing.Point(29, 193);
            this.cbVeterinario.Name = "cbVeterinario";
            this.cbVeterinario.Size = new System.Drawing.Size(15, 14);
            this.cbVeterinario.TabIndex = 6;
            this.cbVeterinario.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo de Serviço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Este procedimento só deve ser realizado por um veterinário";
            // 
            // CadastroServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 283);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.cbVeterinario);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label1);
            this.Name = "CadastroServico";
            this.Text = "Cadastro de Serviço";
            this.Load += new System.EventHandler(this.CadastroServico_Load);
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbHigiene;
        private System.Windows.Forms.RadioButton rbMedico;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.CheckBox cbVeterinario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}