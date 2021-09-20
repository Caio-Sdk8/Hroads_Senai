using senai.hroads.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.WebApi.Interfaces
{
    interface ITipoHabilidadeRepository
    {
        List<TipoHabilidade> Listar();

        TipoHabilidade BuscarPorId(int idTipoHabilidade);

        void Cadastrar(TipoHabilidade TipoHabilidade);

        void Atualizar(int idTipoHabilidade, TipoHabilidade TipoHabilidadeAtualizada);

        void Deletar(int idTipoHabilidade);
    }
}
