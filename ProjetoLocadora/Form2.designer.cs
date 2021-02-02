namespace ProjetoLocadora
{
    partial class BuscaFilme
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
            this.botaoConsultaFilme = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.botaoSelecionarFilme = new System.Windows.Forms.Button();
            this.listViewFilmes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gênero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textFilmeTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaoConsultaFilme
            // 
            this.botaoConsultaFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoConsultaFilme.Location = new System.Drawing.Point(501, 456);
            this.botaoConsultaFilme.Name = "botaoConsultaFilme";
            this.botaoConsultaFilme.Size = new System.Drawing.Size(75, 23);
            this.botaoConsultaFilme.TabIndex = 3;
            this.botaoConsultaFilme.Text = "&Buscar";
            this.botaoConsultaFilme.UseVisualStyleBackColor = true;
            this.botaoConsultaFilme.Click += new System.EventHandler(this.botaoConsultaFilme_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Location = new System.Drawing.Point(663, 456);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 5;
            this.buttonLimpar.Text = "&Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // botaoSelecionarFilme
            // 
            this.botaoSelecionarFilme.Enabled = false;
            this.botaoSelecionarFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSelecionarFilme.Location = new System.Drawing.Point(582, 456);
            this.botaoSelecionarFilme.Name = "botaoSelecionarFilme";
            this.botaoSelecionarFilme.Size = new System.Drawing.Size(75, 23);
            this.botaoSelecionarFilme.TabIndex = 4;
            this.botaoSelecionarFilme.Text = "&Selecionar";
            this.botaoSelecionarFilme.UseVisualStyleBackColor = true;
            this.botaoSelecionarFilme.Click += new System.EventHandler(this.botaoAdicionarFilme_Click);
            // 
            // listViewFilmes
            // 
            this.listViewFilmes.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewFilmes.BackColor = System.Drawing.Color.Lavender;
            this.listViewFilmes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.Gênero});
            this.listViewFilmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewFilmes.FullRowSelect = true;
            this.listViewFilmes.GridLines = true;
            this.listViewFilmes.Location = new System.Drawing.Point(38, 103);
            this.listViewFilmes.Name = "listViewFilmes";
            this.listViewFilmes.Size = new System.Drawing.Size(700, 316);
            this.listViewFilmes.TabIndex = 2;
            this.listViewFilmes.UseCompatibleStateImageBehavior = false;
            this.listViewFilmes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Titulo";
            this.columnHeader2.Width = 476;
            // 
            // Gênero
            // 
            this.Gênero.Text = "Gênero";
            this.Gênero.Width = 152;
            // 
            // textFilmeTitulo
            // 
            this.textFilmeTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFilmeTitulo.Location = new System.Drawing.Point(38, 47);
            this.textFilmeTitulo.MaxLength = 150;
            this.textFilmeTitulo.Name = "textFilmeTitulo";
            this.textFilmeTitulo.Size = new System.Drawing.Size(700, 20);
            this.textFilmeTitulo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Titulo:";
            // 
            // BuscaFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 491);
            this.Controls.Add(this.botaoConsultaFilme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.listViewFilmes);
            this.Controls.Add(this.botaoSelecionarFilme);
            this.Controls.Add(this.textFilmeTitulo);
            this.MaximizeBox = false;
            this.Name = "BuscaFilme";
            this.Text = "Cine+ Consulta de Filmes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoConsultaFilme;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button botaoSelecionarFilme;
        private System.Windows.Forms.ListView listViewFilmes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textFilmeTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Gênero;
    }
}