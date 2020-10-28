using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SAReflorestamento
{
    class ClassUsuario
    {  // Propriedades
        public int CodUsuario { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string LoginUs { get; set; }
        public string SenhaUs { get; set; }
        public string TipoUsuario { get; set; }

        //Objetos
        ClassAcessoBD bd = new ClassAcessoBD();

        // métodos crud

        public bool Inserir()
        {
            try
            {
                // Conecta no banco
                bd.Conectar();

                // Executa o insert
                bd.ExecutarComandosSql(string.Format("INSERT INTO Usuario (nome,telefone,cpf,email,loginUs,senhaUs,tipoUsuario) "  +
                    "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}',{6})", Nome, Telefone, Cpf, Email,LoginUs,SenhaUs,TipoUsuario));


                // Desconecta no banco

                bd.Desconectar();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " Erro ao inserir cliente! ");
            }
        }

        public DataTable RetTodosClientes()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(string.Format("SELECT * FROM Usuario"));

            bd.Desconectar();

            return dt;
        }
       
        public bool Editar(int codUsuarioClicado)
        {
            bd.Conectar();

            bd.ExecutarComandosSql(String.Format("UPDATE Usuario SET tipoUsuario = {0} , nome = '{1}', telefone = '{2}'"
                + ", cpf = '{3}' ,  email = '{4}', loginUs = '{5}', senhaUs = '{6}' WHERE codUsuario LIKE '{7}'", TipoUsuario // arg 0
                , Nome // arg 1
                , Telefone // arg 2
                , Cpf // arg 3
                , Email // arg 4
                , LoginUs // arg 5
                , SenhaUs // arg 6
                ,codUsuarioClicado));// arg 7
             

            bd.Desconectar();

            return true;
        }

        public bool Excluir(int codUsuarioClicado)


        {
            bd.Conectar();

            bd.ExecutarComandosSql(String.Format("DELETE FROM Usuario WHERE codUsuario = {0}",
                codUsuarioClicado));

            bd.Desconectar();

            return true;
        }

        public DataTable RealizarLogin()
        {
            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario" +
                " WHERE loginUs LIKE '{0}' AND senhaUs LIKE '{1}'", LoginUs, SenhaUs));

            bd.Desconectar();

            return dt;
        }

        public int VerificarCpf(string cpf)
        {
            int v;
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario WHERE cpf = '{0}'", cpf));

            bd.Conectar();

            v = dt.Rows.Count;

            bd.Desconectar();

            // Caso exista o cpf preenchido retorna 1

            return v;
        }

        public int VerificarEmail(string email)
        {
            int z;

            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario WHERE email = '{0}' ", email));

            bd.Conectar();

            z = dt.Rows.Count;

            bd.Desconectar();

            // Caso exista algum email preenchido retorna 1

            return z;


        }

        public DataTable RetUsuariosNome (string busca)
        {
            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario WHERE nome like '%{0}%'", busca));

            bd.Desconectar();

                return dt;
        }
    }
}