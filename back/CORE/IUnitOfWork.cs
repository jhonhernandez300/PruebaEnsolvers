using SmartBackend.CORE.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartBackend.CORE.Models;

namespace SmartBackend.CORE
{
    public interface IUnitOfWork : IDisposable
    {
        //IBaseRepository<Cliente> Clientes { get; }
        INoteRepository Clientes { get; }
        IContactoDeEmergenciaRepository ContactoDeEmergencia { get; }
        IHabitacionRepository Habitacion { get; }
        IHotelRepository Hotel { get; }
        IHuespedRepository Huesped { get; }
        IReservaRepository Reserva { get; }

        int Complete();
    }
}
