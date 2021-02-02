namespace ProjetoLocadora
{
  partial class ConfirmaClienteDev
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
        this.botaoCancela = new System.Windows.Forms.Button();
        this.BotaoConfirma = new System.Windows.Forms.Button();
        this.listViewConfirma = new System.Windows.Forms.ListView();
        this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.label1 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // botaoCancela
        // 
        this.botaoCancela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.botaoCancela.Location = new System.Drawing.Point(637, 266);
        this.botaoCancela.Name = "botaoCancela";
        this.botaoCancela.Size = new System.Drawing.Size(75, 23);
        this.botaoCancela.TabIndex = 3;
        this.botaoCancela.Text = "C&ancela";
        this.botaoCancela.UseVisualStyleBackColor = true;
        this.botaoCancela.Click += new System.EventHandler(this.botaoCancela_Click);
        // 
        // BotaoConfirma
        // 
        this.BotaoConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.BotaoConfirma.Location = new System.Drawing.Point(556, 266);
        this.BotaoConfirma.Name = "BotaoConfirma";
        this.BotaoConfirma.Size = new System.Drawing.Size(75, 23);
        this.BotaoConfirma.TabIndex = 2;
        this.BotaoConfirma.Text = "&Confirma";
        this.BotaoConfirma.UseVisualStyleBackColor = true;
        this.BotaoConfirma.Click += new System.EventHandler(this.botaoConfirma_click);
        // 
        // listViewConfirma
        // 
        this.listViewConfirma.BackColor = System.Drawing.Color.Lavender;
        this.listViewConfirma.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
        this.listViewConfirma.FullRowSelect = true;
        this.listViewConfirma.GridLines = true;
        this.listViewConfirma.Location = new System.Drawing.Point(12, 40);
        this.listViewConfirma.MultiSelect = false;
        this.listViewConfirma.Name = "listViewConfirma";
        this.listViewConfirma.Size = new System.Drawing.Size(700, 209);
        this.listViewConfirma.TabIndex = 1;
        this.listViewConfirma.UseCompatibleStateImageBehavior = false;
        this.listViewConfirma.View = System.Windows.Forms.View.Details;
        this.listViewConfirma.Click += new System.EventHandler(this.selecionaItem_Click);
        // 
        // columnHeader1
        // 
        this.columnHeader1.Text = "Código";
        this.columnHeader1.Width = 80;
        // 
        // columnHeader2
        // 
        this.columnHeader2.Text = "CPF";
        this.columnHeader2.Width = 80;
        // 
        // columnHeader3
        // 
        this.columnHeader3.Text = "Nome";
        this.columnHeader3.Width = 250;
        // 
        // columnHeader4
        // 
        this.columnHeader4.Text = "Endereço";
        this.columnHeader4.Width = 285;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(12, 13);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(317, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "Verifique os dados do cliente, selecione e confirme para proceguir";
        // 
        // ConfirmaClienteDev
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(725, 301);
        this.Controls.Add(this.botaoCancela);
        this.Controls.Add(this.BotaoConfirma);
        this.Controls.Add(this.listViewConfirma);
        this.Controls.Add(this.label1);
        this.MaximizeBox = false;
        this.Name = "ConfirmaClienteDev";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Cine+ Devolução";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button botaoCancela;
    private System.Windows.Forms.Button BotaoConfirma;
    private System.Windows.Forms.ListView listViewConfirma;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.Label label1;

  }
}