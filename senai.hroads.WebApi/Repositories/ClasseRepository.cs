using senai.hroads.WebApi.Contexts;
using senai.hroads.WebApi.Domains;
using senai.hroads.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.WebApi.Repositories
{
    public class ClasseRepository : IClasseRepository
    {
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int idClasse, Classe classeAtualizada)
        {
            Classe classeBuscada = BuscarPorId(idClasse);

            if (classeAtualizada.NomeClasse != null)
            {
                classeBuscada.NomeClasse = classeAtualizada.NomeClasse;
            }

            ctx.Classes.Update(classeBuscada);

            ctx.SaveChanges();
        }

        public Classe BuscarPorId(int idClasse)
        {
            return ctx.Classes.FirstOrDefault(cb => cb.IdClasse == idClasse);
        }

        public void Cadastrar(Classe classe)
        {
            ctx.Classes.Add(classe);

            ctx.SaveChanges();
        }

        public void Deletar(int idClasse)
        {
            Classe classeBuscada = BuscarPorId(idClasse);

            ctx.Classes.Add(classeBuscada);

            ctx.SaveChanges();
        }

        public List<Classe> Listar()
        {
            return ctx.Classes.ToList();
        }
    }
}
