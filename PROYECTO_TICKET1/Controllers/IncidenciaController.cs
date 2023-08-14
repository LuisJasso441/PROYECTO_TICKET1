using Microsoft.AspNetCore.Mvc;
using PROYECTO_TICKET1.Models;
using PROYECTO_TICKET1.Servicios.Contrato;

namespace PROYECTO_TICKET1.Controllers
{
    public class IncidenciaController : Controller
    {
        private readonly IUTicketService _ticketService;

        public IncidenciaController(IUTicketService ticketServicio)
        {
            _ticketService = ticketServicio;
        }
        public IActionResult CrearTicket()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CrearTicket(Ticket modelo)
        {
            Ticket ticket_creado = await _ticketService.SaveTicket(modelo);

            if (ticket_creado.Id > 0)
                return RedirectToAction("IniciarSesion", "Inicio");
            ViewData["Mensaje"] = "No se pudo crear el ticket";
            return View();
        }
    }
}