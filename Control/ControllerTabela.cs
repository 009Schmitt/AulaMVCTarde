using AULAMVC01Tarde.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULAMVC01Tarde.Control
{
    public static class ControllerTabela
    {
        public static bool AdicionaPessoa(string nome, string cpf, string rg)
        {
            if (!string.IsNullOrEmpty(nome) &&
               !string.IsNullOrEmpty(cpf) &&
               !string.IsNullOrEmpty(rg))
            {
                return TabelaModel.AdicionaPessoa(nome, cpf, rg);
            }
            else
            {
                return false;
            }
        }

        public static List<string[]> SelecionaPessoas()
        {
            return TabelaModel.SelecionaPessoas();
        }

        public static bool AdicionaFuncionario(string nome, string cpf, string rg,string salario)
        {
            if (!string.IsNullOrEmpty(nome) &&
               !string.IsNullOrEmpty(cpf) &&
               !string.IsNullOrEmpty(rg) &&
               !string.IsNullOrEmpty(salario))
            {
                return TabelaModel.AdicionaFuncionario(nome, cpf, rg, salario);
            }
            else
            {
                return false;
            }
        }

        public static List<string[]> SelecionaFucionarios()
        {
            return TabelaModel.SelecionaFucionarios();
        }

    }
}
