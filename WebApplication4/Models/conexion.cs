using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
   public class conexion
    {
        private conexion()
        { }
        private readonly static conexion _instancia = new conexion();

        public static conexion instancia
        {
            get { return _instancia; }
        }

        public string cadenaconexion()
        {
            return "Data Source=.;initial catalog=prueba;Persist Security Info=True; User ID=sa; Password='123456'";
        }
    }
}
