﻿using senai.hroads.WebApi.Domains;
using senai.hroads.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.WebApi.Repositories
{
    public class PersonagemRepository : IPersonagemRepository
    {
        public void Atualizar(int idPersonagem, Personagem personagemAtualizado)
        {
            throw new NotImplementedException();
        }

        public Personagem BuscarPorId(int idPersonagem)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Personagem personagem)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idPersonagem)
        {
            throw new NotImplementedException();
        }

        public List<Personagem> Listar()
        {
            throw new NotImplementedException();
        }
    }
}