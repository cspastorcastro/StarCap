using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel.DAL
{
    public interface IClientesDAL
    {
        List<Cliente> ObtenerClientes();

        List<Cliente> Filtrar(int nivel);

        void Agregar(Cliente cliente);

        void Eliminar(string rut);
    }
}
