using System;
using System.Collections.Generic;

namespace WebMVCMusica.Models;

public partial class VistaGiras
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public DateOnly? FechaInicio { get; set; }

    public DateOnly? FechaFin { get; set; }

    public string? Expr1 { get; set; }
}
