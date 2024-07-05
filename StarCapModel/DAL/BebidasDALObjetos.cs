using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel.DAL
{
    public class BebidasDALObjetos : IBebidasDAL
    {
        private static List<Bebida> bebidas = new List<Bebida>();

        public void Agregar()
        {
            throw new NotImplementedException();
        }

        public List<Bebida> ObtenerBebidas()
        {
            return new List<Bebida>()
            {
                new Bebida()
                {
                    Nombre = "Frapuccino",
                    Codigo = "FP-01"
                },
                new Bebida()
                {
                    Nombre = "Te Chai",
                    Codigo = "TC-01"
                },
                new Bebida()
                {
                    Nombre = "Te Verde",
                    Codigo = "TV-01"
                },
                new Bebida()
                {
                    Nombre = "Cafe Tradicional",
                    Codigo = "CF-01"
                },
            };
        }
    }
}
