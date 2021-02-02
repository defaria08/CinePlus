namespace ProjetoLocadora
{
    partial class Definipreço
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.botaodefinir = new System.Windows.Forms.Button();
            this.botaolimpar = new System.Windows.Forms.Button();
            this.textBoxvsl = new System.Windows.Forms.TextBox();
            this.textBoxva = new System.Windows.Forms.TextBox();
            this.textBoxvl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o valor para cada classe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "3 - ANTIGO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "2 - LANÇAMENTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "1 - SUPER LANÇAMENTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "R$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "R$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "R$";
            // 
            // botaodefinir
            // 
            this.botaodefinir.Location = new System.Drawing.Point(180, 236);
            this.botaodefinir.Name = "botaodefinir";
            this.botaodefinir.Size = new System.Drawing.Size(75, 23);
            this.botaodefinir.TabIndex = 10;
            this.botaodefinir.Text = "&Definir";
            this.botaodefinir.UseVisualStyleBackColor = true;
            this.botaodefinir.Click += new System.EventHandler(this.botaodefinir_Click);
            // 
            // botaolimpar
            // 
            this.botaolimpar.Location = new System.Drawing.Point(261, 236);
            this.botaolimpar.Name = "botaolimpar";
            this.botaolimpar.Size = new System.Drawing.Size(75, 23);
            this.botaolimpar.TabIndex = 11;
            this.botaolimpar.Text = "&Limpar";
            this.botaolimpar.UseVisualStyleBackColor = true;
            this.botaolimpar.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxvsl
            // 
            this.textBoxvsl.Location = new System.Drawing.Point(261, 64);
            this.textBoxvsl.MaxLength = 4;
            this.textBoxvsl.Name = "textBoxvsl";
            this.textBoxvsl.Size = new System.Drawing.Size(71, 20);
            this.textBoxvsl.TabIndex = 3;
            // 
            // textBoxva
            // 
            this.textBoxva.Location = new System.Drawing.Point(261, 138);
            this.textBoxva.MaxLength = 4;
            this.textBoxva.Name = "textBoxva";
            this.textBoxva.Size = new System.Drawing.Size(71, 20);
            this.textBoxva.TabIndex = 9;
            // 
            // textBoxvl
            // 
            this.textBoxvl.Location = new System.Drawing.Point(261, 103);
            this.textBoxvl.MaxLength = 4;
            this.textBoxvl.Name = "textBoxvl";
            this.textBoxvl.Size = new System.Drawing.Size(71, 20);
            this.textBoxvl.TabIndex = 6;
            // 
            // Definipreço
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 271);
            this.Controls.Add(this.textBoxvl);
            this.Controls.Add(this.textBoxva);
            this.Controls.Add(this.textBoxvsl);
            this.Controls.Add(this.botaolimpar);
            this.Controls.Add(this.botaodefinir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Definipreço";
            this.Text = "Cine+ Definição de preços";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button botaodefinir;
        private System.Windows.Forms.Button botaolimpar;
        private System.Windows.Forms.TextBox textBoxvsl;
        private System.Windows.Forms.TextBox textBoxva;
        private System.Windows.Forms.TextBox textBoxvl;
    }
}