using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace ProjetoLocadora
{
  class CPF
  {
    private string numCpf;

    public bool checaCpfvalido(string strCpf, ref string mensagem)
    {
      int[] numCpf = new int[11];
      int[] parcialCpf = new int[11];
      int somatorio = 0;
      int resto = 0;
      
      for (int i = 0; i <= 8; i++)
      {
        numCpf[i] = int.Parse(strCpf[i].ToString());
      }
      int x, y;
      for (x = 0, y = 10; x <= 8; x++, y-- )
      {
        parcialCpf[x] = numCpf[x] * y;
      }
      for (int i = 0; i <= 8; i++)
      {
        somatorio = somatorio + parcialCpf[i];
      }
      resto = somatorio % 11;
      if (resto < 2)
        numCpf[9] = 0;
      else
        numCpf[9] = 11-resto;
      for (x = 0, y = 11; x <= 9; x++, y--)
      {
        parcialCpf[x] = numCpf[x] * y;
      }
      somatorio = 0;
      for (int i = 0; i <= 9; i++)
      {
        somatorio = somatorio + parcialCpf[i];
      }
      resto = 0;
      resto = somatorio % 11;
      if (resto < 2)
        numCpf[10] = 0;
      else
        numCpf[10] = 11 - resto;

      bool resposta = true;
      if (numCpf[9] != int.Parse(strCpf[9].ToString()) ^ numCpf[10] != int.Parse(strCpf[10].ToString()))
      {
        mensagem = "Digito do CPF não confere";
        resposta = false;
      }
      else if (numCpf[9] != int.Parse(strCpf[9].ToString()) && numCpf[10] != int.Parse(strCpf[10].ToString()))
      {
        mensagem = "CPF inválido";
        resposta = false;
      }

      return resposta;
    }
  }
}
