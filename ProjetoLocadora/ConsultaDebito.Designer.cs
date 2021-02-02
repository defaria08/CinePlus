namespace ProjetoLocadora
{
  partial class ConsultaDebito
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
        this.botaoPesqNome = new System.Windows.Forms.Button();
        this.botaoPesqCpf = new System.Windows.Forms.Button();
        this.botaoPesqCod = new System.Windows.Forms.Button();
        this.maskedCPFCli = new System.Windows.Forms.MaskedTextBox();
        this.label7 = new System.Windows.Forms.Label();
        this.textCodigo = new System.Windows.Forms.TextBox();
        this.labelCPF = new System.Windows.Forms.Label();
        this.textNomeCli = new System.Windows.Forms.TextBox();
        this.botaoRegistrar = new System.Windows.Forms.Button();
        this.buttonCancelar = new System.Windows.Forms.Button();
        this.labelCliente = new System.Windows.Forms.Label();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.textPago = new System.Windows.Forms.TextBox();
        this.label5 = new System.Windows.Forms.Label();
        this.textTotal = new System.Windows.Forms.TextBox();
        this.labelTotal = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.dateDevolucao = new System.Windows.Forms.DateTimePicker();
        this.label6 = new System.Windows.Forms.Label();
        this.groupBox1.SuspendLayout();
        this.SuspendLayout();
        // 
        // botaoPesqNome
        // 
        this.botaoPesqNome.Location = new System.Drawing.Point(695, 26);
        this.botaoPesqNome.Name = "botaoPesqNome";
        this.botaoPesqNome.Size = new System.Drawing.Size(20, 20);
        this.botaoPesqNome.TabIndex = 8;
        this.botaoPesqNome.Text = "P";
        this.botaoPesqNome.UseVisualStyleBackColor = true;
        this.botaoPesqNome.Click += new System.EventHandler(this.botaoPesqNome_Click);
        // 
        // botaoPesqCpf
        // 
        this.botaoPesqCpf.Location = new System.Drawing.Point(239, 25);
        this.botaoPesqCpf.Name = "botaoPesqCpf";
        this.botaoPesqCpf.Size = new System.Drawing.Size(20, 20);
        this.botaoPesqCpf.TabIndex = 5;
        this.botaoPesqCpf.Text = "P";
        this.botaoPesqCpf.UseVisualStyleBackColor = true;
        this.botaoPesqCpf.Click += new System.EventHandler(this.botaoPesqCpf_Click);
        // 
        // botaoPesqCod
        // 
        this.botaoPesqCod.Location = new System.Drawing.Point(116, 25);
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
        this.maskedCPFCli.Location = new System.Drawing.Point(145, 26);
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
        this.label7.Location = new System.Drawing.Point(142, 10);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(30, 13);
        this.label7.TabIndex = 3;
        this.label7.Text = "CPF:";
        // 
        // textCodigo
        // 
        this.textCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.textCodigo.Location = new System.Drawing.Point(12, 26);
        this.textCodigo.MaxLength = 5;
        this.textCodigo.Name = "textCodigo";
        this.textCodigo.Size = new System.Drawing.Size(98, 20);
        this.textCodigo.TabIndex = 1;
        // 
        // labelCPF
        // 
        this.labelCPF.AutoSize = true;
        this.labelCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.labelCPF.Location = new System.Drawing.Point(9, 10);
        this.labelCPF.Name = "labelCPF";
        this.labelCPF.Size = new System.Drawing.Size(43, 13);
        this.labelCPF.TabIndex = 0;
        this.labelCPF.Text = "Código:";
        // 
        // textNomeCli
        // 
        this.textNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.textNomeCli.Location = new System.Drawing.Point(279, 26);
        this.textNomeCli.MaxLength = 150;
        this.textNomeCli.Name = "textNomeCli";
        this.textNomeCli.Size = new System.Drawing.Size(410, 20);
        this.textNomeCli.TabIndex = 7;
        // 
        // botaoRegistrar
        // 
        this.botaoRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.botaoRegistrar.Location = new System.Drawing.Point(526, 303);
        this.botaoRegistrar.Name = "botaoRegistrar";
        this.botaoRegistrar.Size = new System.Drawing.Size(108, 23);
        this.botaoRegistrar.TabIndex = 12;
        this.botaoRegistrar.Text = "&Registrar PGTO";
        this.botaoRegistrar.UseVisualStyleBackColor = true;
        this.botaoRegistrar.Click += new System.EventHandler(this.botaoRegistrar_Click);
        // 
        // buttonCancelar
        // 
        this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.buttonCancelar.Location = new System.Drawing.Point(640, 303);
        this.buttonCancelar.Name = "buttonCancelar";
        this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
        this.buttonCancelar.TabIndex = 13;
        this.buttonCancelar.Text = "&Fechar";
        this.buttonCancelar.UseVisualStyleBackColor = true;
        this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
        // 
        // labelCliente
        // 
        this.labelCliente.AutoSize = true;
        this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.labelCliente.Location = new System.Drawing.Point(276, 9);
        this.labelCliente.Name = "labelCliente";
        this.labelCliente.Size = new System.Drawing.Size(42, 13);
        this.labelCliente.TabIndex = 6;
        this.labelCliente.Text = "Cliente:";
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.textPago);
        this.groupBox1.Controls.Add(this.label5);
        this.groupBox1.Controls.Add(this.textTotal);
        this.groupBox1.Controls.Add(this.labelTotal);
        this.groupBox1.Controls.Add(this.label4);
        this.groupBox1.Location = new System.Drawing.Point(302, 118);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(123, 116);
        this.groupBox1.TabIndex = 11;
        this.groupBox1.TabStop = false;
        // 
        // textPago
        // 
        this.textPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.textPago.Location = new System.Drawing.Point(24, 80);
        this.textPago.MaxLength = 5;
        this.textPago.Name = "textPago";
        this.textPago.Size = new System.Drawing.Size(75, 20);
        this.textPago.TabIndex = 4;
        this.textPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label5.Location = new System.Drawing.Point(21, 64);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(52, 13);
        this.label5.TabIndex = 3;
        this.label5.Text = "Pago: R$";
        // 
        // textTotal
        // 
        this.textTotal.Enabled = false;
        this.textTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.textTotal.Location = new System.Drawing.Point(23, 32);
        this.textTotal.Name = "textTotal";
        this.textTotal.Size = new System.Drawing.Size(76, 20);
        this.textTotal.TabIndex = 1;
        this.textTotal.Text = "0,00";
        this.textTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // labelTotal
        // 
        this.labelTotal.AutoSize = true;
        this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.labelTotal.Location = new System.Drawing.Point(87, 39);
        this.labelTotal.Name = "labelTotal";
        this.labelTotal.Size = new System.Drawing.Size(0, 13);
        this.labelTotal.TabIndex = 2;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(20, 16);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(51, 13);
        this.label4.TabIndex = 0;
        this.label4.Text = "Total: R$";
        // 
        // dateDevolucao
        // 
        this.dateDevolucao.Enabled = false;
        this.dateDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.dateDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateDevolucao.Location = new System.Drawing.Point(302, 92);
        this.dateDevolucao.Name = "dateDevolucao";
        this.dateDevolucao.Size = new System.Drawing.Size(123, 20);
        this.dateDevolucao.TabIndex = 10;
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label6.Location = new System.Drawing.Point(300, 76);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(96, 13);
        this.label6.TabIndex = 9;
        this.label6.Text = "Data da Transção:";
        // 
        // ConsultaDebito
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(725, 338);
        this.Controls.Add(this.groupBox1);
        this.Controls.Add(this.botaoPesqNome);
        this.Controls.Add(this.botaoPesqCpf);
        this.Controls.Add(this.botaoPesqCod);
        this.Controls.Add(this.maskedCPFCli);
        this.Controls.Add(this.dateDevolucao);
        this.Controls.Add(this.label7);
        this.Controls.Add(this.label6);
        this.Controls.Add(this.textCodigo);
        this.Controls.Add(this.labelCPF);
        this.Controls.Add(this.textNomeCli);
        this.Controls.Add(this.botaoRegistrar);
        this.Controls.Add(this.buttonCancelar);
        this.Controls.Add(this.labelCliente);
        this.MaximizeBox = false;
        this.Name = "ConsultaDebito";
        this.Text = "Cine+ Pagamento de débito";
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button botaoPesqNome;
    private System.Windows.Forms.Button botaoPesqCpf;
    private System.Windows.Forms.Button botaoPesqCod;
    private System.Windows.Forms.MaskedTextBox maskedCPFCli;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox textCodigo;
    private System.Windows.Forms.Label labelCPF;
    private System.Windows.Forms.TextBox textNomeCli;
    private System.Windows.Forms.Button botaoRegistrar;
    private System.Windows.Forms.Button buttonCancelar;
    private System.Windows.Forms.Label labelCliente;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox textPago;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textTotal;
    private System.Windows.Forms.Label labelTotal;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.DateTimePicker dateDevolucao;
    private System.Windows.Forms.Label label6;
  }
}