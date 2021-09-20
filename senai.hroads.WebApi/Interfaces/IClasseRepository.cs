using senai.hroads.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.WebApi.Interfaces
{
    interface IClasseRepository
    {
        List<Classe> Listar();

        Classe BuscarPorId(int idClasse);

        void Cadastrar(Classe classe);

        void Atualizar(int idClasse, Classe classeAtualizada);

        void Deletar(int idClasse);
    }
}
