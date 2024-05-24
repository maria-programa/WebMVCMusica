﻿using System;
using System.Collections.Generic;

namespace WebMVCMusica.Models;

public partial class FuncionesArtistas
{
    public int Id { get; set; }

    public int? FuncionesId { get; set; }

    public int? ArtistasId { get; set; }

    public virtual Artistas? Artistas { get; set; }

    public virtual Funciones? Funciones { get; set; }
}
