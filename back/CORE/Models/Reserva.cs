using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBackend.CORE.Models
{
    public class Reserva
    {
        public int ReservaId { get; set; }

        [DataType(DataType.Date)]
        public required DateTime FechaInicio { get; set; }

        [DataType(DataType.Date)]
        public required DateTime FechaSalida { get; set; }

        [Range(1, 100, ErrorMessage = "Debe ser un número entero entre 1 y 100")]
        public required int CantidadDePersonas { get; set; }

        public int IdCliente { get; set; }
        public Cliente? Cliente { get; set; }

        public ICollection<Habitacion>? Habitacion { get; set; }
    }
}
