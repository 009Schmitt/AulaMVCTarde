using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULAMVC01Tarde.Model
{
    public static class TabelaModel
    {
        private static SqlConnection Connection { get; set; } = new SqlConnection("Data Source=BUE205D39;Initial Catalog=BDTurmaTarde;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
        private static SqlCommand Cmd { get; set; } = new SqlCommand("",Connection);

        public static bool AdicionaPessoa(string nome, string cpf, string rg)
        {
            // 1° Passo / inserir na tabela primaria os valores referentes 
            string insert = $"INSERT into dbo.Dados(Nome,Cpf,Rg) values ('{nome}','{cpf}','{rg}')";
            Cmd.CommandText = insert;
            Connection.Open();
            Cmd.ExecuteNonQuery();
            Connection.Close();

            // 2° Passo / Selecionar o Id do elemento recem inserido
            int idDados = 0;
            string select = "SELECT Top 1 idDados from dbo.Dados Order by idDados desc";
            Cmd.CommandText = select;
            Connection.Open();
            SqlDataReader dr = Cmd.ExecuteReader();
            if(dr.Read())
            {
                idDados = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            Connection.Close();

            // 3° Passo / Inserir o id selecionado mais o restande dos dados

            insert = $"INSERT into dbo.Pessoa (idDados) values ({idDados})";
            Cmd.CommandText = insert;
            Connection.Open();
            Cmd.ExecuteNonQuery();
            Connection.Close();
            return true;
        }

        public static List<string[]> SelecionaPessoas()
        {
            List<string[]> lista = new List<string[]>();
            List<int> ids = new List<int>();

            // 1° Passo / Selecionar os Ids necessários para o Select da tabela primária
            string select = "SELECT idDados from dbo.Pessoa";
            Cmd.CommandText = select;
            Connection.Open();
            SqlDataReader dr = Cmd.ExecuteReader();
            while (dr.Read())
            {
                ids.Add(Convert.ToInt32(dr[0]));
            }
            dr.Close();
            Connection.Close();

            // 2° Passo / Selecionar os dados usando os Ids como referencia
            foreach (var item in ids)
            {
                select = $"SELECT * from dbo.Dados WHERE idDados = {item}";
                Cmd.CommandText = select;
                Connection.Open();
                dr = Cmd.ExecuteReader();
                if(dr.Read())
                {
                    string[] vetor = new string[dr.FieldCount];
                    for (int i = 0; i < vetor.Length; i++)
                    {
                        vetor[i] = dr[i].ToString();
                    }
                    lista.Add(vetor);
                }
                dr.Close();
                Connection.Close();
            }
            return lista;
        }
    }
}
