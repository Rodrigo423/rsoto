using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;

namespace CentroAlumnos.BL
{
    public class UsuariosBL
    {
        private Database1Entities1 Bd = new Database1Entities1();

        public bool validaCredenciales(string username, string password)
        {
            List<Usuarios> lista = (from u in Bd.Usuarios where u.Username == username && u.Password == password select u).ToList();

            return lista.Count > 0;

        }


        // metodo que retorna una instancia de la clase usuario
        public Usuarios GetUsuario(string username)
        {
            return (from u in Bd.Usuarios where u.Username == username select u).FirstOrDefault();
        }
    }
}