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
    public partial class AlteraFilme : Form
    {
        int codigo, classe;
        public int codigofilme, errof1, errof2;


        public AlteraFilme()
        {
            InitializeComponent();
        }

        private void botaoAlterar_Click(object sender, EventArgs e)
        {
            Abrecampo();   
        }
        private void Travacampos()
        {
            foreach (Control ctrl in this.groupCaracteristicas.Controls)
            {
                if (ctrl is CheckBox)
                {
                    ctrl.Enabled = false;
                }
            }
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox || ctrl is MaskedTextBox || ctrl is ComboBox || ctrl is DateTimePicker || ctrl is NumericUpDown || ctrl is Label || ctrl is GroupBox)
                {
                    ctrl.Enabled = false; ;
                }
            }
            dateInclusao.Enabled = false;
            textCodigo.Enabled = false;
        }

        private void Abrecampo()
        {
            foreach (Control ctrl in this.groupCaracteristicas.Controls)
            {
                if (ctrl is CheckBox)
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
            dateInclusao.Enabled = false;
            botaoGravar.Enabled = true;
            textCodigo.Enabled = false;
        }

        public void Atribuicodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public void AtribuiCampos()
        {
            SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
            conexao.Open();
            string vQuery = "select Cod_Filme as cod,Titu_Filme as titu,Data_Inclu_Filme as datai,Pais_filme as pais,genero as gene," +
                            "Duracao_filme as dura,Ano_filme as ano,Produtora_filme as prod,ID_CL_FILME as class,Nume_Copia_filme as nume," +
                            "Midia_Filme as midia,Elenco_filme as elenco,Diretor_filme as diretor,Extras as extra,Sinopse_filme as sinopse from Filmes where Cod_Filme = " + codigo;

            SqlCommand pegacodigo = new SqlCommand(vQuery, conexao);

            SqlDataReader dr;

            dr = pegacodigo.ExecuteReader();

            if (dr.Read())
            {
                string caracteristicas = dr["extra"].ToString();
                int cont;
                string[] extras;

                extras = caracteristicas.Split(' ');
                cont = caracteristicas.Split(' ').Length;
                extras = new string[cont];

                textCodigo.Text = dr["cod"].ToString();
                textTitulo.Text = dr["titu"].ToString();
                dateInclusao.Text = dr["datai"].ToString();
                comboPais.Text = dr["pais"].ToString();
                comboGenero.Text = dr["gene"].ToString();
                textduracao.Text = dr["dura"].ToString();
                NUpDownAno.Text = dr["ano"].ToString();
                textProdutora.Text = dr["prod"].ToString();
                if (dr["class"].ToString() == "1")
                    comboClasseFilme.Text = "1 - SUPER LANÇAMENTO";
                else if (dr["class"].ToString() == "2")
                    comboClasseFilme.Text = "2 - LANÇAMENTO";
                else
                    comboClasseFilme.Text = "3 - ANTIGO";

                NUpDownNCopias.Text = dr["nume"].ToString();
                comboMidia.Text = dr["midia"].ToString();
                textDiretor.Text = dr["diretor"].ToString();
                textElenco.Text = dr["elenco"].ToString();
                for (int contador = 0; contador < extras.Length; contador++)
                {
                    if (extras[contador] == checkBoxDublado.Text)
                        checkBoxDublado.Checked = true;
                    if (extras[contador] == checkBoxLegendado.Text)
                        checkBoxLegendado.Checked = true;
                    if (extras[contador] == checkBoxWides.Text)
                        checkBoxWides.Checked = true;
                    if (extras[contador] == checkBoxBonus.Text)
                        checkBoxBonus.Checked = true;
                }
                textSinopse.Text = dr["sinopse"].ToString();


            }

            dr.Close();
            conexao.Close();
        }

        private void botaoGravar_Click(object sender, EventArgs e)
        {
        verificacampofilme();
        if (errof1 == 0 && errof2 == 0)
        {
            SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
            conexao.Open();


            string VQuery = "update Filmes set Titu_Filme = @titu,Data_Inclu_Filme = @datai,Pais_filme = @pais,genero = @gene," +
                            "Duracao_filme = @dura,Ano_filme = @ano,Produtora_filme = @prod,ID_CL_FILME = @class,Nume_Copia_filme = @nume," +
                            "Midia_Filme = @midia,Elenco_filme = @elenco,Diretor_filme = @diretor,Extras = @extra,Sinopse_filme = @sinopse where Cod_Filme = " + codigo;
            SqlCommand comandodeinsercao = new SqlCommand(VQuery,conexao);

           
            SqlParameter Titu_Filme = new SqlParameter("@titu", textTitulo.Text);
            comandodeinsercao.Parameters.Add(Titu_Filme);
            SqlParameter Data_Inclu_Filme = new SqlParameter("@datai", dateInclusao.Text);
            comandodeinsercao.Parameters.Add(Data_Inclu_Filme);
            SqlParameter Pais_filme = new SqlParameter("@pais", comboPais.Text);
            comandodeinsercao.Parameters.Add(Pais_filme);
            SqlParameter genero = new SqlParameter("@gene", comboGenero.Text);
            comandodeinsercao.Parameters.Add(genero);
            SqlParameter Duracao_filme = new SqlParameter("@dura", textduracao.Text);
            comandodeinsercao.Parameters.Add(Duracao_filme);
            SqlParameter Ano_filme = new SqlParameter("@ano", NUpDownAno.Text);
            comandodeinsercao.Parameters.Add(Ano_filme);
            SqlParameter Produtora_filme = new SqlParameter("@prod", textProdutora.Text);
            comandodeinsercao.Parameters.Add(Produtora_filme);
            if (comboClasseFilme.Text == "1 - SUPER LANÇAMENTO")
                classe = 1;
            else if (comboClasseFilme.Text == "2 - LANÇAMENTO")
                classe = 2;
            else
                classe = 3;

            SqlParameter Classe_filme = new SqlParameter("@class", classe);
            comandodeinsercao.Parameters.Add(Classe_filme);
            SqlParameter Nume_Copia_filme = new SqlParameter("@nume", int.Parse(NUpDownNCopias.Text));
            comandodeinsercao.Parameters.Add(Nume_Copia_filme);
            SqlParameter Midia_Filme = new SqlParameter("@midia", comboMidia.Text);
            comandodeinsercao.Parameters.Add(Midia_Filme);
            SqlParameter Elenco_filme = new SqlParameter("@elenco", textElenco.Text);
            comandodeinsercao.Parameters.Add(Elenco_filme);
            SqlParameter Diretor_filme = new SqlParameter("@diretor", textDiretor.Text);
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
            SqlParameter extras = new SqlParameter("@extra", caracteriticas);
            comandodeinsercao.Parameters.Add(extras);
            SqlParameter Sinopse_filme = new SqlParameter("@sinopse", textSinopse.Text);
            comandodeinsercao.Parameters.Add(Sinopse_filme);
             DialogResult resposta = MessageBox.Show("Tem certeza que deseja alterar os dados do Filme?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

             if (resposta.ToString() == "Yes")
             {
                 comandodeinsercao.ExecuteNonQuery();
                 MessageBox.Show("Filme Atualizado", "Filme Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             }
            conexao.Close();
            this.Close();
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
                errof1 = 1;
            }
            else
            {
                this.textTitulo.BackColor = Color.White;
                errof1 = 0;
            }

            if (comboGenero.Text == "")
            {
                this.comboGenero.BackColor = Color.PapayaWhip;
                errof2 = 1;
            }
            else
            {
                this.comboGenero.BackColor = Color.White;
                errof2 = 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir o filme", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resposta.ToString() == "Yes")
            {
                SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
                conexao.Open();
                string vQuery = "delete from Filmes where Cod_Filme=" + codigo;

                SqlCommand deletacodigo = new SqlCommand(vQuery, conexao);
                deletacodigo.ExecuteNonQuery();
                MessageBox.Show("Filme excluido com sucesso", "Aviso", MessageBoxButtons.OK ,MessageBoxIcon.Information);
                this.Close();
                conexao.Close();

            }
        }
    }
}
