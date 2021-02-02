using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoLocadora
{
  public partial class FormPrincipal : Form
  {
    string usuarioNome = "";
    public string usuarioID = "";

    public FormPrincipal()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      SqlConnection conexao = new SqlConnection("Data Source = (local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
      conexao.Open();

      string Query = "select Senha_US as senha, Cod_Us, Nome_Us, nivel_acesso as acesso from Acesso_Usuario where Login_US = @Usuario";

      SqlCommand pegacodigo;
      SqlParameter usuario = new SqlParameter("@Usuario", textUsuario.Text);

      pegacodigo = new SqlCommand(Query, conexao);
      pegacodigo.Parameters.Add(usuario);

      SqlDataReader dr;
      dr = pegacodigo.ExecuteReader();


      if (dr.Read() == false)
      {
        MessageBox.Show("Usuario Inesistente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        textUsuario.Clear();
        textSenha.Clear();
        textUsuario.TabIndex = 1;
        textSenha.TabIndex = 2;
        botaoEntrar.TabIndex = 3;
      }
      else 
          if (textSenha.Text == dr["senha"].ToString())
      {

        usuarioID = dr["Cod_Us"].ToString();
        usuarioNome = dr["Nome_Us"].ToString();
        groupBoxLocaocao.Visible = true;
        groupBoxDevolucao.Visible = true;
        menuStripLocadora.Enabled = true;
        Controls.Remove(groupLogin);
        setUsuarioAtivo();

        if (dr["acesso"].ToString() == "Nível Simples")
        {
           
            usuárioToolStripMenuItem.Enabled = false;
            debitosToolStripMenuItem.Enabled = false;
            usuárioToolStripMenuItem1.Enabled = false;
            definirPreçoToolStripMenuItem.Enabled = false;

        }
        else if (dr["acesso"].ToString() == "Nível Gerencial")
        {
            
            debitosToolStripMenuItem.Enabled = false;
            usuárioToolStripMenuItem1.Enabled = false;

        }
        else
        {
            groupBoxLocaocao.Visible = true;
            groupBoxDevolucao.Visible = true;
            menuStripLocadora.Enabled = true;
            
        }
      }
      else
      {
        MessageBox.Show("Senha inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        textSenha.Clear();
        textSenha.TabIndex = 1;
        botaoEntrar.TabIndex = 2;
        textUsuario.TabIndex = 3;
      }


      conexao.Close();
    }
    private void botaoLimpar_Click(object sender, EventArgs e)
    {
      limparForm();
    }
    private void limparForm()
    {
      foreach (Control ctrl in this.groupBoxLocaocao.Controls)
      {
        if (ctrl is TextBox || ctrl is MaskedTextBox)
        {
          ctrl.Text = "";
        }
      }
      foreach (Control ctrl in this.groupBoxDevolucao.Controls)
      {
        if (ctrl is TextBox || ctrl is MaskedTextBox)
        {
          ctrl.Text = "";
        }
      }
    }
    private void radioAlterna_click(object sender, EventArgs e)
    {
      RadioButton radio = (RadioButton)sender;
      if (radio.Tag.Equals("1"))
      {
        textloccodigo.Enabled = true;
        maskedloccpf.Enabled = false;
        textlocnome.Enabled = false;
        textloccodigo.Focus();
      }
      else if (radio.Tag.Equals("2"))
      {
        textloccodigo.Enabled = false;
        maskedloccpf.Enabled = true;
        textlocnome.Enabled = false;
        maskedloccpf.Focus();
      }
      else if (radio.Tag.Equals("3"))
      {
        textloccodigo.Enabled = false;
        maskedloccpf.Enabled = false;
        textlocnome.Enabled = true;
        textlocnome.Focus();
      }
      else if (radio.Tag.Equals("4"))
      {
        textdevcodigo.Enabled = true;
        maskeddevcpf.Enabled = false;
        textdevnome.Enabled = false;
        textdevcodigo.Focus();
      }
      else if (radio.Tag.Equals("5"))
      {
        textdevcodigo.Enabled = false;
        maskeddevcpf.Enabled = true;
        textdevnome.Enabled = false;
        maskeddevcpf.Focus();
      }
      else if (radio.Tag.Equals("6"))
      {
        textdevcodigo.Enabled = false;
        maskeddevcpf.Enabled = false;
        textdevnome.Enabled = true;
        textdevnome.Focus();
      }
    }
    private void botaoPesquisaLocacao(object sender, EventArgs e)
    {
      int campo = 0;
      string valor = "";
      if (textloccodigo.Enabled)
      {
        campo = 1;
        valor = textloccodigo.Text;
      }
      if (maskedloccpf.Enabled)
      {
        campo = 2;
        valor = maskedloccpf.Text;
      }
      if (textlocnome.Enabled)
      {
        campo = 3;
        valor = textlocnome.Text;
      }
      Locacao loc = new Locacao(usuarioID);
      ConfirmaCliente cli = new ConfirmaCliente(loc, valor, campo);
      loc.Show();
      cli.Show();
    }
    private void botaoPesquisaDevolucao(object sender, EventArgs e)
    {
      int campo = 0;
      string valor = "";
      if (textdevcodigo.Enabled)
      {
        campo = 1;
        valor = textdevcodigo.Text;
      }
      if (maskeddevcpf.Enabled)
      {
        campo = 2;
        valor = maskeddevcpf.Text;
      }
      if (textdevnome.Enabled)
      {
        campo = 3;
        valor = textlocnome.Text;
      }
      Devolucao dev = new Devolucao(usuarioID);
      ConfirmaClienteDev cli = new ConfirmaClienteDev(dev, valor, campo);
      dev.Show();
      cli.Show();
    }

    // Menu
    private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CadastroCliente cadcli = new CadastroCliente();
      cadcli.Show();
    }

    private void filmeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CadastroFilmes cadfil = new CadastroFilmes();
      cadfil.Show();
    }

    private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CadastroUsuario cadusu = new CadastroUsuario();
      cadusu.Show();
    }

    private void locaçãoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Locacao locacao = new Locacao(usuarioID);
      locacao.Show();
    }

    private void devoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Devolucao devolucao = new Devolucao(usuarioID);
      devolucao.Show();
    }

    private void textSenha_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((Keys)e.KeyChar == Keys.Enter)
        button1_Click(sender, e);
    }

    private void pesqFilmeDevolucao_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((Keys)e.KeyChar == Keys.Enter || (Keys)e.KeyChar == Keys.Tab)
        botaoPesquisaDevolucao(sender, e);
    }

    private void pesqFilmeLocacao_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((Keys)e.KeyChar == Keys.Enter || (Keys)e.KeyChar == Keys.Tab)
        botaoPesquisaLocacao(sender, e);
    }

    private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void botaoLimpaForm(object sender, EventArgs e)
    {
      limparFormPrincipal();
    }

    private void limparFormPrincipal()
    {
      foreach (Control ctrl in this.groupBoxLocaocao.Controls)
      {
        if (ctrl is TextBox || ctrl is MaskedTextBox || ctrl is ComboBox)
        {
          ctrl.Text = "";
        }
      }
      foreach (Control ctrl in this.groupBoxDevolucao.Controls)
      {
        if (ctrl is TextBox || ctrl is MaskedTextBox || ctrl is ComboBox)
        {
          ctrl.Text = "";
        }
      }
    }
    private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
    {
      groupBoxLocaocao.Visible = false;
      groupBoxDevolucao.Visible = false;
      menuStripLocadora.Enabled = false;
      Controls.Add(groupLogin);
      textUsuario.Clear();
      textSenha.Clear();
    }
    private void setUsuarioAtivo()
    {
      SqlConnection conexao = new SqlConnection("Data Source = (local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
      conexao.Open();

      string Query = "EXEC DBO.SETUSUARIOATIVO @COD, @NOME";

      SqlCommand atualizaUsuario = new SqlCommand(Query, conexao);;
      SqlParameter parametro = new SqlParameter("@COD", usuarioID);
      atualizaUsuario.Parameters.Add(parametro);
      parametro = new SqlParameter("@NOME", usuarioNome);
      atualizaUsuario.Parameters.Add(parametro);

      atualizaUsuario.ExecuteNonQuery();
      conexao.Close();
    }
    private void filmeToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      BuscaFilme buscar = new BuscaFilme();
      buscar.ShowDialog();
    }

    private void usuárioToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      BuscaUsuario buscar = new BuscaUsuario();
      buscar.ShowDialog();
    }

    private void toolStripMenuItem2_Click(object sender, EventArgs e)
    {
      BuscaCliente buscar = new BuscaCliente();
      buscar.ShowDialog();
    }

    private void débitosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      RelatorioDevedores relDed = new RelatorioDevedores();
      relDed.Show();
    }

    private void quitarDébitoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ConsultaDebito consultaDebito = new ConsultaDebito();
      consultaDebito.Show();
    }

    private void textSenha_TextChanged(object sender, EventArgs e)
    {
    }

    private void definirPreçoToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Definipreço define = new Definipreço();
        define.ShowDialog();
    }
  }
}
