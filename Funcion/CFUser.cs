using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BASEDATOS;
namespace Funcion
{
    public class CFUser
    {
        private CDUser user = new CDUser();
        public List<Users> Listar()
        {
            return user.Listar();
        }
    }
}
