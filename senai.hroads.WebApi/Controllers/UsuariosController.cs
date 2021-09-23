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
    public class UsuariosController : ControllerBase
    {
        private IUsuarioRepository _UsuarioRepository { get; set; }

        public UsuariosController()
        {
            _UsuarioRepository = new UsuarioRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_UsuarioRepository.Listar());
        }

        [HttpGet("{idUsuario}")]
        public IActionResult BuscarPorId(int idUsuario)
        {
            return Ok(_UsuarioRepository.BuscarPorId(idUsuario));
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario novaUsuario)
        {
            _UsuarioRepository.Cadastrar(novaUsuario);

            return StatusCode(201);
        }

        [HttpPut("{idUsuario}")]
        public IActionResult Atualizar(int idUsuario, Usuario UsuarioAtualizada)
        {
            _UsuarioRepository.Atualizar(idUsuario, UsuarioAtualizada);

            return StatusCode(204);
        }

        [HttpDelete("{idUsuario}")]
        public IActionResult Deletar(int idUsuario)
        {
            _UsuarioRepository.Deletar(idUsuario);

            return StatusCode(204);
        }
    }
}
