using Microsoft.EntityFrameworkCore;
using PROYECTO_TICKET1.Models;

namespace PROYECTO_TICKET1.Servicios.Contrato
{
    public interface IUsuarioService
    {
        Task<Usuario> GetUsuario(string correo, string clave);
        Task<Usuario> SaveUsuario(Usuario modelo);
    }
}