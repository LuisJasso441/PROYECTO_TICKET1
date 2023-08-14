using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PROYECTO_TICKET1.Models;
using PROYECTO_TICKET1.Servicios.Contrato;

namespace PROYECTO_TICKET1.Servicios.Implementacion
{
    public class TicketService : IUTicketService
    {
        private readonly DbpruebaContext _dbContext;

        public TicketService(DbpruebaContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Ticket> SaveTicket(Ticket modelo)
        {
            _dbContext.Tickets.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return modelo;
        }
    }
}