using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel
{
    public class Cliente
    {
        private string rut;
        private string nombre;
        private int nivel;
        private Bebida bebidaFavorita;

        public string NivelString
        {
            get
            {
                string nivelString = "";
                switch (nivel)
                {
                    case 1:
                        nivelString = "Silver";
                        break;
                    case 2:
                        nivelString = "Gold";
                        break;
                    case 3:
                        nivelString = "Platinum";
                        break;
                }
                return nivelString;
            }
        }

        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public Bebida BebidaFavorita { get => bebidaFavorita; set => bebidaFavorita = value; }
    }
}
