using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AceesoDatos;
using Common.Cache;


namespace Negocio
{
    public class UsuarioNegocio
    {
        UseDao useDao = new UseDao();
        public bool LoginUser(string user, string pass)
        {
            return useDao.Login(user,pass);
            
        }
    }
}
