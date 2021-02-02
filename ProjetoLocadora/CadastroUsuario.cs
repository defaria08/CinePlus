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
  public partial class CadastroUsuario : Form
  {
    public int vazio = 0;
    CPF verificador = new CPF();
    string erroCpf;

    int codigo_us, errou, erro, erro1, erro2, erro3, erro4, erro5, erro6, erro7, erro8, erro9, erro10, erro11, erro12, erro13, erro14, erro15, erro16, erro17;
    public string sex = "", nivel_acesso = "", senha, confirmasenha;

    public CadastroUsuario()
    {
      InitializeComponent();
      AtribuiCodUsua();
    }

    public void AtribuiCodUsua()
    {
      SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
      conexao.Open();
      string vQuery = "select MAX(Cod_Us) as valor from Acesso_Usuario";

      SqlCommand pegacodigo = new SqlCommand(vQuery, conexao);

      SqlDataReader dr;

      dr = pegacodigo.ExecuteReader();

      if (dr.Read() == false)
      {
        codigo_us = 1;
      }
      else
      {
        if (dr["valor"].ToString() == "")
          codigo_us = 1;
        else
          codigo_us = int.Parse(dr["valor"].ToString()) + 1;
      }

      dr.Close();



      conexao.Close();
      textCodUse.Text = codigo_us.ToString();
    }

    private void botaoLimpaForm(object sender, EventArgs e)
    {
      limparForm();
    }

    private void limparForm()
    {
      foreach (Control ctrl in this.groupBoxAcesso.Controls)
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
      radioAdministrador.Checked = false;
      radioGerencial.Checked = false;
      radioSimples.Checked = false;
      textNomeUse.Focus();
    }
  
    public void VerificaCampoUs()
    {
        if (textNomeUse.Text == "")
        {
            this.textNomeUse.BackColor = Color.PapayaWhip;
            erro1 = 1;
        }
        else
        {
            this.textNomeUse.BackColor = Color.White;
            erro1 = 0;
        }

        if (textEndUse.Text == "")
        {
            this.textEndUse.BackColor = Color.PapayaWhip;
            erro3 = 1;
        }
        else
        {
            this.textEndUse.BackColor = Color.White;
            erro3 = 0;

        }

        if (textEndNumUse.Text == "")
        {
            this.textEndNumUse.BackColor = Color.PapayaWhip;
            erro4 = 1;
        }
        else
        {
            this.textEndNumUse.BackColor = Color.White;
            erro4 = 0;
        }

        if (textBairroUse.Text == "")
        {
            this.textBairroUse.BackColor = Color.PapayaWhip;
            erro5 = 1;
        }
        else
        {
            this.textBairroUse.BackColor = Color.White;
            erro5 = 0;
        }

        if (comboBoxUF.Text == "")
        {
            this.comboBoxUF.BackColor = Color.PapayaWhip;
            erro6 = 1;
        }
        else
        {
            this.comboBoxUF.BackColor = Color.White;
            erro6 = 0;
        }

        if (comboBoxCidade.Text == "")
        {
            this.comboBoxCidade.BackColor = Color.PapayaWhip;
            erro7 = 1;
        }
        else
        {
            this.comboBoxCidade.BackColor = Color.WhiteSmoke;
            erro7 = 0;
        }

        if (comboBoxUF.Text == "")
        {
            this.comboBoxUF.BackColor = Color.PapayaWhip;
            erro8 = 1;
        }
        else
        {
            this.comboBoxUF.BackColor = Color.White;
            erro8 = 0;
        }
        if (maskedTextCEP.Text.Length == 0)
        {
            this.maskedTextCEP.BackColor = Color.PapayaWhip;
            erro9 = 1;
        }
        else
        {
            this.maskedTextCEP.BackColor = Color.White;
            erro9 = 0;
        }
        if (maskedTextCEP.Text.Length == 0)
        {
            this.maskedTextCEP.BackColor = Color.PapayaWhip;
            erro = 1;
        }
        else
        {
            this.maskedTextCEP.BackColor = Color.White;
            errou = 0;
        }

        if (maskedTextTel1.Text.Length == 0)
        {
            this.maskedTextTel1.BackColor = Color.PapayaWhip;
            erro10 = 1;
        }
        else
        {
            this.maskedTextTel1.BackColor = Color.White;
            erro10 = 0;
        }
        if (textLogin.Text.Length == 0)
        {
            this.textLogin.BackColor = Color.PapayaWhip;
            erro11 = 1;
        }
        else
        {
            this.textLogin.BackColor = Color.White;
            erro11 = 0;
        }
        if (textSenha.Text.Length == 0)
        {
            this.textSenha.BackColor = Color.PapayaWhip;
            erro12 = 1;
        }
        else
        {
            this.textSenha.BackColor = Color.White;
            erro12 = 0;
        }
        if (textConfirma.Text == "")
        {
            this.textConfirma.BackColor = Color.PapayaWhip;
            erro13 = 1;
        }
        else
        {
            this.textConfirma.BackColor = Color.White;
            erro13 = 0;
        }
        if (!(radioSimples.Checked ^ radioGerencial.Checked ^ radioAdministrador.Checked))
        {
            this.groupNivel.BackColor = Color.PapayaWhip;
            erro14 = 1;
        }
        else
        {
            this.groupNivel.BackColor = System.Drawing.SystemColors.Control;
            erro14 = 0;
        }


        if (maskedCPFUse.Text.Length != 11)
        {
            maskedCPFUse.BackColor = Color.PapayaWhip;
            erro15 = 1;
        }
        else
        {
            maskedCPFUse.BackColor = Color.White;
            erro15 = 0;
        }
        if (maskedCPFUse.Text.Length != 11)
        {
            maskedCPFUse.BackColor = Color.PapayaWhip;
            erro16 = 1;
        }
        else
        {
            maskedCPFUse.BackColor = Color.White;
            erro16 = 0;
        }
        if (!(radioButtonF.Checked ^ radioButtonM.Checked))
        {
            this.groupBoxSexo.BackColor = Color.PapayaWhip;
            erro17 = 1;
        }
        else
        {
            this.groupBoxSexo.BackColor = System.Drawing.SystemColors.Control;
            erro17 = 0;
        }
    }

    public void botaoGravar_click(object sender, EventArgs e)
    {
      {
        if (radioSimples.Checked == true)
          nivel_acesso = nivel_acesso.ToString() + radioSimples.Text;
        else if (radioGerencial.Checked == true)
          nivel_acesso = nivel_acesso.ToString() + radioGerencial.Text;
        else if (radioAdministrador.Checked == true)
          nivel_acesso = nivel_acesso.ToString() + radioAdministrador.Text;

        if (radioButtonF.Checked == true)
          sex = "F";
        if (radioButtonM.Checked == true)
          sex = "M";

        VerificaCampoUs();
        senha = textSenha.Text;
        confirmasenha = textConfirma.Text;

        if (senha != confirmasenha)
        {
          MessageBox.Show("Senhas não correspondem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
          textSenha.Clear();
          textConfirma.Clear();
          this.textConfirma.BackColor = Color.PapayaWhip;
          this.textSenha.BackColor = Color.PapayaWhip;
        }
        else
        {


            if (erro == 1 || erro1 == 1 || erro3 == 1 || erro4 == 1 || erro5 == 1 || erro6 == 1 || erro7 == 1 || erro8 == 1 || erro9 == 1 || erro10 == 1 || erro11 == 1 || erro12 == 1 || erro13 == 1 || erro14 == 1 || erro15 == 1 || erro16 == 1 || erro17 == 1)

                MessageBox.Show("Os campos destacados\n" +
                                "são de preenchimento\n" +
                                "obrigatório ou podem\n" +
                                "conter erros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          else
          {

            SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
            conexao.Open();

            SqlCommand comandodeinsercao = new SqlCommand("Insert into Acesso_Usuario (Cod_Us,Nome_Us,Data_inclusao_us," +
                                                                                      "CPF_US,RG_Us,Estado_Civil_US,Sexo_Us," +
                                                                                      "Data_Nasc_US,End_US,End_Num_Us,Comple_US," +
                                                                                      "Bairro_Us,Estado,Cidade,CEP_Us,Telefone1_Us," +
                                                                                      "Telefone2_Us,Email_Us,Observacao_Us,Login_Us," +
                                                                                      "Senha_Us,nivel_acesso)" +
                                                                                      "values" +
                                                                                      "(@Codigo,@Nome,@Datai,@Cpf,@Rg,@Estadoci,@Sexo," +
                                                                                      "@Datan,@End,@Nend,@Comple,@Bairro,@Estado,@Cidade," +
                                                                                      "@Cep,@Tel1,@Tel2,@Mail,@Obs,@Log,@Senha,@Nivel)", conexao);

            SqlParameter Cod_Us = new SqlParameter("@Codigo", codigo_us);
            comandodeinsercao.Parameters.Add(Cod_Us);
            SqlParameter Nome_Us = new SqlParameter("@Nome", textNomeUse.Text);
            comandodeinsercao.Parameters.Add(Nome_Us);
            SqlParameter Data_inclusao_us = new SqlParameter("@Datai", dateInclusaoUse.Text);
            comandodeinsercao.Parameters.Add(Data_inclusao_us);
            SqlParameter CPF_US = new SqlParameter("@Cpf", maskedCPFUse.Text);
            comandodeinsercao.Parameters.Add(CPF_US);
            SqlParameter RG_Us = new SqlParameter("@Rg", textRGUse.Text);
            comandodeinsercao.Parameters.Add(RG_Us);
            SqlParameter Estado_Civil_US = new SqlParameter("@Estadoci", comboEstadoCivilUse.Text);
            comandodeinsercao.Parameters.Add(Estado_Civil_US);
            SqlParameter Sexo_Us = new SqlParameter("@Sexo", sex);
            comandodeinsercao.Parameters.Add(Sexo_Us);
            SqlParameter Data_Nasc_US = new SqlParameter("@Datan", dateNascimentoUse.Text);
            comandodeinsercao.Parameters.Add(Data_Nasc_US);
            SqlParameter End_US = new SqlParameter("@End", textEndUse.Text);
            comandodeinsercao.Parameters.Add(End_US);
            SqlParameter End_Num_Us = new SqlParameter("@Nend", int.Parse(textEndNumUse.Text));
            comandodeinsercao.Parameters.Add(End_Num_Us);
            SqlParameter Comple_US = new SqlParameter("@Comple", textComplementoUse.Text);
            comandodeinsercao.Parameters.Add(Comple_US);
            SqlParameter Bairro_Us = new SqlParameter("@Bairro", textBairroUse.Text);
            comandodeinsercao.Parameters.Add(Bairro_Us);
            SqlParameter Estado = new SqlParameter("@Estado", comboBoxUF.Text);
            comandodeinsercao.Parameters.Add(Estado);
            SqlParameter Cidade = new SqlParameter("@Cidade", comboBoxCidade.Text);
            comandodeinsercao.Parameters.Add(Cidade);
            SqlParameter CEP_Us = new SqlParameter("@Cep", maskedTextCEP.Text);
            comandodeinsercao.Parameters.Add(CEP_Us);
            SqlParameter Telefone1_Us = new SqlParameter("@Tel1", maskedTextTel1.Text);
            comandodeinsercao.Parameters.Add(Telefone1_Us);
            SqlParameter Telefone2_Us = new SqlParameter("@Tel2", maskedTextTel2.Text);
            comandodeinsercao.Parameters.Add(Telefone2_Us);
            SqlParameter Email_Us = new SqlParameter("@Mail", textEmail.Text);
            comandodeinsercao.Parameters.Add(Email_Us);
            SqlParameter Login_Us = new SqlParameter("@Obs", textObservacao.Text);
            comandodeinsercao.Parameters.Add(Login_Us);
            SqlParameter Senha_Us = new SqlParameter("@Log", textLogin.Text);
            comandodeinsercao.Parameters.Add(Senha_Us);
            SqlParameter groupNivel = new SqlParameter("@Senha", senha);
            comandodeinsercao.Parameters.Add(groupNivel);
            SqlParameter Observacao_Us = new SqlParameter("@Nivel", nivel_acesso);
            comandodeinsercao.Parameters.Add(Observacao_Us);

            comandodeinsercao.ExecuteNonQuery();
            MessageBox.Show("Usuário Cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            textCodUse.Text = codigo_us.ToString();
            conexao.Close();

            limparForm();
            AtribuiCodUsua();
          }
        }
      }
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
  }
}
