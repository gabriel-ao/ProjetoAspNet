using LojaVirtualV2.Models;
using System.Collections.Generic;

namespace LojaVirtualV2.Repositories.Contracts
{
    public interface INewsletterRepository
    {
        void Cadastrar(NewLetterEmail newsletter);
        
        IEnumerable<NewLetterEmail> ObterTodsNewsletter();
    }
}
