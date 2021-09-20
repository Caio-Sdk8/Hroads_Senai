using senai.hroads.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.WebApi.Interfaces
{
    interface IPersonagemRepository
    {
        List<Personagem> Listar();

        Personagem BuscarPorId(int idPersonagem);

        void Cadastrar(Personagem personagem);

        void Atualizar(int idPersonagem, Personagem personagemAtualizado);

        void Deletar(int idPersonagem);
    }
}
