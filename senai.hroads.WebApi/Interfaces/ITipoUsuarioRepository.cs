using senai.hroads.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.WebApi.Interfaces
{
    interface ITipoUsuarioRepository
    {
        List<TipoUsuario> Listar();

        TipoUsuario BuscarPorId(int idTipoUsuario);

        void Cadastrar(TipoUsuario TipoUsuario);

        void Atualizar(int idTipoUsuario, TipoUsuario TipoUsuarioAtualizado);

        void Deletar(int idTipoUsuario);
    }
}
