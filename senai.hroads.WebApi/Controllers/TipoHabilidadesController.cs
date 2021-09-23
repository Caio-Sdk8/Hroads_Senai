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
    public class TipoHabilidadesController : ControllerBase
    {
        private ITipoHabilidadeRepository _TipoHabilidadeRepository { get; set; }

        public TipoHabilidadesController()
        {
            _TipoHabilidadeRepository = new TipoHabilidadeRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_TipoHabilidadeRepository.Listar());
        }

        [HttpGet("{idTipoHabilidade}")]
        public IActionResult BuscarPorId(int idTipoHabilidade)
        {
            return Ok(_TipoHabilidadeRepository.BuscarPorId(idTipoHabilidade));
        }

        [HttpPost]
        public IActionResult Cadastrar(TipoHabilidade novaTipoHabilidade)
        {
            _TipoHabilidadeRepository.Cadastrar(novaTipoHabilidade);

            return StatusCode(201);
        }

        [HttpPut("{idTipoHabilidade}")]
        public IActionResult Atualizar(int idTipoHabilidade, TipoHabilidade TipoHabilidadeAtualizada)
        {
            _TipoHabilidadeRepository.Atualizar(idTipoHabilidade, TipoHabilidadeAtualizada);

            return StatusCode(204);
        }

        [HttpDelete("{idTipoHabilidade}")]
        public IActionResult Deletar(int idTipoHabilidade)
        {
            _TipoHabilidadeRepository.Deletar(idTipoHabilidade);

            return StatusCode(204);
        }
    }
}
