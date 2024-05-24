using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebMVCMusica.Models
{
    [ModelMetadataType(typeof(VideoClipsMetadata))]
    public partial class VideoClips { }
    public class VideoClipsMetadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Es necesario introducir el nombre de la canción")]
        [DisplayName("Cancion")]
        public int? CancionesId { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Fecha de estreno")]
        public DateOnly? Fecha { get; set; }

        [DisplayName("Cancion")]
        public virtual Canciones? Canciones { get; set; }
    }
}
