using LojaVirtualV2.Database;
using LojaVirtualV2.Models;
using LojaVirtualV2.Repositories.Contracts;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace LojaVirtualV2.Repositories
{
    public class ColaboradorRepository : IColaboradorRepository
    {
        private LojaVirtualContext _banco;
        private IConfiguration _conf;

        public ColaboradorRepository(LojaVirtualContext banco, IConfiguration configuration)
        {
            _banco = banco;
            _conf = configuration;
        }

        public void Atualizar(Colaborador colaborador)
        {
            _banco.Update(colaborador);
            _banco.SaveChanges();
        }

        public void Cadastrar(Colaborador colaborador)
        {
            _banco.Add(colaborador);
            _banco.SaveChanges();
        }

        public void Excluir(int Id)
        {
            _banco.Remove(ObterColaborador(Id));
            _banco.SaveChanges();
        }

        public Colaborador login(string Email, string Senha)
        {
            return _banco.Colaboradores.Where(C => C.Email == Email && C.Senha == Senha).FirstOrDefault();
            //return _banco.Colaboradores.Find(1);

        }

        public Colaborador ObterColaborador(int Id)
        {
            return _banco.Colaboradores.Find(Id);
        }

        public IPagedList<Colaborador> ObterTodosColaboradores(int? pagina)
        {
            int RegistroPorPagina = _conf.GetValue<int>("RegistroPorPagina");
            int NumeroPagina = pagina ?? 1;
            return _banco.Colaboradores.Where(a => a.Tipo != "G").ToPagedList<Colaborador>(NumeroPagina, RegistroPorPagina);
        }
    }
}
