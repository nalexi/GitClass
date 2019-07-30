namespace CadastroDeLanche
{
    partial class TelaDeCadastro
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
            this.BotaoSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBxNome = new System.Windows.Forms.TextBox();
            this.nrQuant = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBxValor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nrQuant)).BeginInit();
            this.SuspendLayout();
            // 
            // BotaoSalvar
            // 
            this.BotaoSalvar.Location = new System.Drawing.Point(12, 92);
            this.BotaoSalvar.Name = "BotaoSalvar";
            this.BotaoSalvar.Size = new System.Drawing.Size(384, 395);
            this.BotaoSalvar.TabIndex = 0;
            this.BotaoSalvar.Text = "Salvar";
            this.BotaoSalvar.UseVisualStyleBackColor = true;
            this.BotaoSalvar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // tBxNome
            // 
            this.tBxNome.Location = new System.Drawing.Point(100, 10);
            this.tBxNome.Name = "tBxNome";
            this.tBxNome.Size = new System.Drawing.Size(296, 22);
            this.tBxNome.TabIndex = 2;
            // 
            // nrQuant
            // 
            this.nrQuant.Location = new System.Drawing.Point(100, 38);
            this.nrQuant.Name = "nrQuant";
            this.nrQuant.Size = new System.Drawing.Size(296, 22);
            this.nrQuant.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor";
            // 
            // tBxValor
            // 
            this.tBxValor.Location = new System.Drawing.Point(100, 64);
            this.tBxValor.Name = "tBxValor";
            this.tBxValor.Size = new System.Drawing.Size(296, 22);
            this.tBxValor.TabIndex = 6;
            // 
            // TelaDeCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 498);
            this.Controls.Add(this.tBxValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nrQuant);
            this.Controls.Add(this.tBxNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotaoSalvar);
            this.Name = "TelaDeCadastro";
            this.Text = "TelaDeCadastro";
            ((System.ComponentModel.ISupportInitialize)(this.nrQuant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotaoSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBxNome;
        private System.Windows.Forms.NumericUpDown nrQuant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBxValor;
    }
}