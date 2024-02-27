using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBackend.CORE.Models
{
    public class Huesped
    {
        public int HuespedId { get; set; }

        [StringLength(30, ErrorMessage = "Longitud máxima para el nombre 30")]
        public required string Nombres { get; set; }

        [StringLength(30, ErrorMessage = "Longitud máxima para el nombre 30")]
        public required string Apellidos { get; set; }

        [StringLength(9, ErrorMessage = "Longitud máxima para el nombre 9")]
        public required string Genero { get; set; }

        [StringLength(25, ErrorMessage = "Longitud máxima para el nombre 25")]
        public required string TipoDeDocumento { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Debe ser un número entero entre 1 y 2 147 483 647")]
        public required int NumeroDeDocumento { get; set; }

        [StringLength(50, ErrorMessage = "Longitud máxima para el nombre 50")]
        public required string Email { get; set; }

        [DataType(DataType.Date)]
        public required DateTime FechaDeNacimiento { get; set; }

        public int IdCliente { get; set; }
        public Cliente? Cliente { get; set; }
    }
}
