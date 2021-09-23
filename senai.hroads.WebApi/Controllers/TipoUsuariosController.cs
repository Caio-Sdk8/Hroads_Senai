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
    public class TipoUsuariosController : ControllerBase
    {
        private ITipoUsuarioRepository _TipoUsuarioRepository { get; set; }

        public TipoUsuariosController()
        {
            _TipoUsuarioRepository = new TipoUsuarioRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_TipoUsuarioRepository.Listar());
        }

        [HttpGet("{idTipoUsuario}")]
        public IActionResult BuscarPorId(int idTipoUsuario)
        {
            return Ok(_TipoUsuarioRepository.BuscarPorId(idTipoUsuario));
        }

        [HttpPost]
        public IActionResult Cadastrar(TipoUsuario novaTipoUsuario)
        {
            _TipoUsuarioRepository.Cadastrar(novaTipoUsuario);

            return StatusCode(201);
        }

        [HttpPut("{idTipoUsuario}")]
        public IActionResult Atualizar(int idTipoUsuario, TipoUsuario TipoUsuarioAtualizada)
        {
            _TipoUsuarioRepository.Atualizar(idTipoUsuario, TipoUsuarioAtualizada);

            return StatusCode(204);
        }

        [HttpDelete("{idTipoUsuario}")]
        public IActionResult Deletar(int idTipoUsuario)
        {
            _TipoUsuarioRepository.Deletar(idTipoUsuario);

            return StatusCode(204);
        }
    }
}
