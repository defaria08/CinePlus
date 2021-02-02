using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLocadora
{
    public partial class Alteracaocli : Form
    {
        public int codigo,erro1, erro2, erro3, erro4, erro5, erro6, erro7, erro8, erro9;
        public string sex;



        public void PegaCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public Alteracaocli()
        {
            InitializeComponent();
                     
        }

       
        private void Travacampos()
        {
            foreach (Control ctrl in this.groupBoxAutorizado.Controls)
            {
                if (ctrl is TextBox || ctrl is MaskedTextBox || ctrl is ComboBox || ctrl is DateTimePicker)
                {
                    ctrl.Enabled = false;
                }
            }
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox || ctrl is MaskedTextBox || ctrl is ComboBox || ctrl is DateTimePicker || ctrl is ComboBox || ctrl is Label || ctrl is GroupBox)
                {
                    ctrl.Enabled = false; ;
                }
            }
            dateInclusaoCli.Enabled = false;
            radioButtonF.Enabled = false;
            radioButtonM.Enabled = false;
            botaoGravar.Enabled = false;
            textCodCli.Enabled = false;
        }
        
        private void Abrecampo()
        {
            foreach (Control ctrl in this.groupBoxAutorizado.Controls)
            {
                if (ctrl is TextBox || ctrl is MaskedTextBox || ctrl is ComboBox || ctrl is DateTimePicker)
                {
                    ctrl.Enabled = true;
                }
            }
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox || ctrl is MaskedTextBox || ctrl is ComboBox || ctrl is DateTimePicker || ctrl is ComboBox || ctrl is Label || ctrl is GroupBox)
                {
                    ctrl.Enabled = true; ;
                }
            }
            radioButtonF.Enabled = true;
            radioButtonM.Enabled = true;
            botaoGravar.Enabled = true;
            textCodCli.Enabled = false;
            dateInclusaoCli.Enabled = false;
        }


        private void botaoAlterar_Click(object sender, EventArgs e)
        {
            Abrecampo();
        }
        
        private void botaoGravar_Click_1(object sender, EventArgs e)
        {
             if(erro1 != 0 || erro2 != 0 || erro3 != 0 || erro4 != 0 || erro5 != 0 || erro6 != 0 || erro7 != 0 || erro8 != 0 || erro9 != 0)
        MessageBox.Show("Os campos destacados\n"+
                        "são de preenchimento\n"+
                        "obrigatório ou podem\n"+
                        "conter erros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      else
      {
          SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
            conexao.Open();
            string vQuery = "update Cliente set Nome_cli = @nome,Data_inclu = @datai,CPF_CLI = @cpf,RG_Cli = @rg," +
                            "Estado_Civil_cli = @estadoc,Sexo_CLi = @sexo,Data_nasc_cli = @datan,Endereco_cli = @ender," +
                            "End_num_CLi = @nume,Comple_cli = @comple,Bairro_cli = @bairro,Estado = @estado,Cidade = @cidade,CEP_Cli = @cep," +
                            "Telefone1_Cli = @fone1,Telefone2_cli = @fone2,Email_cli = @mail,Observacao_Cli = @obs," +
                            "Nome_autorizado1 = @nome1,CPF_autorizado1 = @cpf1,data_nascimento_autorizado1 = @datan1," +
                            "Nome_autorizado_2 = @nome2,CPF_Autorizado_2 = @cpf2,Data_nascimento_Autorizado2 = @datan2," +
                            "Nome_Autorizado_3 = @nome3,CPF_Autorizado3 = @cpf3,Data_Nascimento_Autorizado3 = @datan3 where Codigo_Cli =" + codigo;

            SqlCommand comandodeinsercao = new SqlCommand(vQuery, conexao);

            SqlParameter nome = new SqlParameter("@Nome", textNomeCli.Text);
            comandodeinsercao.Parameters.Add(nome);
            SqlParameter datai = new SqlParameter("@DataI", dateInclusaoCli.Text);
            comandodeinsercao.Parameters.Add(datai);
            SqlParameter cpf = new SqlParameter("@cpf", maskedCPFCli.Text);
            comandodeinsercao.Parameters.Add(cpf);
            SqlParameter rg = new SqlParameter("@rg", textRGCli.Text);
            comandodeinsercao.Parameters.Add(rg);
            SqlParameter estadoc = new SqlParameter("@estadoc", comboEstadoCivilCli.Text);
            comandodeinsercao.Parameters.Add(estadoc);
            if (radioButtonF.Checked = true)
                sex = "F";
            if (radioButtonM.Checked = true)
                sex = "M";
            SqlParameter sexo = new SqlParameter("@sexo", sex);
            comandodeinsercao.Parameters.Add(sexo);
            SqlParameter Datan = new SqlParameter("@datan", dateNascimentoCli.Text);
            comandodeinsercao.Parameters.Add(Datan);
            SqlParameter end = new SqlParameter("@ender", textEndCli.Text);
            comandodeinsercao.Parameters.Add(end);
            SqlParameter nume = new SqlParameter("@nume", int.Parse(textEndNumCli.Text));
            comandodeinsercao.Parameters.Add(nume);
            SqlParameter comple = new SqlParameter("@comple", textComplementoCli.Text);
            comandodeinsercao.Parameters.Add(comple);
            SqlParameter bairro = new SqlParameter("@bairro", textBairroCli.Text);
            comandodeinsercao.Parameters.Add(bairro);
            SqlParameter estado = new SqlParameter("@estado", comboBoxUF.Text);
            comandodeinsercao.Parameters.Add(estado);
            SqlParameter cidade = new SqlParameter("@cidade", comboBoxCidade.Text);
            comandodeinsercao.Parameters.Add(cidade);
            SqlParameter cep = new SqlParameter("@cep", maskedTextCEP.Text);
            comandodeinsercao.Parameters.Add(cep);
            SqlParameter tel1 = new SqlParameter("@fone1", maskedTextTel1.Text);
            comandodeinsercao.Parameters.Add(tel1);
            SqlParameter tel2 = new SqlParameter("@fone2", maskedTextTel2.Text);
            comandodeinsercao.Parameters.Add(tel2);
            SqlParameter mail = new SqlParameter("@mail", textEmail.Text);
            comandodeinsercao.Parameters.Add(mail);
            SqlParameter obs = new SqlParameter("@obs", textobs.Text);
            comandodeinsercao.Parameters.Add(obs);
            SqlParameter nome1 = new SqlParameter("@nome1", textAutorizado1.Text);
            comandodeinsercao.Parameters.Add(nome1);
            SqlParameter cpf1 = new SqlParameter("@cpf1", maskedTextCPFaut1.Text);
            comandodeinsercao.Parameters.Add(cpf1);
            SqlParameter datan1 = new SqlParameter("@dataN1", dateTimeNascAut1.Text);
            comandodeinsercao.Parameters.Add(datan1);
            SqlParameter nome2 = new SqlParameter("@nome2", textAutorizado2.Text);
            comandodeinsercao.Parameters.Add(nome2);
            SqlParameter cpf2 = new SqlParameter("@cpf2", maskedTextCPFaut2.Text);
            comandodeinsercao.Parameters.Add(cpf2);
            SqlParameter datan2 = new SqlParameter("@dataN2", dateTimeNascAut2.Text);
            comandodeinsercao.Parameters.Add(datan2);
            SqlParameter nome3 = new SqlParameter("@nome3", textAutorizado3.Text);
            comandodeinsercao.Parameters.Add(nome3);
            SqlParameter cpf3 = new SqlParameter("@cpf3", maskedTextCPFaut3.Text);
            comandodeinsercao.Parameters.Add(cpf3);
            SqlParameter datan3 = new SqlParameter("@datan3", dateTimeNascAut3.Text);
            comandodeinsercao.Parameters.Add(datan3);

                  DialogResult resposta = MessageBox.Show("Tem certeza que deseja alterar os dados do Cliente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                  if (resposta.ToString() == "Yes")
                  {
                      comandodeinsercao.ExecuteNonQuery();
                      MessageBox.Show("Cliente Atualizado", "Cliente Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  }
            conexao.Close();

            Travacampos();
            
      }

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
        public void Inserevalores()
        {
            SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
            conexao.Open();
            string vQuery = "select Codigo_Cli as codigo,Nome_cli as nome,Data_inclu as datai,CPF_CLI as cpf,RG_Cli as rg," +
                            "Estado_Civil_cli as estadoc,Sexo_CLi as sexo,Data_nasc_cli as datan,Endereco_cli as ender," +
                            "End_num_CLi as nume,Comple_cli as comple,Bairro_cli as bairro,Estado as estado,Cidade as cidade,CEP_Cli as cep," +
                            "Telefone1_Cli as fone1,Telefone2_cli as fone2,Email_cli as mail,Observacao_Cli as obs," +
                            "Nome_autorizado1 as nome1,CPF_autorizado1 as cpf1,data_nascimento_autorizado1 as datan1," +
                            "Nome_autorizado_2 as nome2,CPF_Autorizado_2 as cpf2,Data_nascimento_Autorizado2 as datan2," +
                            "Nome_Autorizado_3 as nome3,CPF_Autorizado3 as cpf3,Data_Nascimento_Autorizado3 as datan3 from Cliente where Codigo_Cli =" + codigo;

            SqlCommand pegacodigo = new SqlCommand(vQuery, conexao);

            SqlDataReader dr;

            dr = pegacodigo.ExecuteReader();

            if (dr.Read() == false)
            {
                codigo = 1;
            }
            else
            {
                textCodCli.Text = dr["codigo"].ToString();
                textNomeCli.Text = dr["nome"].ToString();
                dateInclusaoCli.Text = dr["datai"].ToString();
                maskedCPFCli.Text = dr["cpf"].ToString();
                textRGCli.Text = dr["rg"].ToString();
                comboEstadoCivilCli.Text = dr["estadoc"].ToString();
                if (dr["sexo"] == "F")
                    radioButtonF.Checked = true;
                else
                    radioButtonM.Checked = true;
                dateNascimentoCli.Text = dr["datan"].ToString();
                textEndCli.Text = dr["ender"].ToString();
                textEndNumCli.Text = dr["nume"].ToString();
                textComplementoCli.Text = dr["comple"].ToString();
                textBairroCli.Text = dr["bairro"].ToString();
                comboBoxUF.Text = dr["estado"].ToString();
                comboBoxCidade.Text = dr["cidade"].ToString();
                maskedTextCEP.Text = dr["cep"].ToString();
                maskedTextTel1.Text = dr["fone1"].ToString();
                maskedTextTel2.Text = dr["fone2"].ToString();
                textEmail.Text = dr["mail"].ToString();
                textAutorizado1.Text = dr["nome1"].ToString();
                maskedTextCPFaut1.Text = dr["cpf1"].ToString();
                dateTimeNascAut1.Text = dr["datan1"].ToString();
                textAutorizado2.Text = dr["nome2"].ToString();
                maskedTextCPFaut2.Text = dr["cpf2"].ToString();
                dateTimeNascAut2.Text = dr["datan2"].ToString();
                textAutorizado3.Text = dr["nome3"].ToString();
                maskedTextCPFaut3.Text = dr["cpf3"].ToString();
                dateTimeNascAut3.Text = dr["datan3"].ToString();
                textobs.Text = dr["obs"].ToString();

            }

            dr.Close();
            conexao.Close();
        }

        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir o cliente", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resposta.ToString() == "Yes")
            {
                SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
            conexao.Open();
            string vQuery = "delete from Cliente where Codigo_cli=" + codigo;

            SqlCommand deletacodigo = new SqlCommand(vQuery, conexao);
            deletacodigo.ExecuteNonQuery();
            MessageBox.Show("Cliente excluido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            conexao.Close();
          
            }
        }

        private void comboBoxUF_SelectedIndexChanged(object sender, EventArgs e)
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
        public void Atribuiestado(object sender, EventArgs e)
        {
            string sigla;
            SqlDataReader leitor;
            SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
            conexao.Open();

            SqlCommand selecionaestado = new SqlCommand("select Sigla_Estado from Estado", conexao);

            leitor = selecionaestado.ExecuteReader();


            while (leitor.Read() == true)
            {
                sigla = leitor["Sigla_Estado"].ToString();


                comboBoxUF.Items.Add(sigla);

            }
            leitor.Close();


            conexao.Close();
        }

        private void textComplementoCli_TextChanged(object sender, EventArgs e)
        {

        }

        }

    }

    

