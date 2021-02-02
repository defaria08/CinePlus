namespace ProjetoLocadora
{
  partial class Devolucao
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
        this.buttonCancelar = new System.Windows.Forms.Button();
        this.labelTotal = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.labelQTDEItens = new System.Windows.Forms.Label();
        this.buttonLocar = new System.Windows.Forms.Button();
        this.label3 = new System.Windows.Forms.Label();
        this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.groupBoxFilmes = new System.Windows.Forms.GroupBox();
        this.textAcrescimo = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.textPago = new System.Windows.Forms.TextBox();
        this.label5 = new System.Windows.Forms.Label();
        this.textTotal = new System.Windows.Forms.TextBox();
        this.listViewFilmes = new System.Windows.Forms.ListView();
        this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.dateDevolucao = new System.Windows.Forms.DateTimePicker();
        this.label6 = new System.Windows.Forms.Label();
        this.botaoPesqNome = new System.Windows.Forms.Button();
        this.botaoPesqCpf = new System.Windows.Forms.Button();
        this.botaoPesqCod = new System.Windows.Forms.Button();
        this.maskedCPFCli = new System.Windows.Forms.MaskedTextBox();
        this.label7 = new System.Windows.Forms.Label();
        this.textCodigo = new System.Windows.Forms.TextBox();
        this.labelCPF = new System.Windows.Forms.Label();
        this.textNomeCli = new System.Windows.Forms.TextBox();
        this.labelCliente = new System.Windows.Forms.Label();
        this.groupBoxFilmes.SuspendLayout();
        this.SuspendLayout();
        // 
        // buttonCancelar
        // 
        this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.buttonCancelar.Location = new System.Drawing.Point(639, 540);
        this.buttonCancelar.Name = "buttonCancelar";
        this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
        this.buttonCancelar.TabIndex = 13;
        this.buttonCancelar.Text = "&Fechar";
        this.buttonCancelar.UseVisualStyleBackColor = true;
        this.buttonCancelar.Click += new System.EventHandler(this.cancelaDevolucao_Click);
        // 
        // labelTotal
        // 
        this.labelTotal.AutoSize = true;
        this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.labelTotal.Location = new System.Drawing.Point(620, 308);
        this.labelTotal.Name = "labelTotal";
        this.labelTotal.Size = new System.Drawing.Size(0, 13);
        this.labelTotal.TabIndex = 11;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(554, 308);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(51, 13);
        this.label4.TabIndex = 5;
        this.label4.Text = "Total: R$";
        // 
        // labelQTDEItens
        // 
        this.labelQTDEItens.AutoSize = true;
        this.labelQTDEItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.labelQTDEItens.Location = new System.Drawing.Point(46, 269);
        this.labelQTDEItens.Name = "labelQTDEItens";
        this.labelQTDEItens.Size = new System.Drawing.Size(0, 13);
        this.labelQTDEItens.TabIndex = 2;
        // 
        // buttonLocar
        // 
        this.buttonLocar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.buttonLocar.Location = new System.Drawing.Point(477, 540);
        this.buttonLocar.Name = "buttonLocar";
        this.buttonLocar.Size = new System.Drawing.Size(156, 23);
        this.buttonLocar.TabIndex = 12;
        this.buttonLocar.Text = "&Devolver Selecionados";
        this.buttonLocar.UseVisualStyleBackColor = true;
        this.buttonLocar.Click += new System.EventHandler(this.botaoDevolver_Click);
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(7, 269);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(33, 13);
        this.label3.TabIndex = 1;
        this.label3.Text = "Itens:";
        // 
        // columnHeader4
        // 
        this.columnHeader4.Text = "Atrazo";
        this.columnHeader4.Width = 70;
        // 
        // groupBoxFilmes
        // 
        this.groupBoxFilmes.Controls.Add(this.textAcrescimo);
        this.groupBoxFilmes.Controls.Add(this.label1);
        this.groupBoxFilmes.Controls.Add(this.textPago);
        this.groupBoxFilmes.Controls.Add(this.label5);
        this.groupBoxFilmes.Controls.Add(this.textTotal);
        this.groupBoxFilmes.Controls.Add(this.labelTotal);
        this.groupBoxFilmes.Controls.Add(this.label4);
        this.groupBoxFilmes.Controls.Add(this.labelQTDEItens);
        this.groupBoxFilmes.Controls.Add(this.label3);
        this.groupBoxFilmes.Controls.Add(this.listViewFilmes);
        this.groupBoxFilmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.groupBoxFilmes.Location = new System.Drawing.Point(13, 114);
        this.groupBoxFilmes.Name = "groupBoxFilmes";
        this.groupBoxFilmes.Size = new System.Drawing.Size(701, 366);
        this.groupBoxFilmes.TabIndex = 11;
        this.groupBoxFilmes.TabStop = false;
        this.groupBoxFilmes.Text = "Filmes:";
        // 
        // textAcrescimo
        // 
        this.textAcrescimo.Enabled = false;
        this.textAcrescimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.textAcrescimo.Location = new System.Drawing.Point(620, 279);
        this.textAcrescimo.Name = "textAcrescimo";
        this.textAcrescimo.Size = new System.Drawing.Size(75, 20);
        this.textAcrescimo.TabIndex = 4;
        this.textAcrescimo.Text = "0,00";
        this.textAcrescimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.Location = new System.Drawing.Point(529, 282);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(76, 13);
        this.label1.TabIndex = 3;
        this.label1.Text = "Acréscimo: R$";
        // 
        // textPago
        // 
        this.textPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.textPago.Location = new System.Drawing.Point(620, 331);
        this.textPago.MaxLength = 5;
        this.textPago.Name = "textPago";
        this.textPago.Size = new System.Drawing.Size(75, 20);
        this.textPago.TabIndex = 8;
        this.textPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label5.Location = new System.Drawing.Point(554, 334);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(52, 13);
        this.label5.TabIndex = 7;
        this.label5.Text = "Pago: R$";
        // 
        // textTotal
        // 
        this.textTotal.Enabled = false;
        this.textTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.textTotal.Location = new System.Drawing.Point(620, 305);
        this.textTotal.Name = "textTotal";
        this.textTotal.Size = new System.Drawing.Size(76, 20);
        this.textTotal.TabIndex = 6;
        this.textTotal.Text = "0,00";
        this.textTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // listViewFilmes
        // 
        this.listViewFilmes.BackColor = System.Drawing.Color.Lavender;
        this.listViewFilmes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6});
        this.listViewFilmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.listViewFilmes.FullRowSelect = true;
        this.listViewFilmes.GridLines = true;
        this.listViewFilmes.Location = new System.Drawing.Point(6, 19);
        this.listViewFilmes.Name = "listViewFilmes";
        this.listViewFilmes.Size = new System.Drawing.Size(689, 247);
        this.listViewFilmes.TabIndex = 0;
        this.listViewFilmes.UseCompatibleStateImageBehavior = false;
        this.listViewFilmes.View = System.Windows.Forms.View.Details;
        this.listViewFilmes.Click += new System.EventHandler(this.selecionaFilmes_SIChange);
        // 
        // columnHeader1
        // 
        this.columnHeader1.Text = "Locação Nº";
        this.columnHeader1.Width = 85;
        // 
        // columnHeader2
        // 
        this.columnHeader2.Text = "Titulo";
        this.columnHeader2.Width = 400;
        // 
        // columnHeader3
        // 
        this.columnHeader3.Text = "Locação";
        this.columnHeader3.Width = 70;
        // 
        // columnHeader6
        // 
        this.columnHeader6.Text = "Valor";
        // 
        // dateDevolucao
        // 
        this.dateDevolucao.Enabled = false;
        this.dateDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.dateDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateDevolucao.Location = new System.Drawing.Point(590, 88);
        this.dateDevolucao.Name = "dateDevolucao";
        this.dateDevolucao.Size = new System.Drawing.Size(123, 20);
        this.dateDevolucao.TabIndex = 10;
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label6.Location = new System.Drawing.Point(587, 72);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(100, 13);
        this.label6.TabIndex = 9;
        this.label6.Text = "Data de Devolução";
        // 
        // botaoPesqNome
        // 
        this.botaoPesqNome.Location = new System.Drawing.Point(696, 25);
        this.botaoPesqNome.Name = "botaoPesqNome";
        this.botaoPesqNome.Size = new System.Drawing.Size(20, 20);
        this.botaoPesqNome.TabIndex = 8;
        this.botaoPesqNome.Text = "P";
        this.botaoPesqNome.UseVisualStyleBackColor = true;
        this.botaoPesqNome.Click += new System.EventHandler(this.botaoPesqNome_Click);
        // 
        // botaoPesqCpf
        // 
        this.botaoPesqCpf.Location = new System.Drawing.Point(240, 24);
        this.botaoPesqCpf.Name = "botaoPesqCpf";
        this.botaoPesqCpf.Size = new System.Drawing.Size(20, 20);
        this.botaoPesqCpf.TabIndex = 5;
        this.botaoPesqCpf.Text = "P";
        this.botaoPesqCpf.UseVisualStyleBackColor = true;
        this.botaoPesqCpf.Click += new System.EventHandler(this.botaoPesqCpf_Click);
        // 
        // botaoPesqCod
        // 
        this.botaoPesqCod.Location = new System.Drawing.Point(117, 24);
        this.botaoPesqCod.Name = "botaoPesqCod";
        this.botaoPesqCod.Size = new System.Drawing.Size(20, 20);
        this.botaoPesqCod.TabIndex = 2;
        this.botaoPesqCod.Text = "P";
        this.botaoPesqCod.UseVisualStyleBackColor = true;
        this.botaoPesqCod.Click += new System.EventHandler(this.botaoPesqCod_Click);
        // 
        // maskedCPFCli
        // 
        this.maskedCPFCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.maskedCPFCli.Location = new System.Drawing.Point(146, 25);
        this.maskedCPFCli.Mask = "999,999,999-99";
        this.maskedCPFCli.Name = "maskedCPFCli";
        this.maskedCPFCli.Size = new System.Drawing.Size(88, 20);
        this.maskedCPFCli.TabIndex = 4;
        this.maskedCPFCli.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label7.Location = new System.Drawing.Point(143, 9);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(30, 13);
        this.label7.TabIndex = 3;
        this.label7.Text = "CPF:";
        // 
        // textCodigo
        // 
        this.textCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.textCodigo.Location = new System.Drawing.Point(13, 25);
        this.textCodigo.MaxLength = 5;
        this.textCodigo.Name = "textCodigo";
        this.textCodigo.Size = new System.Drawing.Size(98, 20);
        this.textCodigo.TabIndex = 1;
        // 
        // labelCPF
        // 
        this.labelCPF.AutoSize = true;
        this.labelCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.labelCPF.Location = new System.Drawing.Point(10, 9);
        this.labelCPF.Name = "labelCPF";
        this.labelCPF.Size = new System.Drawing.Size(43, 13);
        this.labelCPF.TabIndex = 0;
        this.labelCPF.Text = "Código:";
        // 
        // textNomeCli
        // 
        this.textNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.textNomeCli.Location = new System.Drawing.Point(280, 25);
        this.textNomeCli.MaxLength = 150;
        this.textNomeCli.Name = "textNomeCli";
        this.textNomeCli.Size = new System.Drawing.Size(410, 20);
        this.textNomeCli.TabIndex = 7;
        // 
        // labelCliente
        // 
        this.labelCliente.AutoSize = true;
        this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.labelCliente.Location = new System.Drawing.Point(277, 8);
        this.labelCliente.Name = "labelCliente";
        this.labelCliente.Size = new System.Drawing.Size(42, 13);
        this.labelCliente.TabIndex = 6;
        this.labelCliente.Text = "Cliente:";
        // 
        // Devolucao
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(725, 573);
        this.Controls.Add(this.botaoPesqNome);
        this.Controls.Add(this.botaoPesqCpf);
        this.Controls.Add(this.botaoPesqCod);
        this.Controls.Add(this.maskedCPFCli);
        this.Controls.Add(this.label7);
        this.Controls.Add(this.textCodigo);
        this.Controls.Add(this.labelCPF);
        this.Controls.Add(this.textNomeCli);
        this.Controls.Add(this.labelCliente);
        this.Controls.Add(this.dateDevolucao);
        this.Controls.Add(this.label6);
        this.Controls.Add(this.buttonCancelar);
        this.Controls.Add(this.buttonLocar);
        this.Controls.Add(this.groupBoxFilmes);
        this.MaximizeBox = false;
        this.Name = "Devolucao";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Cine+ Devolução";
        this.groupBoxFilmes.ResumeLayout(false);
        this.groupBoxFilmes.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonCancelar;
    private System.Windows.Forms.Label labelTotal;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label labelQTDEItens;
    private System.Windows.Forms.Button buttonLocar;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.GroupBox groupBoxFilmes;
    private System.Windows.Forms.ListView listViewFilmes;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.DateTimePicker dateDevolucao;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button botaoPesqNome;
    private System.Windows.Forms.Button botaoPesqCpf;
    private System.Windows.Forms.Button botaoPesqCod;
    private System.Windows.Forms.MaskedTextBox maskedCPFCli;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox textCodigo;
    private System.Windows.Forms.Label labelCPF;
    private System.Windows.Forms.TextBox textNomeCli;
    private System.Windows.Forms.Label labelCliente;
    private System.Windows.Forms.TextBox textTotal;
    private System.Windows.Forms.ColumnHeader columnHeader6;
    private System.Windows.Forms.TextBox textAcrescimo;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textPago;
    private System.Windows.Forms.Label label5;
  }
}