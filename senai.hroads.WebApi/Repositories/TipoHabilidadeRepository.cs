using senai.hroads.WebApi.Contexts;
using senai.hroads.WebApi.Domains;
using senai.hroads.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.WebApi.Repositories
{
    public class TipoHabilidadeRepository : ITipoHabilidadeRepository
    {
            HroadsContext ctx = new HroadsContext();
        public void Atualizar(int idTipoHabilidade, TipoHabilidade TipoHabilidadeAtualizada)
        {

            TipoHabilidade TipoHabBuscada = BuscarPorId(idTipoHabilidade);

            if (TipoHabilidadeAtualizada.NomeTipoHab != null)
            {
                TipoHabBuscada.NomeTipoHab = TipoHabilidadeAtualizada.NomeTipoHab;
            }

            ctx.TipoHabilidades.Update(TipoHabBuscada);

            ctx.SaveChanges();
        }

        public TipoHabilidade BuscarPorId(int idTipoHabilidade)
        {
            return ctx.TipoHabilidades.FirstOrDefault(cb => cb.IdTipoHab == idTipoHabilidade);
        }

        public void Cadastrar(TipoHabilidade TipoHabilidade)
        {
            ctx.TipoHabilidades.Add(TipoHabilidade);

            ctx.SaveChanges();
        }

        public void Deletar(int idTipoHabilidade)
        {
            TipoHabilidade tipoHabBuscada = BuscarPorId(idTipoHabilidade);

            ctx.TipoHabilidades.Add(tipoHabBuscada);

            ctx.SaveChanges();
        }

        public List<TipoHabilidade> Listar()
        {
            return ctx.TipoHabilidades.ToList();
        }
    }
}
