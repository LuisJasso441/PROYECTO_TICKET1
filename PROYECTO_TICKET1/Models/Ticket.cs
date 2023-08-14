using System;
using System.Collections.Generic;

namespace PROYECTO_TICKET1.Models;

public partial class Ticket
{
    public int Id { get; set; }

    public int? IdUsuario { get; set; }

    public string? Asunto { get; set; }

    public string? Descripcion { get; set; }

    public string? Estatus { get; set; }

    public string? Sistema { get; set; }

    public string? Version { get; set; }

    public byte[]? Imagen { get; set; }
}
