namespace ProjetoLocadora
{
    partial class BuscaUsuario
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
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.botaoConsultausuario = new System.Windows.Forms.Button();
            this.Gênero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelnomebusca = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.ListViewBuscaUsuario = new System.Windows.Forms.ListView();
            this.botaoSelecionarUsuario = new System.Windows.Forms.Button();
            this.textbuscausuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 476;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 70;
            // 
            // botaoConsultausuario
            // 
            this.botaoConsultausuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoConsultausuario.Location = new System.Drawing.Point(507, 461);
            this.botaoConsultausuario.Name = "botaoConsultausuario";
            this.botaoConsultausuario.Size = new System.Drawing.Size(75, 23);
            this.botaoConsultausuario.TabIndex = 3;
            this.botaoConsultausuario.Text = "&Buscar";
            this.botaoConsultausuario.UseVisualStyleBackColor = true;
            this.botaoConsultausuario.Click += new System.EventHandler(this.botaoConsultausuario_Click);
            // 
            // Gênero
            // 
            this.Gênero.Text = "Nível de Acesso";
            this.Gênero.Width = 152;
            // 
            // labelnomebusca
            // 
            this.labelnomebusca.AutoSize = true;
            this.labelnomebusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnomebusca.Location = new System.Drawing.Point(41, 36);
            this.labelnomebusca.Name = "labelnomebusca";
            this.labelnomebusca.Size = new System.Drawing.Size(38, 13);
            this.labelnomebusca.TabIndex = 0;
            this.labelnomebusca.Text = "Nome:";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Location = new System.Drawing.Point(669, 461);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 5;
            this.buttonLimpar.Text = "&Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // ListViewBuscaUsuario
            // 
            this.ListViewBuscaUsuario.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListViewBuscaUsuario.BackColor = System.Drawing.Color.Lavender;
            this.ListViewBuscaUsuario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.Gênero});
            this.ListViewBuscaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewBuscaUsuario.FullRowSelect = true;
            this.ListViewBuscaUsuario.GridLines = true;
            this.ListViewBuscaUsuario.Location = new System.Drawing.Point(44, 108);
            this.ListViewBuscaUsuario.Name = "ListViewBuscaUsuario";
            this.ListViewBuscaUsuario.Size = new System.Drawing.Size(700, 316);
            this.ListViewBuscaUsuario.TabIndex = 2;
            this.ListViewBuscaUsuario.UseCompatibleStateImageBehavior = false;
            this.ListViewBuscaUsuario.View = System.Windows.Forms.View.Details;
            // 
            // botaoSelecionarUsuario
            // 
            this.botaoSelecionarUsuario.Enabled = false;
            this.botaoSelecionarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSelecionarUsuario.Location = new System.Drawing.Point(588, 461);
            this.botaoSelecionarUsuario.Name = "botaoSelecionarUsuario";
            this.botaoSelecionarUsuario.Size = new System.Drawing.Size(75, 23);
            this.botaoSelecionarUsuario.TabIndex = 4;
            this.botaoSelecionarUsuario.Text = "&Selecionar";
            this.botaoSelecionarUsuario.UseVisualStyleBackColor = true;
            this.botaoSelecionarUsuario.Click += new System.EventHandler(this.botaoSelecionarUsuario_Click);
            // 
            // textbuscausuario
            // 
            this.textbuscausuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbuscausuario.Location = new System.Drawing.Point(44, 52);
            this.textbuscausuario.MaxLength = 150;
            this.textbuscausuario.Name = "textbuscausuario";
            this.textbuscausuario.Size = new System.Drawing.Size(700, 20);
            this.textbuscausuario.TabIndex = 1;
            // 
            // BuscaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 521);
            this.Controls.Add(this.botaoConsultausuario);
            this.Controls.Add(this.labelnomebusca);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.ListViewBuscaUsuario);
            this.Controls.Add(this.botaoSelecionarUsuario);
            this.Controls.Add(this.textbuscausuario);
            this.MaximizeBox = false;
            this.Name = "BuscaUsuario";
            this.Text = "Cine+ Consulta de Usuários";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button botaoConsultausuario;
        private System.Windows.Forms.ColumnHeader Gênero;
        private System.Windows.Forms.Label labelnomebusca;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.ListView ListViewBuscaUsuario;
        private System.Windows.Forms.Button botaoSelecionarUsuario;
        private System.Windows.Forms.TextBox textbuscausuario;
    }
}