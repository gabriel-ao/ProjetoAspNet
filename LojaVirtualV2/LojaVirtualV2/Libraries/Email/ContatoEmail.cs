using LojaVirtualV2.Models;
using System.Net;
using System.Net.Mail;

namespace LojaVirtualV2.Libraries.Email
{
    public class ContatoEmail
    {

        public static void EnviarContatoPorEmail(Contato contato)
        {
            ////primeiro parametro caminho
            ////segundo parametro porta
            

            SmtpClient smtp = new SmtpClient("smtp.office365.com", 587)
            {
                UseDefaultCredentials = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                // adicionar a senha no segundo parametro
                Credentials = new NetworkCredential("megatauros.gabriel@gmail.com", ""),
                
                EnableSsl = true
            };

            string corpoMsg = string.Format("<H2>Contato - Loja Virtual<H2>" 
                + "<b>Nome: </b> {0} <br/>"
                + "<b>E-mail: </b> {1} <br/>"
                + "<b>Texto: </b> {2} <br/>"
                + "<br /> Email enviado automarticamente por Gabriel de Oliveira",
                contato.Nome,
                contato.Email,
                contato.Texto
                );

            //MailMessage -> Construir a mensagem

            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("megatauros.gabriel@gmail.com");
            mensagem.To.Add("gabriel-ao@hotmail.com"); 
            mensagem.To.Add("gabriel.oliveira@fitcard.com.br");
            mensagem.Subject = "Contato - LojaVirtual - E-mail: " + contato.Email;
            mensagem.Body = corpoMsg;
            mensagem.IsBodyHtml = true;

            // eviar mensagem
            smtp.Send(mensagem);

        }
    }
}
