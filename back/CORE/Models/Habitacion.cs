using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBackend.CORE.Models
{
    public class Habitacion
    {
        public int HabitacionId { get; set; }

        [Range(1, 10000, ErrorMessage = "Debe ser un número entero entre 1 y 10 000")]
        public required int Numero { get; set; }


        public required decimal CostoBase { get; set; }


        public required decimal Impuesto { get; set; }

        [StringLength(16, ErrorMessage = "Longitud máxima para el nombre 16")]
        public required string Tipo { get; set; }

        [StringLength(16, ErrorMessage = "Longitud máxima para el nombre 16")]
        public required string Ubicacion { get; set; }

        public required bool Habilitado { get; set; }

        public int IdReserva { get; set; }
        public Reserva? Reserva { get; set; }

        public int IdHotel { get; set; }
        public Hotel? Hotel { get; set; }
    }
}
