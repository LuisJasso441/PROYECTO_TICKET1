using Microsoft.EntityFrameworkCore;
using PROYECTO_TICKET1.Models;

namespace PROYECTO_TICKET1.Servicios.Contrato
{
    public interface IUTicketService
    {
        Task<Ticket> SaveTicket(Ticket modelo);
    }
}