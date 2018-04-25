using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class parametros
    {
        public string tipo { get; set; }
        public string valor { get; set; }

        public parametros(String _tipo, String _valor) {
            tipo = _tipo;
            valor = _valor;

        }

        public parametros()
        {
        }
    }
}