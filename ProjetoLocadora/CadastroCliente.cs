using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows;

namespace ProjetoLocadora
{
  public partial class CadastroCliente : Form
  {
    public int codigo,  erro1, erro2, erro3, erro4, erro5, erro6, erro7, erro8, erro9,idestado;
    public string sex = "";
    public MaskedTextBox[] cpfs;
    string erroCpf;
    CPF verificador = new CPF();

    public CadastroCliente()
    {
      InitializeComponent();
      cpfs = new MaskedTextBox[4];
      cpfs[0] = maskedCPFCli;
      cpfs[1] = maskedTextCPFaut1;
      cpfs[2] = maskedTextCPFaut2;
      cpfs[3] = maskedTextCPFaut3;
      AtribuiCodigo();
      textCodCli.Text = codigo.ToString();
    }

    private void botaoLimpaForm(object sender, EventArgs e)
    {
      limparForm();
    }

    public void AtribuiCodigo()
    {
      SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
      conexao.Open();
      string vQuery = "select MAX(Codigo_Cli) as valor from Cliente";

      SqlCommand pegacodigo = new SqlCommand(vQuery, conexao);

      SqlDataReader dr;

      dr = pegacodigo.ExecuteReader();

      if (dr.Read() == false)
      {
        codigo = 1;
      }
      else
      {
        if (dr["valor"].ToString() == "")
          codigo = 1;
        else
          codigo = int.Parse(dr["valor"].ToString()) + 1;
      }

      dr.Close();

      textCodCli.Text = codigo.ToString();

      conexao.Close();
    }

    private void limparForm()
    {
      foreach (Control ctrl in this.groupBoxAutorizado.Controls)
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
      radioButtonF.Checked = false;
      radioButtonM.Checked = false;
      maskedTextCPFaut1.Enabled = false;
      maskedTextCPFaut2.Enabled = false;
      maskedTextCPFaut3.Enabled = false;
      reestabelecerCampo();
      AtribuiCodigo();
      textNomeCli.Focus();
    }
      
