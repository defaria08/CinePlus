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
  public partial class ConsultaDebito : Form
  {
    ConfirmaClienteDeb formConfirma;
    float credito;
    public ConsultaDebito()
    {
      InitializeComponent();
    }
    public void botaoPesqCod_Click(object sender, EventArgs e)
    {
      string valor = textCodigo.Text;
      int campo = 1;

      if (!textCodigo.Text.Equals(""))
      {
        formConfirma = new ConfirmaClienteDeb(this, valor, campo);
        formConfirma.Show();
      }
    }

    public void botaoPesqCpf_Click(object sender, EventArgs e)
    {
      string valor = maskedCPFCli.Text;
      int campo = 2;

      if (maskedCPFCli.Text.Length == 11)
      {
        formConfirma = new ConfirmaClienteDeb(this, valor, campo);
        formConfirma.Show();
      }
    }

    public void botaoPesqNome_Click(object sender, EventArgs e)
    {
      string valor = textNomeCli.Text;
      int campo = 3;

      if (!textNomeCli.Text.Equals(""))
      {
        formConfirma = new ConfirmaClienteDeb(this, valor, campo);
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
        textPago.Focus();
      }
      SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
      conexao.Open();
      SqlDataReader leitor;
      SqlCommand consultaCredito = new SqlCommand("SELECT DBO.SF_VALOR_CREC_DEB(@CLI) AS VAL;", conexao);
      SqlParameter paramentro = new SqlParameter("@CLI", textCodigo.Text);
      consultaCredito.Parameters.Add(paramentro);
      leitor = consultaCredito.ExecuteReader();


      while (leitor.Read())
      {
        credito = float.Parse(leitor["VAL"].ToString());
        credito = credito * -1;
      }
      textTotal.Text = string.Format("{0:0.00}", credito);
      conexao.Close();
      leitor.Close();
    }

    public void botaoRegistrar_Click(object sender, EventArgs e)
    {
      float pago = 0;

      if (textPago.Text.Equals(""))
        pago = 0;
      else
        pago = float.Parse(textPago.Text);

      SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
      conexao.Open();
      SqlCommand atualizaCredito = new SqlCommand("UPDATE CRED_DEB " +
                                      "SET VALOR = @PAGO + (SELECT DBO.SF_VALOR_CREC_DEB(@CODCLI1) AS VAL)" +
                                      " WHERE Codigo_Cli = @CODCLI1;", conexao);
      SqlParameter paramentro = new SqlParameter("@CODCLI1", textCodigo.Text);
      atualizaCredito.Parameters.Add(paramentro);
      paramentro = new SqlParameter("@PAGO",  pago);
      atualizaCredito.Parameters.Add(paramentro);

      atualizaCredito.ExecuteNonQuery();
      conexao.Close();
      MessageBox.Show("Pagamento Realizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
      textCodigo.Clear();
      maskedCPFCli.Clear();
      textNomeCli.Clear();
      textPago.Clear();
      textTotal.Text = "0,00";

    }

    private void buttonCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
  }
}
