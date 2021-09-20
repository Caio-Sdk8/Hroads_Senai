using senai.hroads.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.WebApi.Interfaces
{
    interface IClassHabRepository
    {
        List<ClassHab> Listar();

        ClassHab BuscarPorId(int idClassHab);

        void Cadastrar(ClassHab ClassHab);

        void Atualizar(int idClassHab, ClassHab ClassHabAtualizada);

        void Deletar(int idClassHab);
    }
}
