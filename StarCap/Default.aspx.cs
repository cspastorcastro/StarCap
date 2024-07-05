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
    public partial class Default : System.Web.UI.Page
    {
        private IClientesDAL clientesDAL = new ClientesDALObjetos();
        private IBebidasDAL bebidasDAL = new BebidasDALObjetos();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Bebida> bebidas = bebidasDAL.ObtenerBebidas();
                this.bebidaDb1.DataSource = bebidas;
                this.bebidaDb1.DataTextField = "nombre";
                this.bebidaDb1.DataValueField = "codigo";
                this.bebidaDb1.DataBind();
                
            }
        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            /*
             * 1. Obtener los datos del formulario
             * 2. Construit el objeto de tipo cliente
             * 3. Llamar al DAL
             * 4. Mostrar el mensaje de éxito
            */

            // 1.
            string nombre = this.nombreTxt.Text.Trim();
            string rut = this.rutTxt.Text.Trim();
            int nivel = Convert.ToInt32(this.nivelRbl.SelectedItem.Value);
            string bebidaValor = this.bebidaDb1.SelectedValue;
            string bebidaTexto = this.bebidaDb1.SelectedItem.Text;

            // 2.
            List<Bebida> bebidas = bebidasDAL.ObtenerBebidas();
            Bebida bebida = bebidas.Find(b => b.Codigo == this.bebidaDb1.SelectedItem.Value);
            /*
            Bebida bebida = new Bebida()
            {
                Codigo = bebidaValor,
                Nombre = bebidaTexto
            };
            */

            Cliente cliente = new Cliente()
            {
                Rut = rut,
                Nombre = nombre,
                Nivel = nivel,
                BebidaFavorita = bebida
            };

            // 3.
            clientesDAL.Agregar(cliente);

            //4.
            this.mensajeLbl.Text = "Cliente " + nombre + " ingresado correctamente.";
            Response.Redirect("VerClientes.aspx");
        }
    }
}