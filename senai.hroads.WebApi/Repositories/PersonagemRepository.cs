using senai.hroads.WebApi.Contexts;
using senai.hroads.WebApi.Domains;
using senai.hroads.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.WebApi.Repositories
{
    public class PersonagemRepository : IPersonagemRepository
    {

        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int idPersonagem, Personagem personagemAtualizado)
        {
            Personagem personagemBuscado = BuscarPorId(idPersonagem);

            if (personagemAtualizado.Nome != null)
            {
                personagemBuscado.Nome = personagemAtualizado.Nome;
            }
            if (personagemAtualizado.IdClasse != null)
            {
                personagemBuscado.IdClasse = personagemAtualizado.IdClasse;
            }
            personagemBuscado.CapMana = personagemAtualizado.CapMana;
            personagemBuscado.CapVida = personagemAtualizado.CapVida;
            personagemAtualizado.DataAtt = DateTime.Now;

            ctx.Personagems.Update(personagemBuscado);

            ctx.SaveChanges();
        }

        public Personagem BuscarPorId(int idPersonagem)
        {
            return ctx.Personagems.FirstOrDefault(cb => cb.IdPersonagem == idPersonagem);
        }

        public void Cadastrar(Personagem personagem)
        {
            personagem.DataCriacao = DateTime.Now;

            ctx.Personagems.Add(personagem);

            ctx.SaveChanges();
        }

        public void Deletar(int idPersonagem)
        {
            Personagem personagemBuscado = BuscarPorId(idPersonagem);

            ctx.Personagems.Add(personagemBuscado);

            ctx.SaveChanges();
        }

        public List<Personagem> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
