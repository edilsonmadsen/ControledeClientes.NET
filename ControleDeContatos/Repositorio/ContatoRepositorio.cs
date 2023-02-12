using ControleDeContatos.Data;
using ControleDeContatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeContatos.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _context;
        public ContatoRepositorio(BancoContext bancoContext)
        {
            _context = bancoContext;  
        }
        public ContatoModelcs listarPorId(int id)
        {
            return _context.Contatos.FirstOrDefault(x => x.Id == id);
        }

        public List<ContatoModelcs> BuscarTodos()
        {
            return _context.Contatos.ToList();
        }
        public ContatoModelcs Adicionar(ContatoModelcs contato)
        {
            _context.Contatos.Add(contato);
            _context.SaveChanges();
            return contato;
        }

        public ContatoModelcs Atualizar(ContatoModelcs contato)
        {
            ContatoModelcs contatoDB = listarPorId(contato.Id);

            if (contatoDB == null) throw new System.Exception("Houve um erro na atualização do contato!");

            contatoDB.Cliente = contato.Cliente;
            contatoDB.Cpf = contato.Cpf;
            contatoDB.DataNasc = contato.DataNasc;
            contatoDB.Estado = contato.Estado;
            contatoDB.Cidade = contato.Cidade;
            contatoDB.Sexo = contato.Sexo;

            _context.Contatos.Update(contatoDB);
            _context.SaveChanges();

            return contatoDB;

        }

        public bool Apagar(int id)
        {
            ContatoModelcs contatoDB = listarPorId(id);

            if (contatoDB == null) throw new System.Exception("Houve um erro na remoção do contato!");

            _context.Contatos.Remove(contatoDB);
            _context.SaveChanges();

            return true;
        }
    }
}
