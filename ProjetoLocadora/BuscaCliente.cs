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
    public partial class BuscaCliente : Form
    {
        string nome, cod, nom, doc;
        int codigo;
        SqlDataReader leitor;
        public BuscaCliente()
        {
            InitializeComponent();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            ListViewBuscacliente.Items.Clear();
            textbuscaCliente.Clear();
        }

        private void botaoConsultausuario_Click(object sender, EventArgs e)
        {
            ListViewBuscacliente.Items.Clear();
            nome = textbuscaCliente.Text;
            SqlConnection conexao = new SqlConnection("Data Source = (Local); Initial Catalog = LOCADORA; Integrated Security=SSPI");
            conexao.Open();

            SqlCommand selecionafilme = new SqlCommand("select Codigo_Cli as codigo,Nome_cli as nome,CPF_CLI as doc from Cliente where Nome_cli like '%" + nome + "%'", conexao);

            leitor = selecionafilme.ExecuteReader();
            if (leitor.Read() == false)
            {
                MessageBox.Show("Cliente inexistente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbuscaCliente.Clear();
            }
            leitor.Close();
            leitor = selecionafilme.ExecuteReader();
                while (leitor.Read() == true)
                {
                    cod = leitor["codigo"].ToString();
                    nom = leitor["nome"].ToString();
                    doc = leitor["doc"].ToString();


                    ListViewItem itemLista = new ListViewItem(cod);
                    ListViewItem.ListViewSubItem subitemLista = new ListViewItem.ListViewSubItem(itemLista, nom);
                    itemLista.SubItems.Add(subitemLista);
                    subitemLista = new ListViewItem.ListViewSubItem(itemLista, doc);
                    itemLista.SubItems.Add(subitemLista);

                    ListViewBuscacliente.Items.Add(itemLista);

                    codigo = int.Parse(leitor["codigo"].ToString());
                    botaoSelecionarUsuario.Enabled = true;

                }

                        
                leitor.Close();
                conexao.Close();
            }
       

        private void botaoSelecionarUsuario_Click(object sender, EventArgs e)
        {
            textbuscaCliente.Text = "";
            ListViewBuscacliente.Items.Clear();
            Alteracaocli alteracao = new Alteracaocli();
            alteracao.PegaCodigo(codigo);
            alteracao.Inserevalores();
            alteracao.ShowDialog();
        }
    }
}
        
    

