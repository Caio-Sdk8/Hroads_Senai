using senai.hroads.WebApi.Contexts;
using senai.hroads.WebApi.Domains;
using senai.hroads.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.WebApi.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int idTipoUsuario, TipoUsuario TipoUsuarioAtualizado)
        {
            TipoUsuario tipoBuscado = BuscarPorId(idTipoUsuario);

            if (TipoUsuarioAtualizado.DescricaoTipoUsuario != null)
            {
                tipoBuscado.DescricaoTipoUsuario = TipoUsuarioAtualizado.DescricaoTipoUsuario;
            }

            ctx.TipoUsuarios.Update(tipoBuscado);

            ctx.SaveChanges();
        }

        public TipoUsuario BuscarPorId(int idTipoUsuario)
        {
            return ctx.TipoUsuarios.FirstOrDefault(cb => cb.IdTipoUsuario == idTipoUsuario);
        }

        public void Cadastrar(TipoUsuario TipoUsuario)
        {
            ctx.TipoUsuarios.Add(TipoUsuario);

            ctx.SaveChanges();
        }

        public void Deletar(int idTipoUsuario)
        {
            TipoUsuario tipoBuscado = BuscarPorId(idTipoUsuario);

            ctx.TipoUsuarios.Add(tipoBuscado);

            ctx.SaveChanges();
        }

        public List<TipoUsuario> Listar()
        {
            return ctx.TipoUsuarios.ToList();
        }
    }
}
