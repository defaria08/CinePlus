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
  public partial class Devolucao : Form
  {
    public int codigoDigitado;
    public string cpfcli;
    public string nomecli;
    public string usuarioID;
    ConfirmaClienteDev formConfirma;
    int qtdeItens = 0;
    int pendPgto;
    //DadosLocacao dev = new DadosLocacao();
    Stack<DadosLocacao> pilhaDevolucao = new Stack<DadosLocacao>();

    public Devolucao(string cu)
    {
      InitializeComponent();
      usuarioID = cu;
    }

    public void preencheCampos(string s1, string s2, string s3)
    {
      textCodigo.Text = s1;
      maskedCPFCli.Text = s2;
      textNomeCli.Text = s3;
    }

    public void botaoPesqCod_Click(object sender, EventArgs e)
    {
      string valor = textCodigo.Text;
      int campo = 1;

      if (!textCodigo.Text.Equals(""))
      {
        formConfirma = new ConfirmaClienteDev(this, valor, campo);
        formConfirma.Show();
      }
    }

    public void botaoPesqCpf_Click(object sender, EventArgs e)
    {
      string valor = maskedCPFCli.Text;
      int campo = 2;

      if (maskedCPFCli.Text.Length == 11)
      {
        formConfirma = new ConfirmaClienteDev(this, valor, campo);
        formConfirma.Show();
      }
    }

    public void botaoPesqNome_Click(object sender, EventArgs e)
    {
      string valor = textNomeCli.Text;
      int campo = 3;

      if (!textNomeCli.Text.Equals(""))
      {
        formConfirma = new ConfirmaClienteDev(this, valor, campo);
        formConfirma.Show();
      }
    }

    public void preencheListaFilmes()
    {
      // PREENCHE LISTVIEWFILMES COM AS LOCAÇOES PENDENTES
      string codigoFilme, tituloFilme;
      DateTime dataLocacao;
      DateTime dataDevolucao;
      int dias = 0;
      TimeSpan atraso; // O ATRASO SE TRANSFORMADO EM DIAS
      float credito = 0;
      float acrescimo = 0;
      float valor = 0;
      float total = 0;
      float acrescimoTotal = 0;

      SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
      SqlDataReader leitor;
      conexao.Open();
      SqlCommand consultaFilmes = new SqlCommand("SELECT LOCACAO.ID_Locacao, FILMES.Titu_Filme, " +
                                                  " LOCACAO.Data_locacao, CLASSEFILME.DIAS_CL_FILME, " +
                                                  "CLASSEFILME.VALOR_CL_FILME " +
                                                  "FROM FILMES " +
                                                  "INNER JOIN Locacao " +
                                                  "ON FILMES.Cod_Filme = LOCACAO.Cod_Filme " +
                                                  "INNER JOIN CLASSEFILME " +
                                                  "ON FILMES.ID_CL_FILME = CLASSEFILME.ID_CL_FILME " +
                                                  "WHERE Codigo_Cli = @CODCLI AND PEND_DEVOLUCAO = @PEND", conexao);

      SqlParameter paramentro = new SqlParameter("@CODCLI", textCodigo.Text);
      consultaFilmes.Parameters.Add(paramentro);
      paramentro = new SqlParameter("@PEND", 1);
      consultaFilmes.Parameters.Add(paramentro);
      leitor = consultaFilmes.ExecuteReader();

      while (leitor.Read())
      {
        codigoFilme = leitor["ID_Locacao"].ToString();
        tituloFilme = leitor["Titu_Filme"].ToString();
        dataLocacao = DateTime.Parse(leitor["Data_locacao"].ToString());
        dataDevolucao = (dataLocacao.Add(TimeSpan.Parse(leitor["DIAS_CL_FILME"].ToString())));
        valor = float.Parse(leitor["VALOR_CL_FILME"].ToString());
        //pendPgto = int.Parse(leitor["PEND_PAGTO"].ToString());

        if (dataDevolucao.CompareTo(DateTime.Now) < 0)
        {
          atraso = DateTime.Now.Subtract(dataLocacao);
          dias = int.Parse(atraso.Days.ToString());
          dias = dias - 1;
          acrescimo = valor * dias;
          acrescimoTotal = acrescimoTotal + acrescimo;
        }
        else
        {
          atraso = DateTime.Now.Subtract(DateTime.Now);
          dias = 0;
        }

        ListViewItem itemFilme = new ListViewItem(codigoFilme);
        ListViewItem.ListViewSubItem subItemFilme = new ListViewItem.ListViewSubItem(itemFilme, tituloFilme);
        itemFilme.SubItems.Add(subItemFilme);
        subItemFilme = new ListViewItem.ListViewSubItem(itemFilme, dataLocacao.ToShortDateString());
        itemFilme.SubItems.Add(subItemFilme);
        subItemFilme = new ListViewItem.ListViewSubItem(itemFilme, dias.ToString());
        itemFilme.SubItems.Add(subItemFilme);
        subItemFilme = new ListViewItem.ListViewSubItem(itemFilme, string.Format("{0:0.00}", valor));
        itemFilme.SubItems.Add(subItemFilme);
        listViewFilmes.Items.Add(itemFilme);
        qtdeItens++;
        labelQTDEItens.Text = (qtdeItens).ToString();
      }
      conexao.Close();
      leitor.Close();

      conexao.Open();
      SqlCommand consultaCredito = new SqlCommand("SELECT DBO.SF_VALOR_CREC_DEB(@CLI) AS VAL;", conexao);
      paramentro = new SqlParameter("@CLI", textCodigo.Text);
      consultaCredito.Parameters.Add(paramentro);
      leitor = consultaCredito.ExecuteReader();


      while (leitor.Read())
      {
        credito = float.Parse(leitor["VAL"].ToString());
      }

      total = (credito * -1) + acrescimoTotal;

      textAcrescimo.Text = string.Format("{0:0.00}", acrescimoTotal);
      textTotal.Text = string.Format("{0:0.00}", total);

      conexao.Close();
      leitor.Close();

      /*if (dias > 0)
      {
        conexao.Open();
        leitor.Close();
        SqlCommand atualizaCredito = new SqlCommand("UPDATE CRED_DEB " +
                                        "SET VALOR = @ACRESCIMO + (SELECT DBO.SF_VALOR_CREC_DEB(@CODCLI1) AS VAL)" +
                                        " WHERE Codigo_Cli = @CODCLI1;", conexao);
        paramentro = new SqlParameter("@CODCLI1", textCodigo.Text);
        atualizaCredito.Parameters.Add(paramentro);
        paramentro = new SqlParameter("@ACRESCIMO", acrescimoTotal * -1);
        atualizaCredito.Parameters.Add(paramentro);

        atualizaCredito.ExecuteNonQuery();
        conexao.Close();
        leitor.Close();
      }*/
    }

    private void selecionaFilmes_SIChange(object sender, EventArgs e)
    {
      buttonLocar.Enabled = true;
      int x = 0;
      // REESTABELECE A COR DO ITEM
      while (x < listViewFilmes.Items.Count)
      {
        listViewFilmes.Items[x].BackColor = System.Drawing.Color.Lavender;
        x++;
      }
      pilhaDevolucao.Clear();
      ListView.SelectedIndexCollection indices = listViewFilmes.SelectedIndices;

      int qtdeFinal = indices.Count;
      int i = 0;

      while (i < qtdeFinal)
      {
        // ENTIDADE LOCACAO
        listViewFilmes.Items[indices[i]].BackColor = System.Drawing.Color.LightGoldenrodYellow; // DESTACA O ITEM SELECIONADO

        DadosLocacao dev = new DadosLocacao();
        dev.setCodigoLocacao(listViewFilmes.Items[indices[i]].Text);
        dev.setCodigoUsuario(usuarioID);
        dev.setDataDevolucao(DateTime.Parse(dateDevolucao.Text));
        if (!textPago.Text.Equals(""))
          dev.setPagamento(float.Parse(textPago.Text));
        else
          dev.setPagamento(0.00f);

        // ENTIDADE CRED_DEB
        dev.setCodigoCliente(textCodigo.Text);
        if (!textPago.Text.Equals(""))
          dev.setValorCredito(float.Parse(textPago.Text));
        else
          dev.setValorCredito(0.00f);
        pilhaDevolucao.Push(dev);
        i++;
      }
    }

    public void botaoDevolver_Click(object sender, EventArgs e)
    {
      DadosLocacao itemDevolucao = new DadosLocacao();

      // GRAVA FILMES LOCADOS
      SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
      conexao.Open();
      SqlParameter paramentro;
      while (pilhaDevolucao.Count != 0)
      {


        // INSERT DA TABELA DEVOLUCAO
        SqlCommand gravaDevolucao = new SqlCommand("INSERT INTO DEVOLUCAO VALUES(@CODLOC, @CODUS, @DATADEV, @PAG)", conexao);
        itemDevolucao = pilhaDevolucao.Pop();

        paramentro = new SqlParameter("@CODLOC", itemDevolucao.getCodigoLocacao());
        gravaDevolucao.Parameters.Add(paramentro);
        paramentro = new SqlParameter("@CODUS", itemDevolucao.getCodigoUsuario());
        gravaDevolucao.Parameters.Add(paramentro);
        paramentro = new SqlParameter("@DATADEV", itemDevolucao.getDataDevolucao());
        gravaDevolucao.Parameters.Add(paramentro);
        paramentro = new SqlParameter("@PAG", itemDevolucao.getPagamento());
        gravaDevolucao.Parameters.Add(paramentro);

        gravaDevolucao.ExecuteNonQuery();

        //UPDATE DA TABELA LOCACAO
        //PEND_DEVOLUCAO = 0 INDICA QUE O FILME FOI DEVOLVIDO
        SqlCommand atualizaLocacao = new SqlCommand("UPDATE LOCACAO SET PEND_DEVOLUCAO = 0 " +
                                                    "WHERE ID_Locacao = @CODLOC1", conexao);

        paramentro = new SqlParameter("@CODLOC1", itemDevolucao.getCodigoLocacao());
        atualizaLocacao.Parameters.Add(paramentro);

        atualizaLocacao.ExecuteNonQuery();

        //UPDATE DA TABELA CRED_DEB
        if (textPago.Text.Equals(""))
        {
          itemDevolucao.setPagamento(0);
        }
        else
        {
          itemDevolucao.setPagamento(float.Parse(textPago.Text));
        }
      }
      SqlCommand atualizaCredito = new SqlCommand("UPDATE CRED_DEB " +
                                    "SET VALOR = (SELECT DBO.SF_VALOR_CREC_DEB(@CODCLI) AS VAL) + @VALOR2 " +
                                    "WHERE Codigo_Cli = @CODCLI", conexao);

      paramentro = new SqlParameter("@CODCLI", itemDevolucao.getCodigoCliente());
      atualizaCredito.Parameters.Add(paramentro);
      paramentro = new SqlParameter("@VALOR2", itemDevolucao.getPagamento());
      atualizaCredito.Parameters.Add(paramentro);

      atualizaCredito.ExecuteNonQuery();
      MessageBox.Show("Devolução Efetuada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
      conexao.Close();
      limparForm();
    }

    private void limparForm()
    {
      /*
       *       foreach (Control ctrl in this.Controls)
            {
              if (ctrl is TextBox || ctrl is MaskedTextBox || ctrl is ComboBox)
              {
                ctrl.Text = "";
              }
            }
            textTotal.Text = string.Format("{0:0.00}", 0);
            listViewFilmes.Items.Clear();
            textAcrescimo.Text = "0,00";
            labelQTDEItens.Text = "";
       * 
       */

      ListView.SelectedIndexCollection indices = listViewFilmes.SelectedIndices;

      while (indices.Count != 0)
      {
        listViewFilmes.Items[indices[0]].Remove();
      }

      SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
      SqlDataReader leitor;
      conexao.Open();
      SqlCommand consultaCredito = new SqlCommand("SELECT DBO.SF_VALOR_CREC_DEB(@CLI) AS VAL;", conexao);
      SqlParameter paramentro = new SqlParameter("@CLI", textCodigo.Text);
      consultaCredito.Parameters.Add(paramentro);
      leitor = consultaCredito.ExecuteReader();
      while (leitor.Read())
      {
        float credito = float.Parse(leitor["VAL"].ToString()) * -1;
        textTotal.Text = string.Format("{0:0.00}", credito);
      }
      textAcrescimo.Text = "0,00";
      textPago.Text = "";
    }

    public void cancelaDevolucao_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
