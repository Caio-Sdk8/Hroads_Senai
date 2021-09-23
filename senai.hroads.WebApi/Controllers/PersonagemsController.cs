using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.hroads.WebApi.Domains;
using senai.hroads.WebApi.Interfaces;
using senai.hroads.WebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.WebApi.Controllers
{
    [Produces("application/jsn")]
    [Route("api/[controller]")]
    [ApiController]
    public class PersonagemsController : ControllerBase
    {
        private IPersonagemRepository _PersonagemRepository { get; set; }

        public PersonagemsController()
        {
            _PersonagemRepository = new PersonagemRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_PersonagemRepository.Listar());
        }

        [HttpGet("{idPersonagem}")]
        public IActionResult BuscarPorId(int idPersonagem)
        {
            return Ok(_PersonagemRepository.BuscarPorId(idPersonagem));
        }

        [HttpPost]
        public IActionResult Cadastrar(Personagem novaPersonagem)
        {
            _PersonagemRepository.Cadastrar(novaPersonagem);

            return StatusCode(201);
        }

        [HttpPut("{idPersonagem}")]
        public IActionResult Atualizar(int idPersonagem, Personagem PersonagemAtualizada)
        {
            _PersonagemRepository.Atualizar(idPersonagem, PersonagemAtualizada);

            return StatusCode(204);
        }

        [HttpDelete("{idPersonagem}")]
        public IActionResult Deletar(int idPersonagem)
        {
            _PersonagemRepository.Deletar(idPersonagem);

            return StatusCode(204);
        }
    }
}
