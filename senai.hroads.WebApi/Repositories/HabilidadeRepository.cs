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
            throw new NotImplementedException();
        }

        public void Cadastrar(Habilidade habilidade)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idHabilidade)
        {
            throw new NotImplementedException();
        }

        public List<Habilidade> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
