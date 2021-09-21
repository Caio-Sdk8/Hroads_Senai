using Microsoft.EntityFrameworkCore;
using senai.hroads.WebApi.Contexts;
using senai.hroads.WebApi.Domains;
using senai.hroads.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.WebApi.Repositories
{
    public class ClassHabRepository : IClassHabRepository
    {
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int idClassHab, ClassHab ClassHabAtualizada)
        {
            ClassHab cBBuscada = BuscarPorId(idClassHab);

            if (ClassHabAtualizada.IdHabilidade != null)
            {
                cBBuscada.IdHabilidade = ClassHabAtualizada.IdHabilidade;
            }
            else if(ClassHabAtualizada.IdClasse != null)
            {
                cBBuscada.IdClasse = ClassHabAtualizada.IdClasse;
            }

            ctx.ClassHabs.Update(cBBuscada);

            ctx.SaveChanges();
        }

        public ClassHab BuscarPorId(int idClassHab)
        {

            return ctx.ClassHabs.FirstOrDefault(cb => cb.IdClassHab == idClassHab);
        }

        public void Cadastrar(ClassHab ClassHab)
        {
            ctx.ClassHabs.Add(ClassHab);

            ctx.SaveChanges();
        }

        public void Deletar(int idClassHab)
        {
            ClassHab cBBuscado = BuscarPorId(idClassHab);

            ctx.ClassHabs.Add(cBBuscado);

            ctx.SaveChanges();
        }

        public List<ClassHab> Listar()
        {
            return ctx.ClassHabs.Select(x => new ClassHab {
                IdClassHab = x.IdClassHab,
                IdClasseNavigation = new Classe
                {
                    NomeClasse = x.IdClasseNavigation.NomeClasse
                },
                IdHabilidadeNavigation = new Habilidade
                {
                    NomeHab = x.IdHabilidadeNavigation.NomeHab
                }
            }).Include(x => x.IdClasseNavigation).Include(x => x.IdHabilidadeNavigation).ToList();
        }
    }
}
