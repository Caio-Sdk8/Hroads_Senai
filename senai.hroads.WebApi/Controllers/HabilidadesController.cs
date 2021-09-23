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
    public class HabilidadesController : ControllerBase
    {
        private IHabilidadeRepository _HabilidadeRepository { get; set; }

        public HabilidadesController()
        {
            _HabilidadeRepository = new HabilidadeRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_HabilidadeRepository.Listar());
        }

        [HttpGet("{idHabilidade}")]
        public IActionResult BuscarPorId(int idHabilidade)
        {
            return Ok(_HabilidadeRepository.BuscarPorId(idHabilidade));
        }

        [HttpPost]
        public IActionResult Cadastrar(Habilidade novaHabilidade)
        {
            _HabilidadeRepository.Cadastrar(novaHabilidade);

            return StatusCode(201);
        }

        [HttpPut("{idHabilidade}")]
        public IActionResult Atualizar(int idHabilidade, Habilidade HabilidadeAtualizada)
        {
            _HabilidadeRepository.Atualizar(idHabilidade, HabilidadeAtualizada);

            return StatusCode(204);
        }

        [HttpDelete("{idHabilidade}")]
        public IActionResult Deletar(int idHabilidade)
        {
            _HabilidadeRepository.Deletar(idHabilidade);

            return StatusCode(204);
        }
    }
}
