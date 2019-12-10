using LojaVirtualV2.Database;
using LojaVirtualV2.Models;
using LojaVirtualV2.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LojaVirtualV2.Repositories
{
    public class NewsletterRepository : INewsletterRepository
    {
        private LojaVirtualContext _banco;
        public NewsletterRepository(LojaVirtualContext banco)
        {
            _banco = banco;
        }
        public void Cadastrar(NewLetterEmail newsletter)
        {
            _banco.NewLetterEmail.Add(newsletter);
            _banco.SaveChanges();
        }

        public IEnumerable<NewLetterEmail> ObterTodsNewsletter()
        {
            return _banco.NewLetterEmail.ToList();
        }
    }
}
