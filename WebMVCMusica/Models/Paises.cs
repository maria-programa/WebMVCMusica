using System;
using System.Collections.Generic;

namespace WebMVCMusica.Models;

public partial class Paises
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Ciudades> Ciudades { get; set; } = new List<Ciudades>();
}
