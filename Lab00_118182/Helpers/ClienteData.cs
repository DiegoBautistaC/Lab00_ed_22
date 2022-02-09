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
            },
            new ClienteModel
            {
                ID = 3,
                Nombre = "Andres",
                Apellido = "Cruz",
                Telefono = 04112002,
                Descripcion = "San Miguel Petapa, Guatemala, El mundo."
            },
            new ClienteModel
            {
                ID = 4,
                Nombre = "Shinji",
                Apellido = "Ikari",
                Telefono = 07072021,
                Descripcion = "Nerv, en las ruinas de la ciudad de Tokio."
            },
            new ClienteModel
            {
                ID = 5,
                Nombre = "Rei",
                Apellido = "Ayanami",
                Telefono = 57894352,
                Descripcion = "Guillen, zona 3, Villa Nueva, Guatemala."
            },
            new ClienteModel
            {
                ID = 6,
                Nombre = "Herman",
                Apellido = "Manckewicks",
                Telefono = 15081940,
                Descripcion = "Miami, Florida, Hollywood, Estados Unidos."
            },
            new ClienteModel
            {
                ID = 7,
                Nombre = "Orson",
                Apellido = "Wells",
                Telefono = 30121946,
                Descripcion = "Montaña los amates, Alta Verapaz."
            },
            new ClienteModel
            {
                ID = 8,
                Nombre = "Eduardo",
                Apellido = "Reyes",
                Telefono = 05011977,
                Descripcion = "Calle principal, zona 1, Ciudad de Guatemala, Guatemala."
            },
            new ClienteModel
            {
                ID = 9,
                Nombre = "Floridalma",
                Apellido = "Paniagua",
                Telefono = 22021976,
                Descripcion = "Santa Inés, Villa Canales, Guatemala."
            }
        };
    }
}
