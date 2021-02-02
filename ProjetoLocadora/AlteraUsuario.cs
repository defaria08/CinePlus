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
    public partial class AlteraUsuario : Form
    {
        int codigo, errou, erro, erro1, erro3, erro4, erro5, erro6, erro7, erro8, erro9, erro10, erro11, erro12, erro13, erro14, erro15, erro16, erro17;
        FormPrincipal acesso = new FormPrincipal();
        string nivel_acesso;
        public AlteraUsuario()
        {
            InitializeComponent();

        }
        private void abreacessonivel()
        {
            foreach (Control ctrl in this.groupBoxAcesso.Controls)
            {
                if (ctrl is RadioButton || ctrl is TextBox || ctrl is Label)
                {
                    ctrl.Enabled = true;
                }
            }
            foreach (Control ctrl in this.groupNivel.Controls)
            {
                if (ctrl is RadioButton)
                {
                    ctrl.Enabled = true;
                }
            }
        }
        private void Travacampos()
        {
            foreach (Control ctrl in this.groupBoxAcesso.Controls)
            {
                if (ctrl is RadioButton || ctrl is TextBox)
                {
                    ctrl.Enabled = false;
                }
            }
            foreach (Control ctrl in this.groupNivel.Controls)
            {
                if (ctrl is RadioButton)
                {
                    ctrl.Enabled = false;
                }
            }
            foreach (Control ctrl in this.groupBoxSexo.Controls)
            {
                if (ctrl is RadioButton)
                {
                    ctrl.Enabled = true;
                }
            }
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox || ctrl is MaskedTextBox || ctrl is ComboBox || ctrl is DateTimePicker || ctrl is NumericUpDown || ctrl is Label || ctrl is GroupBox)
                {
                    ctrl.Enabled = false; ;
                }
            }
            dateInclusaoUse.Enabled = false;
            textCodUse.Enabled = false;
        }

        private void Abrecampo()
        {

            foreach (Control ctrl in this.groupBoxSexo.Controls)
            {
                if (ctrl is RadioButton)
                {
                    ctrl.Enabled = true;
                }
            }
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox || ctrl is MaskedTextBox || ctrl is ComboBox || ctrl is DateTimePicker || ctrl is NumericUpDown || ctrl is Label || ctrl is GroupBox)
                {
                    ctrl.Enabled = true; ;
                }
            }
            dateInclusaoUse.Enabled = false;
            BotaoGravar.Enabled = true;
            textCodUse.Enabled = false;
        }

        public void Atribuicodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public void AtribuiCampos()
        {
            SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
            conexao.Open();
            string vQuery = "select Cod_Us as cod,Nome_Us as nome,Data_inclusao_us as datai,CPF_US as cpf,RG_Us as rg," +
                            "Estado_Civil_US as estadoc,Sexo_Us as sex,Data_Nasc_US as datan,End_US as ende,End_Num_Us as nume," +
                            "Comple_US as comple,Bairro_Us as bairro,Estado as estado,Cidade as cidade,CEP_Us as cep,Telefone1_Us as fone1," +
                            "Telefone2_Us as fone2,Email_Us as mail,Observacao_Us as obs,Login_Us as login," +
                            "nivel_acesso as nivel from Acesso_Usuario where Cod_Us = " + codigo;

            SqlCommand pegacodigo = new SqlCommand(vQuery, conexao);

            SqlDataReader dr;

            dr = pegacodigo.ExecuteReader();

            if (dr.Read())
            {
                int cont;

                textCodUse.Text = dr["cod"].ToString();
                textNomeUse.Text = dr["nome"].ToString();
                dateInclusaoUse.Text = dr["datai"].ToString();
                maskedCPFUse.Text = dr["cpf"].ToString();
                textRGUse.Text = dr["rg"].ToString();
                comboEstadoCivilUse.Text = dr["estadoc"].ToString();
                if (dr["sex"].ToString() == "F")
                    radioButtonF.Checked = true;
                else
                    radioButtonM.Checked = true;
                dateNascimentoUse.Text = dr["datan"].ToString();
                textEndUse.Text = dr["ende"].ToString();
                textEndNumUse.Text = dr["nume"].ToString();
                textComplementoUse.Text = dr["comple"].ToString();
                textBairroUse.Text = dr["bairro"].ToString();
                comboBoxUF.Text = dr["estado"].ToString();
                comboBoxCidade.Text = dr["cidade"].ToString();
                maskedTextCEP.Text = dr["cep"].ToString();
                maskedTextTel1.Text = dr["fone1"].ToString();
                maskedTextTel2.Text = dr["fone2"].ToString();
                textEmail.Text = dr["mail"].ToString();
                textObservacao.Text = dr["obs"].ToString();
                textLogin.Text = dr["login"].ToString();

                if (dr["nivel"].ToString() == "Nível Simples")
                    radioSimples.Checked = true;
                else if (dr["nivel"].ToString() == "Nível Gerencial")
                    radioGerencial.Checked = true;
                else
                    radioAdministrador.Checked = true;


            }

            dr.Close();
            conexao.Close();
        }
        private void BotaoGravar_Click(object sender, EventArgs e)
        {
            string senha = "", nivel_acesso = "", sex = "";

            if (textSenha.Text == textConfirma.Text)
                senha = textSenha.Text;


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


            if (senha != textConfirma.Text)
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
                    MessageBox.Show("Reveja Preenchemento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {

                    SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
                    conexao.Open();
                    string vQuery = "update Acesso_Usuario set Nome_Us = @nome,CPF_US = @cpf,RG_Us = @rg," +
                               "Estado_Civil_US = @estadoc,Sexo_Us = @sex,Data_Nasc_US = @datan,End_US = @ende,End_Num_Us = @nume," +
                               "Comple_US = @comple,Bairro_Us = @bairro,Estado = @estado,Cidade = @cidade,CEP_Us = @cep,Telefone1_Us = @fone1," +
                               "Telefone2_Us = @fone2,Email_Us = @mail,Observacao_Us = @obs,Login_Us = @login,Senha_Us = @senha," +
                               "nivel_acesso = @nivel  where Cod_Us = " + codigo;

                    SqlCommand comandodeinsercao = new SqlCommand(vQuery, conexao);


                    SqlParameter Nome_Us = new SqlParameter("@nome", textNomeUse.Text);
                    comandodeinsercao.Parameters.Add(Nome_Us);
                    SqlParameter CPF_US = new SqlParameter("@cpf", maskedCPFUse.Text);
                    comandodeinsercao.Parameters.Add(CPF_US);
                    SqlParameter RG_Us = new SqlParameter("@rg", textRGUse.Text);
                    comandodeinsercao.Parameters.Add(RG_Us);
                    SqlParameter Estado_Civil_US = new SqlParameter("@estadoc", comboEstadoCivilUse.Text);
                    comandodeinsercao.Parameters.Add(Estado_Civil_US);
                    SqlParameter Sexo_Us = new SqlParameter("@sex", sex);
                    comandodeinsercao.Parameters.Add(Sexo_Us);
                    SqlParameter Data_Nasc_US = new SqlParameter("@datan", dateNascimentoUse.Text);
                    comandodeinsercao.Parameters.Add(Data_Nasc_US);
                    SqlParameter End_US = new SqlParameter("@ende", textEndUse.Text);
                    comandodeinsercao.Parameters.Add(End_US);
                    SqlParameter End_Num_Us = new SqlParameter("@nume", int.Parse(textEndNumUse.Text));
                    comandodeinsercao.Parameters.Add(End_Num_Us);
                    SqlParameter Comple_US = new SqlParameter("@comple", textComplementoUse.Text);
                    comandodeinsercao.Parameters.Add(Comple_US);
                    SqlParameter Bairro_Us = new SqlParameter("@bairro", textBairroUse.Text);
                    comandodeinsercao.Parameters.Add(Bairro_Us);
                    SqlParameter Estado = new SqlParameter("@estado", comboBoxUF.Text);
                    comandodeinsercao.Parameters.Add(Estado);
                    SqlParameter Cidade = new SqlParameter("@cidade", comboBoxCidade.Text);
                    comandodeinsercao.Parameters.Add(Cidade);
                    SqlParameter CEP_Us = new SqlParameter("@cep", maskedTextCEP.Text);
                    comandodeinsercao.Parameters.Add(CEP_Us);
                    SqlParameter Telefone1_Us = new SqlParameter("@fone1", maskedTextTel1.Text);
                    comandodeinsercao.Parameters.Add(Telefone1_Us);
                    SqlParameter Telefone2_Us = new SqlParameter("@fone2", maskedTextTel2.Text);
                    comandodeinsercao.Parameters.Add(Telefone2_Us);
                    SqlParameter Email_Us = new SqlParameter("@mail", textEmail.Text);
                    comandodeinsercao.Parameters.Add(Email_Us);
                    SqlParameter Login_Us = new SqlParameter("@obs", textObservacao.Text);
                    comandodeinsercao.Parameters.Add(Login_Us);
                    SqlParameter Senha_Us = new SqlParameter("@login", textLogin.Text);
                    comandodeinsercao.Parameters.Add(Senha_Us);
                    SqlParameter groupNivel = new SqlParameter("@senha", senha);
                    comandodeinsercao.Parameters.Add(groupNivel);
                    SqlParameter Observacao_Us = new SqlParameter("@nivel", nivel_acesso);
                    comandodeinsercao.Parameters.Add(Observacao_Us);
                    DialogResult resposta = MessageBox.Show("Tem certeza que deseja alterar os dados do Usuário?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resposta.ToString() == "Yes")
                    {
                        comandodeinsercao.ExecuteNonQuery();
                        MessageBox.Show("Dados alterados com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Travacampos();

                    }
                    conexao.Close();


                }
            }
        }

        private void botaoAlterar_Click(object sender, EventArgs e)
        {
            Abrecampo();
            abreacessonivel();
            BotaoGravar.Enabled = true;
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

        private void BotaoExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir o usuário?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resposta.ToString() == "Yes")
            {
                SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
                conexao.Open();
                string vQuery = "delete from Acesso_usuario where Cod_Us =" + codigo;

                SqlCommand deletacodigo = new SqlCommand(vQuery, conexao);
                deletacodigo.ExecuteNonQuery();
                MessageBox.Show("Usuário excluido com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void Atribuiestado( object sender, EventArgs e)
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

        private void textEndNumUse_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
