using senai.hroads.WebApi.Contexts;
using senai.hroads.WebApi.Domains;
using senai.hroads.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.WebApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int idUsuario, Usuario UsuarioAtualizado)
        {
            throw new NotImplementedException();
        }

        //public Usuario Login(string email, string senha)
        //{
        //   return ctx.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        //}

        public Usuario BuscarPorId(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuario Usuario)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
