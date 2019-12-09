using LojaVirtualV2.Libraries.Lang;
using System.ComponentModel.DataAnnotations;

namespace LojaVirtualV2.Models
{
    public class NewLetterEmail
    {
        public int Id { get; set; }


        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [EmailAddress(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E004")]
        public string Email { get; set; }


    }
}
