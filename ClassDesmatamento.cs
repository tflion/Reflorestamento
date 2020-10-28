using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SAReflorestamento
{
    class ClassDesmatamento
    {
        public int Ano { get; set; }
        public string Estado { get; set; }
        public int NumArv { get; set; }
        public int VolumeArv { get; set; }
        public int ValorAPagar { get; set; }
        public double QuantidadeRepor { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();

        public bool Inserir()
        {
            try
            {
                // Conecta no banco
                bd.Conectar();

                // Executa o insert
                bd.ExecutarComandosSql(string.Format("INSERT INTO Reflorestamento (ano, estado, numArvoresCortadas, volumeM3) " +
                    " VALUES ({0}, '{1}', {2}, {3})", Ano, Estado, NumArv, VolumeArv));


                // Desconecta no banco

                bd.Desconectar();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " Erro ao registrar desmatamento! ");

            }
        }
        public DataTable RetTodosDesmatamentos()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(string.Format("SELECT * FROM Reflorestamento"));

            bd.Desconectar();

            return dt;
        }

        public bool Editar(int codDesmatamentoClicado)
        {

            bd.Conectar();

            bd.ExecutarComandosSql(String.Format("UPDATE Reflorestamento SET ano = {0} , estado = '{1}', numArvoresCortadas = '{2}'"
                + ", volumeM3 = {3} WHERE codCalculo LIKE {4}", Ano // arg 0
                , Estado // arg 1
                , NumArv // arg 2
                , VolumeArv // arg 3
                , codDesmatamentoClicado)); // arg 4

            bd.Desconectar();

            return true;
        }

        public bool Excluir(int codDesmatamentoClicado)
        {
            try
            {
                bd.Conectar();

                bd.ExecutarComandosSql(String.Format("DELETE FROM Reflorestamento WHERE codCalculo = {0}",
                   codDesmatamentoClicado));

                bd.Desconectar();

                return true;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao excluir desmatamento! ");
            }
        }
       public bool InserirValor(int codDesmatamentoClicado)
        {
            bd.Conectar();

            bd.ExecutarComandosSql(String.Format("UPDATE Reflorestamento SET valorAPagar = {0} WHERE codCalculo LIKE {1}",ValorAPagar //arg 0
                , codDesmatamentoClicado));// arg 1

            bd.Desconectar();

            return true;
        }

        public bool ReporArvores(int codDesmatamentoClicado)
        {
            bd.Conectar();

            // Dá errado se o visual studio estiver em pt-BR, pois está mandando vírgula ao invés de ponto para o BD.

            bd.ExecutarComandosSql((String.Format("UPDATE Reflorestamento SET arvoresARepor = {0} WHERE codCalculo LIKE {1}", QuantidadeRepor //arg 0
                , codDesmatamentoClicado)));// arg 1

            bd.Desconectar();

            return true;
        }


    }
}



