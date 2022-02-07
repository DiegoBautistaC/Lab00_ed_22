using Lab00_118182.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab00_118182.Helpers
{
    public class ClienteData
    {
        private static ClienteData _instancia = null;

        public static ClienteData Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ClienteData();
                }
                return _instancia;
            }
        }

        public List<ClienteModel> ListaCliente = new List<ClienteModel>
        {
            new ClienteModel
            {
                ID = 1,
                Nombre = "Lourdes",
                Apellido = "Reyes",
                Telefono = 12345678,
                Descripcion = "Vive en Mixco, Ciudad de Guatemala 100 calle, zona 2"
            },
            new ClienteModel
            {
                ID = 2,
                Nombre = "Maximus",
                Apellido = "Primero",
                Telefono = 10102013,
                Descripcion = "Pueblo de Chiquimula, cerca de la basícila de esquipulas."
            }
        };
    }
}
