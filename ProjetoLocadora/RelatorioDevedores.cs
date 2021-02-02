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
  public partial class RelatorioDevedores : Form
  {

    string cpf, nome, endereco, telefone;
    float valorDebito;
    SqlConnection conexao;
    SqlCommand selecionaCliente;
    SqlParameter parametro;
    SqlDataReader leitor;

    public RelatorioDevedores()
    {
      InitializeComponent();
      preencheLista();
    }

    public void preencheLista()
    {
      conexao = new SqlConnection("Data Source = (local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
      conexao.Open();

      selecionaCliente = new SqlCommand("SELECT CPF_CLI, " +
                                                "Nome_cli, "+
                                                "Endereco_cli, "+
                                                "End_num_CLi, " +
                                                "Telefone1_Cli, " +
                                                "VALOR "+
                                                "FROM CLIENTE " +
                                                "INNER JOIN CRED_DEB "+
                                                "ON CLIENTE.Codigo_Cli = CRED_DEB.Codigo_Cli", conexao);

      leitor = selecionaCliente.ExecuteReader();
      while (leitor.Read())
      {
        cpf = leitor["CPF_CLI"].ToString();
        nome = leitor["Nome_cli"].ToString();
        endereco = leitor["Endereco_cli"].ToString();
        endereco = endereco + ", " + leitor["End_num_CLi"].ToString();
        telefone = leitor["Telefone1_Cli"].ToString();
        valorDebito = float.Parse(leitor["VALOR"].ToString());
        valorDebito = valorDebito * -1;

        if (valorDebito > 0)
        {
          ListViewItem itemLista = new ListViewItem(cpf);
          ListViewItem.ListViewSubItem subitemLista = new ListViewItem.ListViewSubItem(itemLista, nome);
          itemLista.SubItems.Add(subitemLista);
          subitemLista = new ListViewItem.ListViewSubItem(itemLista, endereco);
          itemLista.SubItems.Add(subitemLista);
          subitemLista = new ListViewItem.ListViewSubItem(itemLista, telefone);
          itemLista.SubItems.Add(subitemLista);
          subitemLista = new ListViewItem.ListViewSubItem(itemLista, string.Format("{0:0.00}", valorDebito));
          itemLista.SubItems.Add(subitemLista);

          listViewConfirma.Items.Add(itemLista);
        }

        
      }
      conexao.Close();   
    }

    private void botaoCancela_Click(object sender, EventArgs e)
    {
        this.Close();
    }

  }
}
