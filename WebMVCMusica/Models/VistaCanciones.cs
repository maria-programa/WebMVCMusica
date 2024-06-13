using System;
using System.Collections.Generic;

namespace WebMVCMusica.Models;

public partial class VistaCanciones
{
    public int Id { get; set; }

    public string? Titulo { get; set; }

    public TimeOnly? Duracion { get; set; }

    public string? Álbum { get; set; }

    public string? Grupo { get; set; }
}
