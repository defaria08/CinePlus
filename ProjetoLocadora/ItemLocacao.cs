using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoLocadora
{
  class ItemLocacao
  {
    private string codCliente;
    private string codFilme;
    private string codUsuario;
    private DateTime dataLoc;

    public ItemLocacao(string cc, string cf, string cu, DateTime dl)
    {
      codCliente = cc;
      codFilme = cf;
      codUsuario = cu;
      dataLoc = dl;
    }
    public ItemLocacao() { }

    public string getCodCliente() { return codCliente; }
    public string getCodFilme() { return codFilme; }
    public string getCodUsuario() { return codUsuario; }
    public DateTime getDataLoc() { return dataLoc; }
  }
}
/*
CREATE TABLE Locacao (
ID_Locacao INT PRIMARY KEY IDENTITY(1,1),
Codigo_Cli NVARCHAR(6) REFERENCES CLIENTE(Codigo_Cli),
Cod_Filme INT REFERENCES FILMES(Cod_Filme),
Cod_Us NVARCHAR(5) REFERENCES ACESSO_USUARIO(Cod_Us),
Data_locacao DATE,
PEND_PAGTO BIT NOT NULL DEFAULT 1,
PEND_DEVOLUCAO BIT NOT NULL DEFAULT 1
)
*/