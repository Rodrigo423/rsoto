using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CentroAlumnos.BL;


namespace CentroAlumnos
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // para redireccionar al default del usuario cuando exista algún error
            if (User.Identity.IsAuthenticated)
            {
                
                Response.Redirect("~/Default.aspx");
                
            }
            

        }
    }
}