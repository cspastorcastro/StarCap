﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel.DAL
{
    public interface IClientesDAL
    {
        List<Cliente> ObtenerClientes();

        void Agregar(Cliente cliente);
    }
}
