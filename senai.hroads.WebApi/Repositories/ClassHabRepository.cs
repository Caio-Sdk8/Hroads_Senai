using senai.hroads.WebApi.Contexts;
using senai.hroads.WebApi.Domains;
using senai.hroads.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.WebApi.Repositories
{
    public class ClassHabRepository : IClassHabRepository
    {
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int idClassHab, ClassHab ClassHabAtualizada)
        {
            ClassHabAtualizada
        }

        public ClassHab BuscarPorId(int idClassHab)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(ClassHab ClassHab)
        {
           
        }

        public void Deletar(int idClassHab)
        {
            throw new NotImplementedException();
        }

        public List<ClassHab> Listar()
        {
            return ctx.ClassHabs.ToList();
        }
    }
}
