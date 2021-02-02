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
  public partial class CadastroFilmes : Form
  {
    public int codigofilme, erro, erro1, erro2;
    public CadastroFilmes()
    {
      InitializeComponent();
      NUpDownAno.Value = DateTime.Now.Year;
      AtribuiCodigoFilme();
    }

    private void botaoLimpaForm(object sender, EventArgs e)
    {
      limparForm();
    }

    public void AtribuiCodigoFilme()
    {
      SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
      conexao.Open();
      string vQuery = "select MAX(Cod_Filme) as valor from Filmes";

      SqlCommand pegacodigo = new SqlCommand(vQuery, conexao);

      SqlDataReader dr;

      dr = pegacodigo.ExecuteReader();

      if (dr.Read() == false)
      {
        codigofilme = 1;
      }
      else
      {
        if (dr["valor"].ToString() == "")
          codigofilme = 1;
        else
          codigofilme = int.Parse(dr["valor"].ToString()) + 1;
      }

      dr.Close();



      conexao.Close();
      textCodigo.Text = codigofilme.ToString();
    }

    private void limparForm()
    {
      foreach (Control ctrl in this.Controls)
      {
        if (ctrl is TextBox || ctrl is MaskedTextBox || ctrl is ComboBox)
        {
          ctrl.Text = "";
        }
      }
      checkBoxDublado.Checked = false;
      checkBoxLegendado.Checked = false;
      checkBoxWides.Checked = false;
      checkBoxBonus.Checked = false;
      NUpDownAno.Value = DateTime.Now.Year;
    }

    private void botaoGravar_Click(object sender, EventArgs e)
    {
      verificacampofilme();
      if (erro == 0 || erro1 == 0|| erro2 == 0)
      {
        SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
        conexao.Open();

        SqlCommand comandodeinsercao = new SqlCommand("Insert into Filmes (Cod_Filme,Titu_Filme,Data_Inclu_Filme," +
                                                      "Pais_filme,genero,Duracao_filme,Ano_filme," +
                                                      "Produtora_filme,ID_CL_FILME,Nume_Copia_filme,Midia_Filme," +
                                                      "Elenco_filme,Diretor_filme,Extras,Sinopse_filme) " +
                                                      "values" +
                                                      "(@Cod_Filme,@Titu_Filme,@Data_Inclu_Filme,@Pais_filme," +
                                                      "@genero,@Duracao_filme,@Ano_filme," +
                                                      "@Produtora_filme,@CL_FILME,@Nume_Copia_filme,@Midia_Filme," +
                                                      "@Elenco_filme,@Diretor_filme,@Extras,@Sinopse_filme)", conexao);

        SqlParameter Cod_Filme = new SqlParameter("@Cod_Filme", codigofilme);
        comandodeinsercao.Parameters.Add(Cod_Filme);
        SqlParameter Titu_Filme = new SqlParameter("@Titu_Filme", textTitulo.Text);
        comandodeinsercao.Parameters.Add(Titu_Filme);
        SqlParameter Data_Inclu_Filme = new SqlParameter("@Data_Inclu_Filme", dateInclusao.Text);
        comandodeinsercao.Parameters.Add(Data_Inclu_Filme);
        SqlParameter Pais_filme = new SqlParameter("@Pais_filme", comboPais.Text);
        comandodeinsercao.Parameters.Add(Pais_filme);
        SqlParameter genero = new SqlParameter("@genero", comboGenero.Text);
        comandodeinsercao.Parameters.Add(genero);
        SqlParameter Duracao_filme = new SqlParameter("@Duracao_filme", textduracao.Text);
        comandodeinsercao.Parameters.Add(Duracao_filme);
        SqlParameter Ano_filme = new SqlParameter("@Ano_filme", NUpDownAno.Text);
        comandodeinsercao.Parameters.Add(Ano_filme);
        SqlParameter Produtora_filme = new SqlParameter("@Produtora_filme", textProdutora.Text);
        comandodeinsercao.Parameters.Add(Produtora_filme);

        int classe_filme = 0;
        if (comboClasseFilme.SelectedIndex == 0)
          classe_filme = 1;
        if (comboClasseFilme.SelectedIndex == 1)
          classe_filme = 2;
        if (comboClasseFilme.SelectedIndex == 2)
          classe_filme = 3;

        SqlParameter CL_FILME = new SqlParameter("@CL_FILME", classe_filme.ToString());
        comandodeinsercao.Parameters.Add(CL_FILME);
        SqlParameter Nume_Copia_filme = new SqlParameter("@Nume_Copia_filme", int.Parse(NUpDownNCopias.Text));
        comandodeinsercao.Parameters.Add(Nume_Copia_filme);
        SqlParameter Midia_Filme = new SqlParameter("@Midia_Filme", comboMidia.Text);
        comandodeinsercao.Parameters.Add(Midia_Filme);
        SqlParameter Elenco_filme = new SqlParameter("@Elenco_filme", textElenco.Text);
        comandodeinsercao.Parameters.Add(Elenco_filme);
        SqlParameter Diretor_filme = new SqlParameter("@Diretor_filme", textDiretor.Text);
        comandodeinsercao.Parameters.Add(Diretor_filme);
        string caracteriticas = "";
        if (checkBoxDublado.Checked == true)
          caracteriticas = caracteriticas.ToString() + checkBoxDublado.Text + " ";
        if (checkBoxLegendado.Checked == true)
          caracteriticas = caracteriticas.ToString() + checkBoxLegendado.Text + " ";
        if (checkBoxWides.Checked == true)
          caracteriticas = caracteriticas.ToString() + checkBoxWides.Text + " ";
        if (checkBoxBonus.Checked == true)
          caracteriticas = caracteriticas.ToString() + checkBoxBonus.Text + " ";
        SqlParameter extras = new SqlParameter("@Extras", caracteriticas);
        comandodeinsercao.Parameters.Add(extras);
        SqlParameter Sinopse_filme = new SqlParameter("@Sinopse_filme", textSinopse.Text);
        comandodeinsercao.Parameters.Add(Sinopse_filme);

        comandodeinsercao.ExecuteNonQuery();
        MessageBox.Show("Filme Cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        conexao.Close();
        limparForm();
        AtribuiCodigoFilme();
        textTitulo.Focus();
      }
      else
      {
          MessageBox.Show("Os campos destacados\n" +
                          "são de preenchimento\n" +
                          "obrigatório ou podem\n" +
                          "conter erros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    private void verificacampofilme()
    {

      
      if (textTitulo.Text.Length == 0)
      {
        this.textTitulo.BackColor = Color.PapayaWhip;
        erro = 1;
      }
      else
      {
        this.textTitulo.BackColor = Color.White;
        erro = 0;
      }

      if (comboGenero.Text == "")
      {
        this.comboGenero.BackColor = Color.PapayaWhip;
        erro1 = 1;
      }
      else
      {
        this.comboGenero.BackColor = Color.White;
        erro1 = 0; ;
      }
      if (comboClasseFilme.Text == "")
      {
          this.comboClasseFilme.BackColor = Color.PapayaWhip;
          erro2 = 1;
      }
      else
      {
          this.comboClasseFilme.BackColor = Color.White;
          erro2 = 0; ;
      }
    }
  }
}
