using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.WebApi.Domains
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string Username { get; set; }
        public string EmailUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public int? IdTipoUsuario { get; set; }

        public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; }
    }
}
