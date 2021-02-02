namespace ProjetoLocadora
{
  partial class Locacao
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
        this.textNomeCli = new System.Windows.Forms.TextBox();
        this.labelCliente = new System.Windows.Forms.Label();
        this.textCodigo = new System.Windows.Forms.TextBox();
        this.labelCPF = new System.Windows.Forms.Label();
        this.groupBoxFilmes = new System.Windows.Forms.GroupBox();
        this.textPago = new System.Windows.Forms.TextBox();
        this.textTotal = new System.Windows.Forms.TextBox();
        this.botaoConsultaFilme = new System.Windows.Forms.Button();
        this.label5 = new System.Windows.Forms.Label();
        this.buttonRemover = new System.Windows.Forms.Button();
        this.buttonLimpar = new System.Windows.Forms.Button();
        this.labelTotal = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.labelQTDEItens = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.botaoAdicionarFilme = new System.Windows.Forms.Button();
        this.textFilmeCod = new System.Windows.Forms.TextBox();
        this.listViewFilmes = new System.Windows.Forms.ListView();
        this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.label1 = new System.Windows.Forms.Label();
        this.textFilmeTitulo = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.buttonCancelar = new System.Windows.Forms.Button();
        this.buttonLocar = new System.Windows.Forms.Button();
        this.dateLocacao = new System.Windows.Forms.DateTimePicker();
        this.label6 = new System.Windows.Forms.Label();
        this.label7 = new System.Windows.Forms.Label();
        this.maskedCPFCli = new System.Windows.Forms.MaskedTextBox();
        this.botaoPesqCod = new System.Windows.Forms.Button();
        this.botaoPesqCpf = new System.Windows.Forms.Button();
        this.botaoPesqNome = new System.Windows.Forms.Button();
        this.botaoAcessaCadastro = new System.Windows.Forms.Button();
        this.groupBoxFilmes.SuspendLayout();
        this.SuspendLayout();
        // 
        // textNomeCli
        // 
        this.textNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.textNomeCli.Location = new System.Drawing.Point(279, 25);
        this.textNomeCli.MaxLength = 150;
        this.textNomeCli.Name = "textNomeCli";
        this.textNomeCli.Size = new System.Drawing.Size(410, 20);
        this.textNomeCli.TabIndex = 7;
        // 
        // labelCliente
        // 
        this.labelCliente.AutoSize = true;
        this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.labelCliente.Location = new System.Drawing.Point(276, 8);
        this.labelCliente.Name = "labelCliente";
        this.labelCliente.Size = new System.Drawing.Size(42, 13);
        this.labelCliente.TabIndex = 6;
        this.labelCliente.Text = "Cliente:";
        // 
        // textCodigo
        // 
        this.textCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.textCodigo.Location = new System.Drawing.Point(12, 25);
        this.textCodigo.MaxLength = 5;
        this.textCodigo.Name = "textCodigo";
        this.textCodigo.Size = new System.Drawing.Size(98, 20);
        this.textCodigo.TabIndex = 1;
        // 
        // labelCPF
        // 
        this.labelCPF.AutoSize = true;
        this.labelCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.labelCPF.Location = new System.Drawing.Point(9, 9);
        this.labelCPF.Name = "labelCPF";
        this.labelCPF.Size = new System.Drawing.Size(43, 13);
        this.labelCPF.TabIndex = 0;
        this.labelCPF.Text = "Código:";
        // 
        // groupBoxFilmes
        // 
        this.groupBoxFilmes.Controls.Add(this.textPago);
        this.groupBoxFilmes.Controls.Add(this.textTotal);
        this.groupBoxFilmes.Controls.Add(this.botaoConsultaFilme);
        this.groupBoxFilmes.Controls.Add(this.label5);
        this.groupBoxFilmes.Controls.Add(this.buttonRemover);
        this.groupBoxFilmes.Controls.Add(this.buttonLimpar);
        this.groupBoxFilmes.Controls.Add(this.labelTotal);
        this.groupBoxFilmes.Controls.Add(this.label4);
        this.groupBoxFilmes.Controls.Add(this.labelQTDEItens);
        this.groupBoxFilmes.Controls.Add(this.label3);
        this.groupBoxFilmes.Controls.Add(this.botaoAdicionarFilme);
        this.groupBoxFilmes.Controls.Add(this.textFilmeCod);
        this.groupBoxFilmes.Controls.Add(this.listViewFilmes);
        this.groupBoxFilmes.Controls.Add(this.label1);
        this.groupBoxFilmes.Controls.Add(this.textFilmeTitulo);
        this.groupBoxFilmes.Controls.Add(this.label2);
        this.groupBoxFilmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.groupBoxFilmes.Location = new System.Drawing.Point(12, 114);
        this.groupBoxFilmes.Name = "groupBoxFilmes";
        this.groupBoxFilmes.Size = new System.Drawing.Size(701, 344);
        this.groupBoxFilmes.TabIndex = 13;
        this.groupBoxFilmes.TabStop = false;
        this.groupBoxFilmes.Text = "Filmes:";
        // 
        // textPago
        // 
        this.textPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.textPago.Location = new System.Drawing.Point(620, 308);
        this.textPago.MaxLength = 5;
        this.textPago.Name = "textPago";
        this.textPago.Size = new System.Drawing.Size(75, 20);
        this.textPago.TabIndex = 12;
        this.textPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.textPago.Click += new System.EventHandler(this.textPago_Click);
        // 
        // textTotal
        // 
        this.textTotal.Enabled = false;
        this.textTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.textTotal.Location = new System.Drawing.Point(620, 270);
        this.textTotal.Name = "textTotal";
        this.textTotal.Size = new System.Drawing.Size(75, 20);
        this.textTotal.TabIndex = 10;
        this.textTotal.Text = "0,00";
        this.textTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // botaoConsultaFilme
        // 
        this.botaoConsultaFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.botaoConsultaFilme.Location = new System.Drawing.Point(104, 38);
        this.botaoConsultaFilme.Name = "botaoConsultaFilme";
        this.botaoConsultaFilme.Size = new System.Drawing.Size(20, 20);
        this.botaoConsultaFilme.TabIndex = 2;
        this.botaoConsultaFilme.Text = "P";
        this.botaoConsultaFilme.UseVisualStyleBackColor = true;
        this.botaoConsultaFilme.Click += new System.EventHandler(this.consultaFilme_Click);
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label5.Location = new System.Drawing.Point(554, 311);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(52, 13);
        this.label5.TabIndex = 11;
        this.label5.Text = "Pago: R$";
        // 
        // buttonRemover
        // 
        this.buttonRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.buttonRemover.Location = new System.Drawing.Point(539, 65);
        this.buttonRemover.Name = "buttonRemover";
        this.buttonRemover.Size = new System.Drawing.Size(75, 23);
        this.buttonRemover.TabIndex = 6;
        this.buttonRemover.Text = "&Remover";
        this.buttonRemover.UseVisualStyleBackColor = true;
        this.buttonRemover.Click += new System.EventHandler(this.botaoRemoveFilme_Click);
        // 
        // buttonLimpar
        // 
        this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.buttonLimpar.Location = new System.Drawing.Point(620, 65);
        this.buttonLimpar.Name = "buttonLimpar";
        this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
        this.buttonLimpar.TabIndex = 7;
        this.buttonLimpar.Text = "&Limpar";
        this.buttonLimpar.UseVisualStyleBackColor = true;
        // 
        // labelTotal
        // 
        this.labelTotal.AutoSize = true;
        this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.labelTotal.Location = new System.Drawing.Point(619, 273);
        this.labelTotal.Name = "labelTotal";
        this.labelTotal.Size = new System.Drawing.Size(0, 13);
        this.labelTotal.TabIndex = 13;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label4.Location = new System.Drawing.Point(553, 273);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(51, 13);
        this.label4.TabIndex = 9;
        this.label4.Text = "Total: R$";
        // 
        // labelQTDEItens
        // 
        this.labelQTDEItens.AutoSize = true;
        this.labelQTDEItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.labelQTDEItens.Location = new System.Drawing.Point(51, 273);
        this.labelQTDEItens.Name = "labelQTDEItens";
        this.labelQTDEItens.Size = new System.Drawing.Size(0, 13);
        this.labelQTDEItens.TabIndex = 9;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(6, 273);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(33, 13);
        this.label3.TabIndex = 8;
        this.label3.Text = "Itens:";
        // 
        // botaoAdicionarFilme
        // 
        this.botaoAdicionarFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.botaoAdicionarFilme.Location = new System.Drawing.Point(458, 65);
        this.botaoAdicionarFilme.Name = "botaoAdicionarFilme";
        this.botaoAdicionarFilme.Size = new System.Drawing.Size(75, 23);
        this.botaoAdicionarFilme.TabIndex = 5;
        this.botaoAdicionarFilme.Text = "&Adicionar";
        this.botaoAdicionarFilme.UseVisualStyleBackColor = true;
        this.botaoAdicionarFilme.Click += new System.EventHandler(this.botaoAdicionarFilme_Click);
        // 
        // textFilmeCod
        // 
        this.textFilmeCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.textFilmeCod.Location = new System.Drawing.Point(6, 39);
        this.textFilmeCod.MaxLength = 5;
        this.textFilmeCod.Name = "textFilmeCod";
        this.textFilmeCod.Size = new System.Drawing.Size(92, 20);
        this.textFilmeCod.TabIndex = 1;
        this.textFilmeCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.consultaFilme_KeyPress);
        // 
        // listViewFilmes
        // 
        this.listViewFilmes.Activation = System.Windows.Forms.ItemActivation.OneClick;
        this.listViewFilmes.BackColor = System.Drawing.Color.Lavender;
        this.listViewFilmes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
        this.listViewFilmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.listViewFilmes.FullRowSelect = true;
        this.listViewFilmes.GridLines = true;
        this.listViewFilmes.Location = new System.Drawing.Point(6, 94);
        this.listViewFilmes.Name = "listViewFilmes";
        this.listViewFilmes.Size = new System.Drawing.Size(689, 172);
        this.listViewFilmes.TabIndex = 8;
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
        this.columnHeader2.Width = 475;
        // 
        // columnHeader3
        // 
        this.columnHeader3.Text = "Prazo";
        this.columnHeader3.Width = 70;
        // 
        // columnHeader4
        // 
        this.columnHeader4.Text = "Valor";
        this.columnHeader4.Width = 70;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.Location = new System.Drawing.Point(3, 23);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(43, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "Código:";
        // 
        // textFilmeTitulo
        // 
        this.textFilmeTitulo.Enabled = false;
        this.textFilmeTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.textFilmeTitulo.Location = new System.Drawing.Point(133, 39);
        this.textFilmeTitulo.MaxLength = 150;
        this.textFilmeTitulo.Name = "textFilmeTitulo";
        this.textFilmeTitulo.Size = new System.Drawing.Size(562, 20);
        this.textFilmeTitulo.TabIndex = 4;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label2.Location = new System.Drawing.Point(130, 23);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(36, 13);
        this.label2.TabIndex = 3;
        this.label2.Text = "Titulo:";
        // 
        // buttonCancelar
        // 
        this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.buttonCancelar.Location = new System.Drawing.Point(638, 538);
        this.buttonCancelar.Name = "buttonCancelar";
        this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
        this.buttonCancelar.TabIndex = 0;
        this.buttonCancelar.Text = "&Cancelar";
        this.buttonCancelar.UseVisualStyleBackColor = true;
        this.buttonCancelar.Click += new System.EventHandler(this.cancelaLocacao_Click);
        // 
        // buttonLocar
        // 
        this.buttonLocar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.buttonLocar.Location = new System.Drawing.Point(557, 538);
        this.buttonLocar.Name = "buttonLocar";
        this.buttonLocar.Size = new System.Drawing.Size(75, 23);
        this.buttonLocar.TabIndex = 14;
        this.buttonLocar.Text = "L&ocar";
        this.buttonLocar.UseVisualStyleBackColor = true;
        this.buttonLocar.Click += new System.EventHandler(this.botaoLocar_Click);
        // 
        // dateLocacao
        // 
        this.dateLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.dateLocacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateLocacao.Location = new System.Drawing.Point(588, 85);
        this.dateLocacao.Name = "dateLocacao";
        this.dateLocacao.Size = new System.Drawing.Size(123, 20);
        this.dateLocacao.TabIndex = 10;
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label6.Location = new System.Drawing.Point(585, 69);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(93, 13);
        this.label6.TabIndex = 9;
        this.label6.Text = "Data de Locação:";
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label7.Location = new System.Drawing.Point(142, 9);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(30, 13);
        this.label7.TabIndex = 3;
        this.label7.Text = "CPF:";
        // 
        // maskedCPFCli
        // 
        this.maskedCPFCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.maskedCPFCli.Location = new System.Drawing.Point(145, 25);
        this.maskedCPFCli.Mask = "999,999,999-99";
        this.maskedCPFCli.Name = "maskedCPFCli";
        this.maskedCPFCli.Size = new System.Drawing.Size(88, 20);
        this.maskedCPFCli.TabIndex = 4;
        this.maskedCPFCli.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
        // 
        // botaoPesqCod
        // 
        this.botaoPesqCod.Location = new System.Drawing.Point(116, 24);
        this.botaoPesqCod.Name = "botaoPesqCod";
        this.botaoPesqCod.Size = new System.Drawing.Size(20, 20);
        this.botaoPesqCod.TabIndex = 2;
        this.botaoPesqCod.Text = "P";
        this.botaoPesqCod.UseVisualStyleBackColor = true;
        this.botaoPesqCod.Click += new System.EventHandler(this.botaoPesqCod_Click);
        // 
        // botaoPesqCpf
        // 
        this.botaoPesqCpf.Location = new System.Drawing.Point(239, 24);
        this.botaoPesqCpf.Name = "botaoPesqCpf";
        this.botaoPesqCpf.Size = new System.Drawing.Size(20, 20);
        this.botaoPesqCpf.TabIndex = 5;
        this.botaoPesqCpf.Text = "P";
        this.botaoPesqCpf.UseVisualStyleBackColor = true;
        this.botaoPesqCpf.Click += new System.EventHandler(this.botaoPesqCpf_Click);
        // 
        // botaoPesqNome
        // 
        this.botaoPesqNome.Location = new System.Drawing.Point(695, 25);
        this.botaoPesqNome.Name = "botaoPesqNome";
        this.botaoPesqNome.Size = new System.Drawing.Size(20, 20);
        this.botaoPesqNome.TabIndex = 8;
        this.botaoPesqNome.Text = "P";
        this.botaoPesqNome.UseVisualStyleBackColor = true;
        this.botaoPesqNome.Click += new System.EventHandler(this.botaoPesqNome_Click);
        // 
        // botaoAcessaCadastro
        // 
        this.botaoAcessaCadastro.Location = new System.Drawing.Point(427, 82);
        this.botaoAcessaCadastro.Name = "botaoAcessaCadastro";
        this.botaoAcessaCadastro.Size = new System.Drawing.Size(155, 23);
        this.botaoAcessaCadastro.TabIndex = 11;
        this.botaoAcessaCadastro.Text = "Acessa Cadastro Cliente";
        this.botaoAcessaCadastro.UseVisualStyleBackColor = true;
        this.botaoAcessaCadastro.Click += new System.EventHandler(this.botaoAcessaCadastro_Click);
        // 
        // Locacao
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(725, 573);
        this.Controls.Add(this.botaoAcessaCadastro);
        this.Controls.Add(this.botaoPesqNome);
        this.Controls.Add(this.botaoPesqCpf);
        this.Controls.Add(this.botaoPesqCod);
        this.Controls.Add(this.maskedCPFCli);
        this.Controls.Add(this.label7);
        this.Controls.Add(this.dateLocacao);
        this.Controls.Add(this.label6);
        this.Controls.Add(this.buttonCancelar);
        this.Controls.Add(this.buttonLocar);
        this.Controls.Add(this.groupBoxFilmes);
        this.Controls.Add(this.textCodigo);
        this.Controls.Add(this.labelCPF);
        this.Controls.Add(this.textNomeCli);
        this.Controls.Add(this.labelCliente);
        this.MaximizeBox = false;
        this.Name = "Locacao";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Cine+ Locação ";
        this.groupBoxFilmes.ResumeLayout(false);
        this.groupBoxFilmes.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textNomeCli;
    private System.Windows.Forms.Label labelCliente;
    private System.Windows.Forms.TextBox textCodigo;
    private System.Windows.Forms.Label labelCPF;
    private System.Windows.Forms.GroupBox groupBoxFilmes;
    private System.Windows.Forms.TextBox textFilmeCod;
    private System.Windows.Forms.ListView listViewFilmes;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textFilmeTitulo;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button botaoAdicionarFilme;
    private System.Windows.Forms.Label labelTotal;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label labelQTDEItens;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button buttonRemover;
    private System.Windows.Forms.Button buttonLimpar;
    private System.Windows.Forms.Button buttonCancelar;
    private System.Windows.Forms.Button buttonLocar;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.DateTimePicker dateLocacao;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.MaskedTextBox maskedCPFCli;
    private System.Windows.Forms.Button botaoPesqCod;
    private System.Windows.Forms.Button botaoPesqCpf;
    private System.Windows.Forms.Button botaoPesqNome;
    private System.Windows.Forms.Button botaoConsultaFilme;
    private System.Windows.Forms.TextBox textPago;
    private System.Windows.Forms.TextBox textTotal;
    private System.Windows.Forms.Button botaoAcessaCadastro;
  }
}