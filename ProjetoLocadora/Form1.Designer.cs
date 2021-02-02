namespace ProjetoLocadora
{
  partial class FormPrincipal
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
        this.menuStripLocadora = new System.Windows.Forms.MenuStrip();
        this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.filmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
        this.filmeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        this.usuárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        this.debitosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.movimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.locaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.devoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.quitarDébitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.trocarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.definirPreçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        this.groupBoxLocaocao = new System.Windows.Forms.GroupBox();
        this.label9 = new System.Windows.Forms.Label();
        this.buttonPesquisar1 = new System.Windows.Forms.Button();
        this.buttonLimpar1 = new System.Windows.Forms.Button();
        this.label5 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.maskedloccpf = new System.Windows.Forms.MaskedTextBox();
        this.textlocnome = new System.Windows.Forms.TextBox();
        this.textloccodigo = new System.Windows.Forms.TextBox();
        this.radioButton3 = new System.Windows.Forms.RadioButton();
        this.radioButton2 = new System.Windows.Forms.RadioButton();
        this.radioButton1 = new System.Windows.Forms.RadioButton();
        this.groupBoxDevolucao = new System.Windows.Forms.GroupBox();
        this.label10 = new System.Windows.Forms.Label();
        this.buttonPesquisar2 = new System.Windows.Forms.Button();
        this.label6 = new System.Windows.Forms.Label();
        this.buttonLimpar2 = new System.Windows.Forms.Button();
        this.label7 = new System.Windows.Forms.Label();
        this.label8 = new System.Windows.Forms.Label();
        this.maskeddevcpf = new System.Windows.Forms.MaskedTextBox();
        this.textdevnome = new System.Windows.Forms.TextBox();
        this.textdevcodigo = new System.Windows.Forms.TextBox();
        this.radioButton4 = new System.Windows.Forms.RadioButton();
        this.radioButton5 = new System.Windows.Forms.RadioButton();
        this.radioButton6 = new System.Windows.Forms.RadioButton();
        this.groupLogin = new System.Windows.Forms.GroupBox();
        this.botaoEntrar = new System.Windows.Forms.Button();
        this.textSenha = new System.Windows.Forms.TextBox();
        this.textUsuario = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.menuStripLocadora.SuspendLayout();
        this.groupBoxLocaocao.SuspendLayout();
        this.groupBoxDevolucao.SuspendLayout();
        this.groupLogin.SuspendLayout();
        this.SuspendLayout();
        // 
        // menuStripLocadora
        // 
        this.menuStripLocadora.BackColor = System.Drawing.Color.Lavender;
        this.menuStripLocadora.Enabled = false;
        this.menuStripLocadora.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem,
            this.opçõesToolStripMenuItem,
            this.sairToolStripMenuItem1});
        this.menuStripLocadora.Location = new System.Drawing.Point(0, 0);
        this.menuStripLocadora.Name = "menuStripLocadora";
        this.menuStripLocadora.Size = new System.Drawing.Size(725, 24);
        this.menuStripLocadora.TabIndex = 1;
        this.menuStripLocadora.Text = "menuStrip1";
        // 
        // testeToolStripMenuItem
        // 
        this.testeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.movimentaçõesToolStripMenuItem,
            this.trocarUsuárioToolStripMenuItem});
        this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
        this.testeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
        this.testeToolStripMenuItem.Text = "Menu";
        // 
        // testToolStripMenuItem
        // 
        this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.filmeToolStripMenuItem,
            this.usuárioToolStripMenuItem});
        this.testToolStripMenuItem.Name = "testToolStripMenuItem";
        this.testToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
        this.testToolStripMenuItem.Text = "&Cadastros";
        // 
        // clienteToolStripMenuItem
        // 
        this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
        this.clienteToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
        this.clienteToolStripMenuItem.Text = "Cli&ente";
        this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
        // 
        // filmeToolStripMenuItem
        // 
        this.filmeToolStripMenuItem.Name = "filmeToolStripMenuItem";
        this.filmeToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
        this.filmeToolStripMenuItem.Text = "&Filme";
        this.filmeToolStripMenuItem.Click += new System.EventHandler(this.filmeToolStripMenuItem_Click);
        // 
        // usuárioToolStripMenuItem
        // 
        this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
        this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
        this.usuárioToolStripMenuItem.Text = "&Usuário";
        this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
        // 
        // consultasToolStripMenuItem
        // 
        this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.filmeToolStripMenuItem1,
            this.usuárioToolStripMenuItem1,
            this.debitosToolStripMenuItem});
        this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
        this.consultasToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
        this.consultasToolStripMenuItem.Text = "Co&nsultas";
        // 
        // toolStripMenuItem2
        // 
        this.toolStripMenuItem2.Name = "toolStripMenuItem2";
        this.toolStripMenuItem2.Size = new System.Drawing.Size(114, 22);
        this.toolStripMenuItem2.Text = "&Cliente";
        this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
        // 
        // filmeToolStripMenuItem1
        // 
        this.filmeToolStripMenuItem1.Name = "filmeToolStripMenuItem1";
        this.filmeToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
        this.filmeToolStripMenuItem1.Text = "&Filme";
        this.filmeToolStripMenuItem1.Click += new System.EventHandler(this.filmeToolStripMenuItem1_Click);
        // 
        // usuárioToolStripMenuItem1
        // 
        this.usuárioToolStripMenuItem1.Name = "usuárioToolStripMenuItem1";
        this.usuárioToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
        this.usuárioToolStripMenuItem1.Text = "&Usuário";
        this.usuárioToolStripMenuItem1.Click += new System.EventHandler(this.usuárioToolStripMenuItem1_Click);
        // 
        // debitosToolStripMenuItem
        // 
        this.debitosToolStripMenuItem.Name = "debitosToolStripMenuItem";
        this.debitosToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
        this.debitosToolStripMenuItem.Text = "&Débitos";
        this.debitosToolStripMenuItem.Click += new System.EventHandler(this.débitosToolStripMenuItem_Click);
        // 
        // movimentaçõesToolStripMenuItem
        // 
        this.movimentaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locaçãoToolStripMenuItem,
            this.devoluçãoToolStripMenuItem,
            this.quitarDébitoToolStripMenuItem});
        this.movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
        this.movimentaçõesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
        this.movimentaçõesToolStripMenuItem.Text = "&Movimentação";
        // 
        // locaçãoToolStripMenuItem
        // 
        this.locaçãoToolStripMenuItem.Name = "locaçãoToolStripMenuItem";
        this.locaçãoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
        this.locaçãoToolStripMenuItem.Text = "&Locação";
        this.locaçãoToolStripMenuItem.Click += new System.EventHandler(this.locaçãoToolStripMenuItem_Click);
        // 
        // devoluçãoToolStripMenuItem
        // 
        this.devoluçãoToolStripMenuItem.Name = "devoluçãoToolStripMenuItem";
        this.devoluçãoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
        this.devoluçãoToolStripMenuItem.Text = "&Devolução";
        this.devoluçãoToolStripMenuItem.Click += new System.EventHandler(this.devoluçãoToolStripMenuItem_Click);
        // 
        // quitarDébitoToolStripMenuItem
        // 
        this.quitarDébitoToolStripMenuItem.Name = "quitarDébitoToolStripMenuItem";
        this.quitarDébitoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
        this.quitarDébitoToolStripMenuItem.Text = "&Quitar Débito";
        this.quitarDébitoToolStripMenuItem.Click += new System.EventHandler(this.quitarDébitoToolStripMenuItem_Click);
        // 
        // trocarUsuárioToolStripMenuItem
        // 
        this.trocarUsuárioToolStripMenuItem.Name = "trocarUsuárioToolStripMenuItem";
        this.trocarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
        this.trocarUsuárioToolStripMenuItem.Text = "&Trocar Usuário";
        this.trocarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.logoffToolStripMenuItem_Click);
        // 
        // opçõesToolStripMenuItem
        // 
        this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.definirPreçoToolStripMenuItem});
        this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
        this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
        this.opçõesToolStripMenuItem.Text = "&Opções";
        // 
        // definirPreçoToolStripMenuItem
        // 
        this.definirPreçoToolStripMenuItem.Name = "definirPreçoToolStripMenuItem";
        this.definirPreçoToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
        this.definirPreçoToolStripMenuItem.Text = "&Definir preço";
        this.definirPreçoToolStripMenuItem.Click += new System.EventHandler(this.definirPreçoToolStripMenuItem_Click);
        // 
        // sairToolStripMenuItem1
        // 
        this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
        this.sairToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
        this.sairToolStripMenuItem1.Text = "&Sair";
        this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
        // 
        // groupBoxLocaocao
        // 
        this.groupBoxLocaocao.Controls.Add(this.label9);
        this.groupBoxLocaocao.Controls.Add(this.buttonPesquisar1);
        this.groupBoxLocaocao.Controls.Add(this.buttonLimpar1);
        this.groupBoxLocaocao.Controls.Add(this.label5);
        this.groupBoxLocaocao.Controls.Add(this.label4);
        this.groupBoxLocaocao.Controls.Add(this.label3);
        this.groupBoxLocaocao.Controls.Add(this.maskedloccpf);
        this.groupBoxLocaocao.Controls.Add(this.textlocnome);
        this.groupBoxLocaocao.Controls.Add(this.textloccodigo);
        this.groupBoxLocaocao.Controls.Add(this.radioButton3);
        this.groupBoxLocaocao.Controls.Add(this.radioButton2);
        this.groupBoxLocaocao.Controls.Add(this.radioButton1);
        this.groupBoxLocaocao.Location = new System.Drawing.Point(12, 57);
        this.groupBoxLocaocao.Name = "groupBoxLocaocao";
        this.groupBoxLocaocao.Size = new System.Drawing.Size(701, 220);
        this.groupBoxLocaocao.TabIndex = 2;
        this.groupBoxLocaocao.TabStop = false;
        this.groupBoxLocaocao.Text = "Atalho para Locação";
        this.groupBoxLocaocao.Visible = false;
        // 
        // label9
        // 
        this.label9.AutoSize = true;
        this.label9.Location = new System.Drawing.Point(261, 20);
        this.label9.Name = "label9";
        this.label9.Size = new System.Drawing.Size(179, 13);
        this.label9.TabIndex = 0;
        this.label9.Text = "Selecione uma opção para pesquisa";
        // 
        // buttonPesquisar1
        // 
        this.buttonPesquisar1.Location = new System.Drawing.Point(539, 191);
        this.buttonPesquisar1.Name = "buttonPesquisar1";
        this.buttonPesquisar1.Size = new System.Drawing.Size(75, 23);
        this.buttonPesquisar1.TabIndex = 10;
        this.buttonPesquisar1.Text = "Pesquisar";
        this.buttonPesquisar1.UseVisualStyleBackColor = true;
        this.buttonPesquisar1.Click += new System.EventHandler(this.botaoPesquisaLocacao);
        // 
        // buttonLimpar1
        // 
        this.buttonLimpar1.Location = new System.Drawing.Point(620, 191);
        this.buttonLimpar1.Name = "buttonLimpar1";
        this.buttonLimpar1.Size = new System.Drawing.Size(75, 23);
        this.buttonLimpar1.TabIndex = 11;
        this.buttonLimpar1.Text = "Limpar";
        this.buttonLimpar1.UseVisualStyleBackColor = true;
        this.buttonLimpar1.Click += new System.EventHandler(this.botaoLimpar_Click);
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(28, 139);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(38, 13);
        this.label5.TabIndex = 7;
        this.label5.Text = "Nome:";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(30, 95);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(30, 13);
        this.label4.TabIndex = 4;
        this.label4.Text = "CPF:";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(28, 55);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(43, 13);
        this.label3.TabIndex = 1;
        this.label3.Text = "Código:";
        // 
        // maskedloccpf
        // 
        this.maskedloccpf.Enabled = false;
        this.maskedloccpf.Location = new System.Drawing.Point(31, 111);
        this.maskedloccpf.Mask = "999,999,999-99";
        this.maskedloccpf.Name = "maskedloccpf";
        this.maskedloccpf.Size = new System.Drawing.Size(100, 20);
        this.maskedloccpf.TabIndex = 5;
        this.maskedloccpf.Tag = "2";
        this.maskedloccpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
        this.maskedloccpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pesqFilmeLocacao_KeyPress);
        // 
        // textlocnome
        // 
        this.textlocnome.Enabled = false;
        this.textlocnome.Location = new System.Drawing.Point(31, 155);
        this.textlocnome.MaxLength = 150;
        this.textlocnome.Name = "textlocnome";
        this.textlocnome.Size = new System.Drawing.Size(447, 20);
        this.textlocnome.TabIndex = 8;
        this.textlocnome.Tag = "3";
        this.textlocnome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pesqFilmeLocacao_KeyPress);
        // 
        // textloccodigo
        // 
        this.textloccodigo.Location = new System.Drawing.Point(31, 71);
        this.textloccodigo.MaxLength = 5;
        this.textloccodigo.Name = "textloccodigo";
        this.textloccodigo.Size = new System.Drawing.Size(100, 20);
        this.textloccodigo.TabIndex = 2;
        this.textloccodigo.Tag = "1";
        this.textloccodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pesqFilmeLocacao_KeyPress);
        // 
        // radioButton3
        // 
        this.radioButton3.AutoSize = true;
        this.radioButton3.Location = new System.Drawing.Point(11, 158);
        this.radioButton3.Name = "radioButton3";
        this.radioButton3.Size = new System.Drawing.Size(14, 13);
        this.radioButton3.TabIndex = 9;
        this.radioButton3.Tag = "3";
        this.radioButton3.UseVisualStyleBackColor = true;
        this.radioButton3.Click += new System.EventHandler(this.radioAlterna_click);
        // 
        // radioButton2
        // 
        this.radioButton2.AutoSize = true;
        this.radioButton2.Location = new System.Drawing.Point(11, 118);
        this.radioButton2.Name = "radioButton2";
        this.radioButton2.Size = new System.Drawing.Size(14, 13);
        this.radioButton2.TabIndex = 6;
        this.radioButton2.Tag = "2";
        this.radioButton2.UseVisualStyleBackColor = true;
        this.radioButton2.Click += new System.EventHandler(this.radioAlterna_click);
        // 
        // radioButton1
        // 
        this.radioButton1.AutoSize = true;
        this.radioButton1.Checked = true;
        this.radioButton1.Location = new System.Drawing.Point(11, 78);
        this.radioButton1.Name = "radioButton1";
        this.radioButton1.Size = new System.Drawing.Size(14, 13);
        this.radioButton1.TabIndex = 3;
        this.radioButton1.TabStop = true;
        this.radioButton1.Tag = "1";
        this.radioButton1.UseVisualStyleBackColor = true;
        this.radioButton1.Click += new System.EventHandler(this.radioAlterna_click);
        // 
        // groupBoxDevolucao
        // 
        this.groupBoxDevolucao.Controls.Add(this.label10);
        this.groupBoxDevolucao.Controls.Add(this.buttonPesquisar2);
        this.groupBoxDevolucao.Controls.Add(this.label6);
        this.groupBoxDevolucao.Controls.Add(this.buttonLimpar2);
        this.groupBoxDevolucao.Controls.Add(this.label7);
        this.groupBoxDevolucao.Controls.Add(this.label8);
        this.groupBoxDevolucao.Controls.Add(this.maskeddevcpf);
        this.groupBoxDevolucao.Controls.Add(this.textdevnome);
        this.groupBoxDevolucao.Controls.Add(this.textdevcodigo);
        this.groupBoxDevolucao.Controls.Add(this.radioButton4);
        this.groupBoxDevolucao.Controls.Add(this.radioButton5);
        this.groupBoxDevolucao.Controls.Add(this.radioButton6);
        this.groupBoxDevolucao.Location = new System.Drawing.Point(12, 295);
        this.groupBoxDevolucao.Name = "groupBoxDevolucao";
        this.groupBoxDevolucao.Size = new System.Drawing.Size(701, 220);
        this.groupBoxDevolucao.TabIndex = 3;
        this.groupBoxDevolucao.TabStop = false;
        this.groupBoxDevolucao.Text = "Atalho para Devolução";
        this.groupBoxDevolucao.Visible = false;
        // 
        // label10
        // 
        this.label10.AutoSize = true;
        this.label10.Location = new System.Drawing.Point(261, 16);
        this.label10.Name = "label10";
        this.label10.Size = new System.Drawing.Size(179, 13);
        this.label10.TabIndex = 0;
        this.label10.Text = "Selecione uma opção para pesquisa";
        // 
        // buttonPesquisar2
        // 
        this.buttonPesquisar2.Location = new System.Drawing.Point(539, 191);
        this.buttonPesquisar2.Name = "buttonPesquisar2";
        this.buttonPesquisar2.Size = new System.Drawing.Size(75, 23);
        this.buttonPesquisar2.TabIndex = 10;
        this.buttonPesquisar2.Text = "Pesquisar";
        this.buttonPesquisar2.UseVisualStyleBackColor = true;
        this.buttonPesquisar2.Click += new System.EventHandler(this.botaoPesquisaDevolucao);
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new System.Drawing.Point(28, 139);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(38, 13);
        this.label6.TabIndex = 7;
        this.label6.Text = "Nome:";
        // 
        // buttonLimpar2
        // 
        this.buttonLimpar2.Location = new System.Drawing.Point(620, 191);
        this.buttonLimpar2.Name = "buttonLimpar2";
        this.buttonLimpar2.Size = new System.Drawing.Size(75, 23);
        this.buttonLimpar2.TabIndex = 11;
        this.buttonLimpar2.Text = "Limpar";
        this.buttonLimpar2.UseVisualStyleBackColor = true;
        this.buttonLimpar2.Click += new System.EventHandler(this.botaoLimpar_Click);
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Location = new System.Drawing.Point(30, 95);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(30, 13);
        this.label7.TabIndex = 4;
        this.label7.Text = "CPF:";
        // 
        // label8
        // 
        this.label8.AutoSize = true;
        this.label8.Location = new System.Drawing.Point(28, 55);
        this.label8.Name = "label8";
        this.label8.Size = new System.Drawing.Size(43, 13);
        this.label8.TabIndex = 1;
        this.label8.Text = "Código:";
        // 
        // maskeddevcpf
        // 
        this.maskeddevcpf.Enabled = false;
        this.maskeddevcpf.Location = new System.Drawing.Point(31, 111);
        this.maskeddevcpf.Mask = "999,999,999-99";
        this.maskeddevcpf.Name = "maskeddevcpf";
        this.maskeddevcpf.Size = new System.Drawing.Size(100, 20);
        this.maskeddevcpf.TabIndex = 5;
        this.maskeddevcpf.Tag = "5";
        this.maskeddevcpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
        this.maskeddevcpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pesqFilmeDevolucao_KeyPress);
        // 
        // textdevnome
        // 
        this.textdevnome.Enabled = false;
        this.textdevnome.Location = new System.Drawing.Point(31, 155);
        this.textdevnome.MaxLength = 150;
        this.textdevnome.Name = "textdevnome";
        this.textdevnome.Size = new System.Drawing.Size(447, 20);
        this.textdevnome.TabIndex = 8;
        this.textdevnome.Tag = "6";
        this.textdevnome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pesqFilmeDevolucao_KeyPress);
        // 
        // textdevcodigo
        // 
        this.textdevcodigo.Location = new System.Drawing.Point(31, 71);
        this.textdevcodigo.MaxLength = 5;
        this.textdevcodigo.Name = "textdevcodigo";
        this.textdevcodigo.Size = new System.Drawing.Size(100, 20);
        this.textdevcodigo.TabIndex = 2;
        this.textdevcodigo.Tag = "4";
        this.textdevcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pesqFilmeDevolucao_KeyPress);
        // 
        // radioButton4
        // 
        this.radioButton4.AutoSize = true;
        this.radioButton4.Location = new System.Drawing.Point(11, 158);
        this.radioButton4.Name = "radioButton4";
        this.radioButton4.Size = new System.Drawing.Size(14, 13);
        this.radioButton4.TabIndex = 9;
        this.radioButton4.Tag = "6";
        this.radioButton4.UseVisualStyleBackColor = true;
        this.radioButton4.Click += new System.EventHandler(this.radioAlterna_click);
        // 
        // radioButton5
        // 
        this.radioButton5.AutoSize = true;
        this.radioButton5.Location = new System.Drawing.Point(11, 118);
        this.radioButton5.Name = "radioButton5";
        this.radioButton5.Size = new System.Drawing.Size(14, 13);
        this.radioButton5.TabIndex = 6;
        this.radioButton5.Tag = "5";
        this.radioButton5.UseVisualStyleBackColor = true;
        this.radioButton5.Click += new System.EventHandler(this.radioAlterna_click);
        // 
        // radioButton6
        // 
        this.radioButton6.AutoSize = true;
        this.radioButton6.Checked = true;
        this.radioButton6.Location = new System.Drawing.Point(11, 78);
        this.radioButton6.Name = "radioButton6";
        this.radioButton6.Size = new System.Drawing.Size(14, 13);
        this.radioButton6.TabIndex = 3;
        this.radioButton6.TabStop = true;
        this.radioButton6.Tag = "4";
        this.radioButton6.UseVisualStyleBackColor = true;
        this.radioButton6.Click += new System.EventHandler(this.radioAlterna_click);
        // 
        // groupLogin
        // 
        this.groupLogin.Controls.Add(this.botaoEntrar);
        this.groupLogin.Controls.Add(this.textSenha);
        this.groupLogin.Controls.Add(this.textUsuario);
        this.groupLogin.Controls.Add(this.label2);
        this.groupLogin.Controls.Add(this.label1);
        this.groupLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.groupLogin.Location = new System.Drawing.Point(285, 219);
        this.groupLogin.Name = "groupLogin";
        this.groupLogin.Size = new System.Drawing.Size(154, 134);
        this.groupLogin.TabIndex = 0;
        this.groupLogin.TabStop = false;
        this.groupLogin.Text = "Login";
        // 
        // botaoEntrar
        // 
        this.botaoEntrar.Location = new System.Drawing.Point(41, 100);
        this.botaoEntrar.Name = "botaoEntrar";
        this.botaoEntrar.Size = new System.Drawing.Size(75, 23);
        this.botaoEntrar.TabIndex = 4;
        this.botaoEntrar.Text = "Entrar";
        this.botaoEntrar.UseVisualStyleBackColor = true;
        this.botaoEntrar.Click += new System.EventHandler(this.button1_Click);
        // 
        // textSenha
        // 
        this.textSenha.Location = new System.Drawing.Point(29, 74);
        this.textSenha.MaxLength = 20;
        this.textSenha.Name = "textSenha";
        this.textSenha.PasswordChar = '*';
        this.textSenha.Size = new System.Drawing.Size(100, 20);
        this.textSenha.TabIndex = 3;
        this.textSenha.TextChanged += new System.EventHandler(this.textSenha_TextChanged);
        this.textSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSenha_KeyPress);
        // 
        // textUsuario
        // 
        this.textUsuario.Location = new System.Drawing.Point(30, 36);
        this.textUsuario.MaxLength = 15;
        this.textUsuario.Name = "textUsuario";
        this.textUsuario.Size = new System.Drawing.Size(100, 20);
        this.textUsuario.TabIndex = 1;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(26, 59);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(47, 13);
        this.label2.TabIndex = 2;
        this.label2.Text = "Senha:";
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(26, 20);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(54, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "Usuário:";
        // 
        // FormPrincipal
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(725, 573);
        this.Controls.Add(this.groupLogin);
        this.Controls.Add(this.groupBoxDevolucao);
        this.Controls.Add(this.groupBoxLocaocao);
        this.Controls.Add(this.menuStripLocadora);
        this.MainMenuStrip = this.menuStripLocadora;
        this.MaximizeBox = false;
        this.Name = "FormPrincipal";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Tag = "1";
        this.Text = "Cine+";
        this.menuStripLocadora.ResumeLayout(false);
        this.menuStripLocadora.PerformLayout();
        this.groupBoxLocaocao.ResumeLayout(false);
        this.groupBoxLocaocao.PerformLayout();
        this.groupBoxDevolucao.ResumeLayout(false);
        this.groupBoxDevolucao.PerformLayout();
        this.groupLogin.ResumeLayout(false);
        this.groupLogin.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStripLocadora;
    private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem filmeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem filmeToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem debitosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem devoluçãoToolStripMenuItem;
    private System.Windows.Forms.GroupBox groupBoxLocaocao;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.MaskedTextBox maskedloccpf;
    private System.Windows.Forms.TextBox textlocnome;
    private System.Windows.Forms.TextBox textloccodigo;
    private System.Windows.Forms.RadioButton radioButton3;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.GroupBox groupBoxDevolucao;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.MaskedTextBox maskeddevcpf;
    private System.Windows.Forms.TextBox textdevnome;
    private System.Windows.Forms.TextBox textdevcodigo;
    private System.Windows.Forms.RadioButton radioButton4;
    private System.Windows.Forms.RadioButton radioButton5;
    private System.Windows.Forms.RadioButton radioButton6;
    private System.Windows.Forms.Button buttonPesquisar1;
    private System.Windows.Forms.Button buttonLimpar1;
    private System.Windows.Forms.Button buttonPesquisar2;
    private System.Windows.Forms.Button buttonLimpar2;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem trocarUsuárioToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem quitarDébitoToolStripMenuItem;
    private System.Windows.Forms.GroupBox groupLogin;
    private System.Windows.Forms.Button botaoEntrar;
    private System.Windows.Forms.TextBox textSenha;
    private System.Windows.Forms.TextBox textUsuario;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem definirPreçoToolStripMenuItem;
  }
}

