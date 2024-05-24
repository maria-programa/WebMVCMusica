﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebMVCMusica.Models;

public partial class Empleados
{
    public int Id { get; set; }

    public string? NombreCompleto { get; set; }

    public int? RolesId { get; set; }

    public virtual Roles? Roles { get; set; }
}
