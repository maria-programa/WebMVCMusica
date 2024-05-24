using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebMVCMusica.Models
{
    [ModelMetadataType(typeof(FuncionesArtistasMetadata))]
    public partial class FuncionesArtistas { }

    public class FuncionesArtistasMetadata
    {
        public int Id { get; set; }

        [DisplayName("Funcion")]
        public int? FuncionesId { get; set; }

        [DisplayName("Artista")]
        public int? ArtistasId { get; set; }

        [DisplayName("Artista")]
        public virtual Artistas? Artistas { get; set; }

        [DisplayName("Funcion")]
        public virtual Funciones? Funciones { get; set; }
    }
}
