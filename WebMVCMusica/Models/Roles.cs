using System;
using System.Collections.Generic;

namespace WebMVCMusica.Models;

public partial class Roles
{
    public int Id { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Empleados> Empleados { get; set; } = new List<Empleados>();
}
