using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ProjetoLocadora
{
  class Filme
  {
    private string codigo;
    private string titulo;
    private int classeFilme;
    private int dias;
    private float valor;
    DateTime prazo;

    public void setCodigo(string c)
    { codigo = c; }
    public void setTitulo(string t)
    { titulo = t; }
    public void setClasseFilme(int cf)
    { classeFilme = cf; }

    public string getCodigo()
    { return codigo; }
    public string getTitulo()
    { return titulo; }
    public int getClasseFilme()
    { return classeFilme; }
    public float getValor()
    { return valor; }
    public string getPrazo()
    { return prazo.ToShortDateString(); }

    public Filme(string cod, string tit, int cla)
    {
      codigo = cod;
      titulo = tit;
      classeFilme = cla;
    }

    public Filme()
    { }

    public void calculaLocacao()
    {
      consultaBanco();
      prazo = DateTime.Now.AddDays(dias);
    }

    private void consultaBanco()
    {
      SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
      conexao.Open();

      SqlCommand consultaClasseFilme = new SqlCommand( "SELECT VALOR_CL_FILME, DIAS_CL_FILME " +
                                                       "FROM CLASSEFILME " +
                                                       "WHERE ID_CL_FILME = @cod", conexao);

      SqlParameter parametro = new SqlParameter("@cod", classeFilme);
      consultaClasseFilme.Parameters.Add(parametro);

      SqlDataReader leitor = consultaClasseFilme.ExecuteReader();
      if (leitor.HasRows)
      {
        while (leitor.Read())
        {
          valor = float.Parse(leitor["VALOR_CL_FILME"].ToString());
          dias = int.Parse(leitor["DIAS_CL_FILME"].ToString());
        }
      }
    }
  }
}
