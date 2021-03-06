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
    public class ClassesController : ControllerBase
    {
        private IClasseRepository _ClasseRepository { get; set; }

        public ClassesController()
        {
            _ClasseRepository = new ClasseRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_ClasseRepository.Listar());
        }

        [HttpGet("{idClasse}")]
        public IActionResult BuscarPorId(int idClasse)
        {
            return Ok(_ClasseRepository.BuscarPorId(idClasse));
        }

        [HttpPost]
        public IActionResult Cadastrar(Classe novaClasse)
        {
            _ClasseRepository.Cadastrar(novaClasse);

            return StatusCode(201);
        }

        [HttpPut("{idClasse}")]
        public IActionResult Atualizar(int idClasse, Classe ClasseAtualizada)
        {
            _ClasseRepository.Atualizar(idClasse, ClasseAtualizada);

            return StatusCode(204);
        }

        [HttpDelete("{idClasse}")]
        public IActionResult Deletar(int idClasse)
        {
            _ClasseRepository.Deletar(idClasse);

            return StatusCode(204);
        }
    }
}
