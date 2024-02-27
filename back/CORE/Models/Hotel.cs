using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBackend.CORE.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }

        [StringLength(30, ErrorMessage = "Longitud máxima para el nombre 30")]
        public required string Nombre { get; set; }

        [StringLength(50, ErrorMessage = "Longitud máxima para el nombre 50")]
        public required string Direccion { get; set; }
                
        public required bool Habilitado { get; set; }

        [StringLength(30, ErrorMessage = "Longitud máxima para el nombre 30")]
        public required string Ciudad { get; set; }

        public ICollection<Habitacion>? Habitacion { get; set; }
    }
}
