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
  public partial class Locacao : Form
  {
    public int codigoDigitado;
    public string cpfcli;
    public string nomecli;
    public string usuarioID;
    Stack<ItemLocacao> listaLocacao = new Stack<ItemLocacao>();
    ItemLocacao itemLocacao = new ItemLocacao();
    int qtdeItens = 0;

    Filme objFilme = new Filme();
    float total = 0;

    SqlParameter parametro;
    SqlCommand selecionaCliente;
    SqlDataReader leitor;
    ConfirmaCliente formConfirma;

    public Locacao(string cu)
    {
      InitializeComponent();
      usuarioID = cu ;
    }

    public void botaoPesqCod_Click(object sender, EventArgs e)
    {
      string valor = textCodigo.Text;
      int campo = 1;

      if (!textCodigo.Text.Equals(""))
      {
        formConfirma = new ConfirmaCliente(this, valor, campo);
        formConfirma.Show();
      }
    }

    public void botaoPesqCpf_Click(object sender, EventArgs e)
    {
      string valor = maskedCPFCli.Text;
      int campo = 2;

      if (maskedCPFCli.Text.Length == 11)
      {
        formConfirma = new ConfirmaCliente(this, valor, campo);
        formConfirma.Show();
      }
    }

    public void botaoPesqNome_Click(object sender, EventArgs e)
    {
      string valor = textNomeCli.Text;
      int campo = 3;

      if (!textNomeCli.Text.Equals(""))
      {
        formConfirma = new ConfirmaCliente(this, valor, campo);
        formConfirma.Show();
      }
    }


    public void preencheCampos(string s1, string s2, string s3)
    {
      textCodigo.Text = s1;
      maskedCPFCli.Text = s2;
      textNomeCli.Text = s3;
      if (!textNomeCli.Text.Equals(""))
      {
        textFilmeCod.Focus();
      }
    }

    private void consultaFilme_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((Keys)e.KeyChar == Keys.Enter || (Keys)e.KeyChar == Keys.Tab)
        consultaFilme_Click(sender, e);
    }

    public void consultaFilme_Click(object sender, EventArgs e)
    {
      if (!textFilmeCod.Text.Equals(""))
      {
        codigoDigitado = int.Parse(textFilmeCod.Text.ToString());
        SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
        conexao.Open();

        selecionaCliente = new SqlCommand("SELECT Cod_Filme, Titu_Filme, ID_CL_FILME " +
                                                     "FROM FILMES "+
                                                     "WHERE Cod_Filme = @codigoDigitado", conexao);

        parametro = new SqlParameter("@codigoDigitado", codigoDigitado);
        selecionaCliente.Parameters.Add(parametro);

        leitor = selecionaCliente.ExecuteReader();
        if (leitor.HasRows)
        {
          while (leitor.Read())
          {
            objFilme.setCodigo(leitor["Cod_Filme"].ToString());
            objFilme.setTitulo(leitor["Titu_Filme"].ToString());
            objFilme.setClasseFilme(int.Parse(leitor["ID_CL_FILME"].ToString()));
          }
          objFilme.calculaLocacao();
          textFilmeTitulo.Text = objFilme.getTitulo();
          conexao.Close();
          botaoAdicionarFilme.Focus();
        }
        else
        {
          MessageBox.Show("Código inexistente","Erro");
        }
      }
    }

    private void botaoAdicionarFilme_Click(object sender, EventArgs e)
    {
      if (!textFilmeCod.Text.Equals("") && !textFilmeTitulo.Text.Equals(""))
      {
        ItemLocacao itemLocacao = new ItemLocacao(textCodigo.Text, textFilmeCod.Text, usuarioID, DateTime.Parse(dateLocacao.Text));
        listaLocacao.Push(itemLocacao);
        
        ListViewItem itemFilme = new ListViewItem(objFilme.getCodigo());
        ListViewItem.ListViewSubItem subItemFilme = new ListViewItem.ListViewSubItem(itemFilme, objFilme.getTitulo());
        itemFilme.SubItems.Add(subItemFilme);
        subItemFilme = new ListViewItem.ListViewSubItem(itemFilme, objFilme.getPrazo());
        itemFilme.SubItems.Add(subItemFilme);
        subItemFilme = new ListViewItem.ListViewSubItem(itemFilme, string.Format("{0:0.00}", objFilme.getValor()));
        itemFilme.SubItems.Add(subItemFilme);
        listViewFilmes.Items.Add(itemFilme);
        textFilmeCod.Clear();
        textFilmeTitulo.Clear();
        total = total + objFilme.getValor();
        textTotal.Text = string.Format("{0:0.00}", total);
        qtdeItens++;
        labelQTDEItens.Text = (qtdeItens).ToString();
        textFilmeCod.Focus();
      }
    }
    private void botaoRemoveFilme_Click(object sender, EventArgs e)
    {
      ListView.SelectedIndexCollection indices = listViewFilmes.SelectedIndices;

      while (indices.Count != 0)
      {
        total = total - float.Parse(listViewFilmes.Items[indices[0]].SubItems[3].Text);
        listViewFilmes.Items[indices[0]].Remove();
      }
      textCodigo.Focus();
      textTotal.Text = string.Format("{0:0.00}", total);
      qtdeItens--;
      labelQTDEItens.Text = (qtdeItens).ToString();
      textFilmeCod.Focus();
    }

    private void botaoLocar_Click(object sender, EventArgs e)
    {
      // GRAVA FILMES LOCADOS
      SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
      conexao.Open();
      SqlParameter paramentro;
      while (listaLocacao.Count != 0)
      {
        SqlCommand gravaLocacao = new SqlCommand("INSERT INTO LOCACAO VALUES(@CODCLI, @CODFIL, @CODUS, @DATALOC, 0, 1)", conexao);
        itemLocacao = listaLocacao.Pop();

        paramentro = new SqlParameter("@CODCLI", itemLocacao.getCodCliente());
        gravaLocacao.Parameters.Add(paramentro);
        paramentro = new SqlParameter("@CODFIL", itemLocacao.getCodFilme());
        gravaLocacao.Parameters.Add(paramentro);
        paramentro = new SqlParameter("@CODUS", itemLocacao.getCodUsuario());
        gravaLocacao.Parameters.Add(paramentro);
        paramentro = new SqlParameter("@DATALOC", itemLocacao.getDataLoc());
        gravaLocacao.Parameters.Add(paramentro);
        gravaLocacao.ExecuteNonQuery();
      }

      // ATUALIZA CREDITO DO CLIENTE
      float total = calculaTotal();
      SqlCommand atualizaCredito = new SqlCommand("UPDATE CRED_DEB SET VALOR = ( @VAL + VALOR ) WHERE Codigo_Cli = @CODCLI", conexao);

      paramentro = new SqlParameter("@CODCLI", textCodigo.Text);
      atualizaCredito.Parameters.Add(paramentro);
      paramentro = new SqlParameter("@VAL", total);
      atualizaCredito.Parameters.Add(paramentro);

      atualizaCredito.ExecuteNonQuery();
      conexao.Close();
      MessageBox.Show("Locação Efetuada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
      limparForm();
      textCodigo.Focus();
    }

    private float calculaTotal()
    {
      float valorTotal, v1, v2; // v1 valor dos filmes / v2 valor pago 
      if (textPago.Text != "")
      {
        v1 = float.Parse(textTotal.Text.ToString());
        v2 = float.Parse(textPago.Text.ToString());
        valorTotal = (v1 - v2)*-1;
      }
      else
      {
        v1 = float.Parse(textTotal.Text.ToString());
        valorTotal = v1 * -1;
      }
      
      return valorTotal;
    }

    private void limparForm()
    {
      foreach (Control ctrl in this.groupBoxFilmes.Controls)
      {
        if (ctrl is TextBox || ctrl is MaskedTextBox || ctrl is ComboBox)
        {
          ctrl.Text = "";
        }
      }
      foreach (Control ctrl in this.Controls)
      {
        if (ctrl is TextBox || ctrl is MaskedTextBox || ctrl is ComboBox)
        {
          ctrl.Text = "";
        }
      }
      textTotal.Text = string.Format("{0:0.00}",0);
      listViewFilmes.Items.Clear();
      labelQTDEItens.Text = "";
    }

    private void botaoAcessaCadastro_Click(object sender, EventArgs e)
    {
      int codigo;
      Alteracaocli alteracao = new Alteracaocli();
      if (textCodigo.Text == "")
        codigo = 0;
      else
        codigo = int.Parse(textCodigo.Text);

      alteracao.PegaCodigo(codigo);
      alteracao.Inserevalores();
      alteracao.ShowDialog();

    }

    private void textPago_Click(object sender, EventArgs e)
    {

      textPago.SelectionStart = textPago.Text.Length + 1;

    }

    public void cancelaLocacao_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
