using StarCapModel;
using StarCapModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StarCap
{
    public partial class VerClientes : System.Web.UI.Page
    {
        private IClientesDAL clientesDAL = new ClientesDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGrilla();
            }
        }

        protected void grillaClientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                string rut = Convert.ToString(e.CommandArgument);
                clientesDAL.Eliminar(rut);
                cargarGrilla();

            }
        }

        private void cargarGrilla()
        {
            List<Cliente> clientes = clientesDAL.ObtenerClientes();
            this.grillaClientes.DataSource = clientes;
            this.grillaClientes.DataBind();
        }

        private void cargarGrilla(List<Cliente> filtrada)
        {
            this.grillaClientes.DataSource = filtrada;
            this.grillaClientes.DataBind();
        }


        protected void nivelDbl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.nivelDbl.SelectedItem != null)
            {
                int nivel = Convert.ToInt32(this.nivelDbl.SelectedItem.Value);
                if (nivel != 0)
                {
                    List<Cliente> filtrada = clientesDAL.Filtrar(nivel);
                    cargarGrilla(filtrada);
                }
                else
                {
                    cargarGrilla();
                }
            }
            
        }
    }
}