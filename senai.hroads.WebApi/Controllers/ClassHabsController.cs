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
    public class ClassHabsController : ControllerBase
    {
        private IClassHabRepository _ClassHabRepository { get; set; }

        public ClassHabsController()
        {
            _ClassHabRepository = new ClassHabRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_ClassHabRepository.Listar());
        }

        [HttpGet("{idClassHab}")]
        public IActionResult BuscarPorId(int idClassHab)
        {
            return Ok(_ClassHabRepository.BuscarPorId(idClassHab));
        }

        [HttpPost]
        public IActionResult Cadastrar(ClassHab novaClassHab)
        {
            _ClassHabRepository.Cadastrar(novaClassHab);

            return StatusCode(201);
        }

        [HttpPut("{idClassHab}")]
        public IActionResult Atualizar(int idClassHab, ClassHab classHabAtualizada)
        {
            _ClassHabRepository.Atualizar(idClassHab, classHabAtualizada);

            return StatusCode(204);
        }

        [HttpDelete("{idClassHab}")]
        public IActionResult Deletar(int idClassHab)
        {
            _ClassHabRepository.Deletar(idClassHab);

            return StatusCode(204);
        }
    }
}
