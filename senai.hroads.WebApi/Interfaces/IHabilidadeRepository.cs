using senai.hroads.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.WebApi.Interfaces
{
    interface IHabilidadeRepository
    {
        List<Habilidade> Listar();

        Habilidade BuscarPorId(int idHabilidade);

        void Cadastrar(Habilidade habilidade);

        void Atualizar(int idHabillidade, Habilidade habilidadeAtualizada);

        void Deletar(int idHabilidade);
    }
}