    // novo
    private void botaoGravar_click(object sender, EventArgs e)
    {
      if (radioButtonF.Checked == true)
        sex = "F";
      else
        sex = "M";
      verificaCampo();
      if (erro1 != 0 || erro2 != 0 || erro3 != 0 || erro4 != 0 || erro5 != 0 || erro6 != 0 || erro7 != 0 || erro8 != 0 || erro9 != 0)
        MessageBox.Show("Os campos destacados\n"+
                        "são de preenchimento\n"+
                        "obrigatório ou podem\n"+
                        "conter erros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      else
      {
        SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
        conexao.Open();

        SqlCommand comandodeinsercao = new SqlCommand("Insert into Cliente (Codigo_Cli,Nome_cli,Data_inclu,CPF_CLI," +
                                        "RG_Cli,Estado_Civil_cli,Sexo_CLi,Data_nasc_cli," +
                                        "Endereco_cli,End_num_CLi,Comple_cli,Bairro_cli," +
                                        "Estado,Cidade,CEP_Cli,Telefone1_Cli,Telefone2_cli," +
                                        "Email_cli,Observacao_Cli,Nome_autorizado1,CPF_autorizado1," +
                                        "data_nascimento_autorizado1,Nome_autorizado_2,CPF_Autorizado_2,Data_nascimento_Autorizado2,"+
                                        "Nome_Autorizado_3,CPF_Autorizado3,Data_Nascimento_Autorizado3)" +
                                        "values" +
                                        "(@Codigo,@Nome,@DataI,@CPF," +
                                        "@RG,@EstadoC,@Sexo,@DataN," +
                                        "@End,@NumE,@Comple,@Bairro," +
                                        "@Estado,@Cidade,@Cep,@Tel1," +
                                        "@Tel2,@Mail,@Obs,@Nome1," +
                                        "@Cpf1,@DataN1,@Nome2,@Cpf2," +
                                        "@DataN2,@Nome3,@Cpf3,@Data3)", conexao);

        SqlParameter codigo2 = new SqlParameter("@Codigo", codigo);
        comandodeinsercao.Parameters.Add(codigo2);
        SqlParameter nome = new SqlParameter("@Nome", textNomeCli.Text);
        comandodeinsercao.Parameters.Add(nome);
        SqlParameter datai = new SqlParameter("@DataI", dateInclusaoCli.Text);
        comandodeinsercao.Parameters.Add(datai);
        SqlParameter cpf = new SqlParameter("@CPF", maskedCPFCli.Text);
        comandodeinsercao.Parameters.Add(cpf);
        SqlParameter rg = new SqlParameter("@RG", textRGCli.Text);
        comandodeinsercao.Parameters.Add(rg);
        SqlParameter estadoc = new SqlParameter("@EstadoC", comboEstadoCivilCli.Text);
        comandodeinsercao.Parameters.Add(estadoc);
        SqlParameter sexo = new SqlParameter("@Sexo", sex);
        comandodeinsercao.Parameters.Add(sexo);
        SqlParameter Datan = new SqlParameter("@DataN", dateNascimentoCli.Text);
        comandodeinsercao.Parameters.Add(Datan);
        SqlParameter end = new SqlParameter("@End", textEndCli.Text);
        comandodeinsercao.Parameters.Add(end);
        SqlParameter nume = new SqlParameter("@NumE", int.Parse(textEndNumCli.Text));
        comandodeinsercao.Parameters.Add(nume);
        SqlParameter comple = new SqlParameter("@Comple", textComplementoCli.Text);
        comandodeinsercao.Parameters.Add(comple);
        SqlParameter bairro = new SqlParameter("@Bairro", textBairroCli.Text);
        comandodeinsercao.Parameters.Add(bairro);
        SqlParameter estado = new SqlParameter("@Estado", comboBoxUF.Text);
        comandodeinsercao.Parameters.Add(estado);
        SqlParameter cidade = new SqlParameter("@Cidade", comboBoxCidade.Text);
        comandodeinsercao.Parameters.Add(cidade);
        SqlParameter cep = new SqlParameter("@Cep", maskedTextCEP.Text);
        comandodeinsercao.Parameters.Add(cep);
        SqlParameter tel1 = new SqlParameter("@Tel1", maskedTextTel1.Text);
        comandodeinsercao.Parameters.Add(tel1);
        SqlParameter tel2 = new SqlParameter("@Tel2", maskedTextTel2.Text);
        comandodeinsercao.Parameters.Add(tel2);
        SqlParameter mail = new SqlParameter("@Mail", textEmail.Text);
        comandodeinsercao.Parameters.Add(mail);
        SqlParameter obs = new SqlParameter("@Obs", textBoxCli.Text);
        comandodeinsercao.Parameters.Add(obs);
        SqlParameter nome1 = new SqlParameter("@Nome1", textAutorizado1.Text);
        comandodeinsercao.Parameters.Add(nome1);
        SqlParameter cpf1 = new SqlParameter("@Cpf1", maskedTextCPFaut1.Text);
        comandodeinsercao.Parameters.Add(cpf1);
        SqlParameter datan1 = new SqlParameter("@DataN1", dateTimeNascAut1.Text);
        comandodeinsercao.Parameters.Add(datan1);
        SqlParameter nome2 = new SqlParameter("@Nome2", textAutorizado2.Text);
        comandodeinsercao.Parameters.Add(nome2);
        SqlParameter cpf2 = new SqlParameter("@Cpf2", maskedTextCPFaut2.Text);
        comandodeinsercao.Parameters.Add(cpf2);
        SqlParameter datan2 = new SqlParameter("@DataN2", dateTimeNascAut2.Text);
        comandodeinsercao.Parameters.Add(datan2);
        SqlParameter nome3 = new SqlParameter("@Nome3", textAutorizado3.Text);
        comandodeinsercao.Parameters.Add(nome3);
        SqlParameter cpf3 = new SqlParameter("@Cpf3", maskedTextCPFaut3.Text);
        comandodeinsercao.Parameters.Add(cpf3);
        SqlParameter datan3 = new SqlParameter("@Data3", dateTimeNascAut3.Text);
        comandodeinsercao.Parameters.Add(datan3);

        comandodeinsercao.ExecuteNonQuery();

        //INSERT NA TABELA DE CREDITO DO CLIENTE
        SqlCommand gravaCredDeb = new SqlCommand("INSERT INTO CRED_DEB (Codigo_Cli) VALUES(@CODCLI)", conexao);
        SqlParameter parametro = new SqlParameter("@CODCLI", codigo.ToString());
        gravaCredDeb.Parameters.Add(parametro);

        gravaCredDeb.ExecuteNonQuery();
        conexao.Close();

        textCodCli.Text = codigo.ToString();
        reestabelecerCampo();

        MessageBox.Show("Cliente Cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        conexao.Close();
        limparForm();
      }
    }

    public void reestabelecerCampo()
    {

      this.textNomeCli.BackColor = Color.White;
      this.maskedCPFCli.BackColor = Color.White;
      this.textRGCli.BackColor = Color.White;
      this.textBairroCli.BackColor = Color.White;
      this.maskedTextTel1.BackColor = Color.White;
      this.textEndCli.BackColor = Color.White;
      this.textEndNumCli.BackColor = Color.White;
      this.groupBoxSexo.BackColor = System.Drawing.SystemColors.Control;
      this.comboBoxCidade.BackColor = Color.White;
      this.comboBoxUF.BackColor = Color.White;
      this.maskedTextCEP.BackColor = Color.White;

    }
    public void verificaCampo()
    {
        if (textNomeCli.Text == "")
        {
            this.textNomeCli.BackColor = Color.PapayaWhip;
            erro1 = 1;
        }
        else
        {
            this.textNomeCli.BackColor = Color.White;
            erro1 = 0;
        }

        if (maskedCPFCli.Text.Length == 0)
        {
            this.maskedCPFCli.BackColor = Color.PapayaWhip;
            erro2 = 1;
        }
        else
        {
            this.maskedCPFCli.BackColor = Color.White;
            erro2 = 0;
        }

        if (textBairroCli.Text == "")
        {
            this.textBairroCli.BackColor = Color.PapayaWhip;
            erro4 = 1;
        }
        else
        {
            this.textBairroCli.BackColor = Color.White;
            erro4 = 0;
        }

        if (maskedTextTel1.Text.Length == 0)
        {
            this.maskedTextTel1.BackColor = Color.PapayaWhip;
            erro5 = 1;
        }
        else
        {
            this.maskedTextTel1.BackColor = Color.White;
            erro5 = 0;
        }

        if (textEndCli.Text == "")
        {
            this.textEndCli.BackColor = Color.PapayaWhip;
            erro6 = 1;
        }
        else
        {
            this.textEndCli.BackColor = Color.White;
            erro6 = 0;
        }

        if (textEndNumCli.Text == "")
        {
            this.textEndNumCli.BackColor = Color.PapayaWhip;
            erro7 = 1;
        }
        else
        {
            this.textEndNumCli.BackColor = Color.White;
            erro7 = 0;
        }

        if (sex == "")
        {
            this.groupBoxSexo.BackColor = Color.PapayaWhip;
            erro8 = 1;
        }
        else
        {
            this.groupBoxSexo.BackColor = Color.Transparent;
            erro8 = 0;
        }

        if (comboBoxUF.Text == "")
        {
            this.comboBoxUF.BackColor = Color.PapayaWhip;
            erro9 = 1;
        }
        else
        {
            this.comboBoxUF.BackColor = Color.White;
            erro9 = 0;
        }
        if (comboBoxCidade.Text == "")
        {
            this.comboBoxCidade.BackColor = Color.PapayaWhip;
            erro3 = 1;
        }
        else
        {
            this.comboBoxCidade.BackColor = Color.White;
            erro3 = 0;
        }
    }
    public void ativaCampoCpf(object sender, EventArgs e)
    {
      if (!textAutorizado1.Text.Equals(""))
      { maskedTextCPFaut1.Enabled = true; }
      if (!textAutorizado2.Text.Equals(""))
      { maskedTextCPFaut2.Enabled = true; }
      if (!textAutorizado3.Text.Equals(""))
      { maskedTextCPFaut3.Enabled = true; }
    }

    public void comboEstado_SIChanged(object sender, EventArgs e)
    {
      if (comboBoxUF.Text.Length == 2)
      {
        comboBoxCidade.Items.Clear();
        int codEstado = comboBoxUF.SelectedIndex + 1;
        SqlDataReader leitor;
        SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
        conexao.Open();
        SqlCommand consultaCidade = new SqlCommand("SELECT ID_Cidade, Nome_Cidade FROM CIDADE WHERE ID_Estado = @COD", conexao);

        SqlParameter paramentro = new SqlParameter("@COD", codEstado);
        consultaCidade.Parameters.Add(paramentro);

        leitor = consultaCidade.ExecuteReader();

        while (leitor.Read())
        {
          comboBoxCidade.Items.Add(leitor["Nome_Cidade"].ToString().ToUpper());
        }

        conexao.Close();
      }
    }

    private void comboBoxCidade_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
  }
}
