using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab00_118182.Models
{
    public class ClienteModel
    {
        [MaxLength(15)]
        [MinLength(1)]
        public string Nombre { get; set; }
        [MaxLength(15)]
        [MinLength(1)]
        public string Apellido { get; set; }
        [Range(1,8)]
        public int Telefono { get; set; }
        [MaxLength(500)]
        public string Descripcion { get; set; }
    }
}
