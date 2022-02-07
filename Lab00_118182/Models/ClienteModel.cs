using Lab00_118182.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab00_118182.Models
{
    public class ClienteModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Es necesario un nombre.")]
        [MaxLength(15)]
        [MinLength(1)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Es necesario un apellido.")]
        [MaxLength(15)]
        [MinLength(1)]
        public string Apellido { get; set; }
        [MinLength(8,ErrorMessage = "El número de celular debe tener 8 dígitos.")]
        [MaxLength(8, ErrorMessage = "El número de celular debe tener 8 dígitos.")]
        public int Telefono { get; set; }
        [MaxLength(500, ErrorMessage = "La descripción no puede ser muy larga.")]
        public string Descripcion { get; set; }

        public static void Guardar(ClienteModel nuevoCliente)
        {
            ClienteData.Instancia.ListaCliente.Add(nuevoCliente);
        }

        public static bool Editar(int id, ClienteModel nuevoCliente)
        {

            return true;
        }
    }
}
