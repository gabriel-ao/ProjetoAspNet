using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtualV2.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        /*
         * Slug: 
         */
        public string Slug { get; set; }

        public int? CategoriaPaiId { get; set; }


        // ORM
            [ForeignKey ("CategoriaPaiId")]
            public virtual Categoria CategoriaPai { get; set; }



    }
}
