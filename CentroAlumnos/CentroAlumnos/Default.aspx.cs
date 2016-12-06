using CentroAlumnos.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentroAlumnos
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuarios u = new UsuariosBL().GetUsuario(User.Identity.Name);
            if (u.Rol.Equals("Alumno"))
            {
                Response.Redirect("~/Alumno.aspx");
            }
            else
            {
                Response.Redirect("~/Administrativo.aspx");
            }

        }
    }
}