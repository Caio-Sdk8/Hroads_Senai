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
    public class HabilidadeRepository : IHabilidadeRepository
    {
        HroadsContext ctx = new HroadsContext();
        public void Atualizar(int idHabilidade, Habilidade habilidadeAtualizada)
        {
            Habilidade HabilidadeBuscada = BuscarPorId(idHabilidade);

            if (habilidadeAtualizada.NomeHab != null)
            {
                HabilidadeBuscada.NomeHab = habilidadeAtualizada.NomeHab;
            }
            if (habilidadeAtualizada.IdTipoHab != null)
            {
                HabilidadeBuscada.IdTipoHab = habilidadeAtualizada.IdTipoHab;
            }

            ctx.Habilidades.Update(HabilidadeBuscada);

            ctx.SaveChanges();
        }

        public Habilidade BuscarPorId(int idHabilidade)
        {
            return ctx.Habilidades.FirstOrDefault(cb => cb.IdHabilidade == idHabilidade);
        }

        public void Cadastrar(Habilidade habilidade)
        {
            ctx.Habilidades.Add(habilidade);

            ctx.SaveChanges();
        }

        public void Deletar(int idHabilidade)
        {
            Habilidade habilidadeBuscada = BuscarPorId(idHabilidade);

            ctx.Habilidades.Add(habilidadeBuscada);

            ctx.SaveChanges();
        }

        public List<Habilidade> Listar()
        {
            return ctx.Habilidades.Select(x => new Habilidade
            {
                IdTipoHab = x.IdTipoHab,
                IdTipoHabNavigation = new TipoHabilidade
                {
                    NomeTipoHab = x.IdTipoHabNavigation.NomeTipoHab
                }
            }).Include(x => x.IdTipoHabNavigation).ToList();
        }
    }
}
