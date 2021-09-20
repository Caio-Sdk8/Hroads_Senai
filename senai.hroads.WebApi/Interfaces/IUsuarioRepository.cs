using senai.hroads.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.WebApi.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuario> Listar();

        Usuario BuscarPorId(int idUsuario);

        void Cadastrar(Usuario Usuario);

        void Atualizar(int idUsuario, Usuario UsuarioAtualizado);

        void Deletar(int idUsuario);
    }
}
