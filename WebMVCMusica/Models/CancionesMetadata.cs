using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Model;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace WebMVCMusica.Models
{
    [ModelMetadataType(typeof(CancionesMetadata))]
    public partial class Canciones { }

    public class CancionesMetadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Es necesario el titulo")]
        public string? Titulo { get; set; }

        [DataType(DataType.Time)]
        public TimeOnly? Duracion { get; set; }

        [DisplayName("Album")]
        public int? AlbumesId { get; set; }

        public bool Single { get; set; }

        [DisplayName("Album")]
        public virtual Albumes? Albumes { get; set; }
    }
}
