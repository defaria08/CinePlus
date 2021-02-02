using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoLocadora
{
  class DadosLocacao
  {
    private string codigoCliente; // LOCACAO - DEVOLUCAO
    private int codigoFilme; // LOCACAO
    private string codigoUsuario; // LOCACAO
    private string codigoLocacao; // DEVOLUCAO
    DateTime dataLocacao; // LOCACAO
    DateTime dataDevolucao; // DEVOLUCAO
    float valorLocacao; // LOCACAO
    float pagAntecipado; // LOCACAO
    float valorCredito; // DEVOLUCAO

    //Gets
    public void setCodigoCliente(string cc)
    { codigoCliente = cc; }
    public void setCodigoFilme(int cf)
    { codigoFilme = cf; }
    public void setCodigoUsuario(string cu)
    { codigoUsuario = cu; }
    public void setCodigoLocacao(string co)
    { codigoLocacao = co; }
    public void setDataLocacao(DateTime dl)
    { dataLocacao = dl; }
    public void setDataDevolucao(DateTime dd)
    { dataDevolucao = dd; }
    public void setValorLocacao(float v)
    { valorLocacao = v; }
    public void setPagamento(float pa)
    { pagAntecipado = pa; }
    public void setValorCredito(float vc)
    { valorCredito = vc; }

    //Sets
    public string getCodigoCliente()
    { return codigoCliente; }
    public int getCodigoFilme()
    { return codigoFilme; }
    public string getCodigoUsuario()
    { return codigoUsuario; }
    public string getCodigoLocacao()
    { return codigoLocacao; }
    public DateTime getDataLocacao()
    { return dataLocacao; }
    public DateTime getDataDevolucao()
    { return dataDevolucao; }
    public float getValorLocacao()
    { return valorLocacao; }
    public float getPagamento()
    { return pagAntecipado; }
    public float getValorCredito()
    { return valorCredito; }
  }
}
/*
 * LOCAÇÃO
CREATE TABLE Locacao (
ID_Locacao INT PRIMARY KEY IDENTITY(1,1),
Codigo_Cli NVARCHAR(6) REFERENCES CLIENTE(Codigo_Cli),
Cod_Filme INT REFERENCES FILMES(Cod_Filme),
Cod_Us NVARCHAR(5) REFERENCES ACESSO_USUARIO(Cod_Us),
Data_locacao DATE,
Valor_locacao MONEY,
Pag_antec_locacao MONEY
)
 * 
 * 
 * DEVOLUCAO
 * CREATE TABLE Devolucao (
ID_Locacao INT REFERENCES LOCACAO(ID_Locacao),
Cod_Us NVARCHAR(5) REFERENCES ACESSO_USUARIO(Cod_Us),
Data_devolução DATE,
Pagamento MONEY
)
GO

CREATE TABLE CRED_DEB
(
	Codigo_Cli NVARCHAR(6),
	VALOR MONEY NOT NULL DEFAULT 0.00,
	PEND_ATRASO BIT NOT NULL DEFAULT 0
);
*/