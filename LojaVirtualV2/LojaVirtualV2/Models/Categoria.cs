using LojaVirtualV2.Libraries.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtualV2.Models
{
    public class Categoria
    {

        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(3, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E002")]
        //TODO - Criar validação - Nome Catogoria Unico no banco de dados.
        public string Nome { get; set; }

        /*
         * Slug: 
         */
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(3, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E002")]
        public string Slug { get; set; }

        [Display(Name = "Categoria Pai")]
        public int? CategoriaPaiId { get; set; }


        // ORM
            [ForeignKey ("CategoriaPaiId")]
            public virtual Categoria CategoriaPai { get; set; }



    }
}
