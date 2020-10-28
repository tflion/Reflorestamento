using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net;
using System.Net.Mail;

namespace SAReflorestamento
{
    class ClassRecuperar
    {
        public string EmailEsquecido { get; set; }
        ClassAcessoBD bd = new ClassAcessoBD();

        public static void EnvioEmail(string email, string senha)
        {
            frmRecuperarSenha recuperar = new frmRecuperarSenha();
            var client = new SmtpClient("smtp.gmail.com", 587)// Configura os parâmentros do gmail
            {
                Credentials = new NetworkCredential("tpappercompany@gmail.com", "tpapper123"), // Email que enviará a senha
                EnableSsl = true
            };
            try
            {
                //Mensagem que o email irá mandar 
                client.Send("tppapercompany@gmail.com", email, " Recuperação de senha TPapper", " a sua senha é " + senha + ".");
            }
            catch
            {
                recuperar.SemInternet();
            }
        }
        public bool EsqueceuSenha()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario WHERE email LIKE '{0}'", EmailEsquecido));
            bd.Desconectar();
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                string emailRegistrado = dt.Rows[0]["email"].ToString();
                string senhaRegistrada = dt.Rows[0]["senhaUs"].ToString();
                EnvioEmail(emailRegistrado, senhaRegistrada);
                return true;
            }
        }
    }
}

