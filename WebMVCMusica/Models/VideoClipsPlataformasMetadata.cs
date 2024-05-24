using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebMVCMusica.Models
{
    [ModelMetadataType(typeof(VideoClipsPlataformasMetadata))]
    public partial class VideoClipsPlataformas { }
    public class VideoClipsPlataformasMetadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Obligatorio")]
        [DisplayName("Plataforma")]
        public int? PlataformasId { get; set; }

        [DisplayName("Videoclip")]
        public int? VideoClipsId { get; set; }

        [Required(ErrorMessage = "Obligatorio")]
        [DisplayName("URL")]
        public string? url { get; set; }

        [DisplayName("Plataforma")]
        public virtual Plataformas? Plataformas { get; set; }

        [DisplayName("Videoclip")]
        public virtual VideoClips? VideoClips { get; set; }
    }
}
