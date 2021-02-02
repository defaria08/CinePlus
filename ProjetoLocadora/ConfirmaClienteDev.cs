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
  public partial class ConfirmaClienteDev : Form
  {
    Devolucao dev;
    string s1, s2, s3;
    string cod, cpf, nome, endereco;
    SqlConnection conexao;
    SqlCommand selecionaCliente;
    SqlParameter parametro;
    SqlDataReader leitor;

    public ConfirmaClienteDev(Devolucao d, string valor, int campo)
    {
      InitializeComponent();
      dev = d;
      switch (campo)
      {
        case 1: consultaCodigo(valor);
          break;
        case 2: consultaCPF(valor);
          break;
        case 3: consultaNome(valor);
          break;
      }
      label1.Text = valor + " - " + campo;
    }
    public void botaoConfirma_click(object sender, EventArgs e)
    {
      if (listViewConfirma.Items.Count != 0)
      {
        listViewConfirma.Select();
        s1 = listViewConfirma.FocusedItem.SubItems[0].Text;
        s2 = listViewConfirma.FocusedItem.SubItems[1].Text;
        s3 = listViewConfirma.FocusedItem.SubItems[2].Text;
      }
      else
      {
        s1 = "";
        s2 = "";
        s3 = "";
      }
      dev.preencheCampos(s1 ,s2 ,s3);
      dev.preencheListaFilmes();
      dev.Focus();
      this.Close();
    }

    public void selecionaItem_Click(object sender, EventArgs e)
    {
      listViewConfirma.FocusedItem.Selected = true;
    }

    public void consultaCodigo(string v1)
    {
      conexao = new SqlConnection("Data Source = (local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
      conexao.Open();

      selecionaCliente = new SqlCommand("SELECT Codigo_Cli, CPF_CLI, Nome_cli, Endereco_cli, End_num_CLi " +
                                                   "FROM CLIENTE "+
                                                   "WHERE Codigo_Cli = @codigodigitado", conexao);

      parametro = new SqlParameter("@codigoDigitado", v1);
      selecionaCliente.Parameters.Add(parametro);

      leitor = selecionaCliente.ExecuteReader();
      while (leitor.Read())
      {
        cod = leitor["Codigo_Cli"].ToString();
        cpf = leitor["CPF_CLI"].ToString();
        nome = leitor["Nome_cli"].ToString();
        endereco = leitor["Endereco_cli"].ToString();
        endereco = endereco +", "+leitor["End_num_CLi"].ToString();

        ListViewItem itemLista = new ListViewItem(cod);
        ListViewItem.ListViewSubItem subitemLista = new ListViewItem.ListViewSubItem(itemLista, cpf);
        itemLista.SubItems.Add(subitemLista);
        subitemLista = new ListViewItem.ListViewSubItem(itemLista, nome);
        itemLista.SubItems.Add(subitemLista);
        subitemLista = new ListViewItem.ListViewSubItem(itemLista, endereco);
        itemLista.SubItems.Add(subitemLista);

        listViewConfirma.Items.Add(itemLista);
        BotaoConfirma.Select();
      }
      conexao.Close();   
    }

    public void consultaCPF(string v2)
    {
      conexao = new SqlConnection("Data Source = (local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
      conexao.Open();

      selecionaCliente = new SqlCommand("SELECT Codigo_Cli, CPF_CLI, Nome_cli, Endereco_cli, End_num_CLi " +
                                                   "FROM CLIENTE " +
                                                   "WHERE CPF_CLI = @codigodigitado", conexao);

      parametro = new SqlParameter("@codigoDigitado", v2);
      selecionaCliente.Parameters.Add(parametro);

      leitor = selecionaCliente.ExecuteReader();
      while (leitor.Read())
      {
        cod = leitor["Codigo_Cli"].ToString();
        cpf = leitor["CPF_CLI"].ToString();
        nome = leitor["Nome_cli"].ToString();
        endereco = leitor["Endereco_cli"].ToString();
        endereco = endereco + ", " + leitor["End_num_CLi"].ToString();

        ListViewItem itemLista = new ListViewItem(cod);
        ListViewItem.ListViewSubItem subitemLista = new ListViewItem.ListViewSubItem(itemLista, cpf);
        itemLista.SubItems.Add(subitemLista);
        subitemLista = new ListViewItem.ListViewSubItem(itemLista, nome);
        itemLista.SubItems.Add(subitemLista);
        subitemLista = new ListViewItem.ListViewSubItem(itemLista, endereco);
        itemLista.SubItems.Add(subitemLista);

        listViewConfirma.Items.Add(itemLista);
        BotaoConfirma.Select();
      }
      conexao.Close();   
    }

    public void consultaNome(string v3)
    {
      conexao = new SqlConnection("Data Source = (local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
      conexao.Open();

      selecionaCliente = new SqlCommand("SELECT Codigo_Cli, CPF_CLI, Nome_cli, Endereco_cli, End_num_CLi " +
                                                   "FROM CLIENTE " +
                                                   "WHERE Nome_cli LIKE '%"+v3+"%'", conexao);

      parametro = new SqlParameter("@codigoDigitado", v3);
      selecionaCliente.Parameters.Add(parametro);

      leitor = selecionaCliente.ExecuteReader();
      while (leitor.Read())
      {
        cod = leitor["Codigo_Cli"].ToString();
        cpf = leitor["CPF_CLI"].ToString();
        nome = leitor["Nome_cli"].ToString();
        endereco = leitor["Endereco_cli"].ToString();
        endereco = endereco + ", " + leitor["End_num_CLi"].ToString();

        ListViewItem itemLista = new ListViewItem(cod);
        ListViewItem.ListViewSubItem subitemLista = new ListViewItem.ListViewSubItem(itemLista, cpf);
        itemLista.SubItems.Add(subitemLista);
        subitemLista = new ListViewItem.ListViewSubItem(itemLista, nome);
        itemLista.SubItems.Add(subitemLista);
        subitemLista = new ListViewItem.ListViewSubItem(itemLista, endereco);
        itemLista.SubItems.Add(subitemLista);

        listViewConfirma.Items.Add(itemLista);
        BotaoConfirma.Select();
      }
      conexao.Close();   
    }

    public void botaoCancela_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
