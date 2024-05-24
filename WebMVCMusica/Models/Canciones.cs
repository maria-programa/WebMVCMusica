﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebMVCMusica.Models;

public partial class Canciones
{
    public int Id { get; set; }

    public string? Titulo { get; set; }

    public TimeOnly? Duracion { get; set; }

    public int? AlbumesId { get; set; }

    public bool Single { get; set; }

    public virtual Albumes? Albumes { get; set; }

    public virtual ICollection<VideoClips> VideoClips { get; set; } = new List<VideoClips>();
}
