using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebMVCMusica.Models
{
    [ModelMetadataType(typeof(RolesMetadata))]
    public partial class Roles { }
    public class RolesMetadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Obligatorio")]
        [DisplayName("Puesto de trabajo")]
        public string? Descripcion { get; set; }
    }
}
