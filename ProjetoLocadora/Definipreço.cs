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
    public partial class Definipreço : Form
    {
        public Definipreço()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxva.Clear();
            textBoxvl.Clear();
            textBoxvsl.Clear();
        }

        private void botaodefinir_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
            conexao.Open();
            

            SqlCommand alteravalor = new SqlCommand("update CLASSEFILME set VALOR_CL_FILME = @valor where DE_CL_FILME = @classe", conexao);

            DialogResult resposta = MessageBox.Show("Deseja realmente alterar os valores?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta.ToString() == "Yes")
            {

                SqlParameter valores = new SqlParameter("@valor", float.Parse(textBoxvsl.Text));
                alteravalor.Parameters.Add(valores);
                SqlParameter classes = new SqlParameter("@classe", "SUPER LANÇAMENTO");
                alteravalor.Parameters.Add(classes);
                alteravalor.ExecuteNonQuery();

                alteravalor = new SqlCommand("update CLASSEFILME set VALOR_CL_FILME = @valor where DE_CL_FILME = @classe", conexao);

                valores = new SqlParameter("@valor", float.Parse(textBoxvl.Text));
                alteravalor.Parameters.Add(valores);
                classes = new SqlParameter("@classe", "LANÇAMENTO");
                alteravalor.Parameters.Add(classes);
                alteravalor.ExecuteNonQuery();

                alteravalor = new SqlCommand("update CLASSEFILME set VALOR_CL_FILME = @valor where DE_CL_FILME = @classe", conexao);

                valores = new SqlParameter("@valor", float.Parse(textBoxva.Text));
                alteravalor.Parameters.Add(valores);
                classes = new SqlParameter("@classe", "ANTIGO");
                alteravalor.Parameters.Add(classes);
                alteravalor.ExecuteNonQuery();

                MessageBox.Show("Valores alterados com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            conexao.Close();

        }
    }
}
