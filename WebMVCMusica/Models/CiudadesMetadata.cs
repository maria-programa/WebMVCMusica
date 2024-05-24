using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebMVCMusica.Models
{
    [ModelMetadataType(typeof(CiudadesMetadata))]
    public partial class Ciudades { }

    public class CiudadesMetadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Es necesario introducir un nombre")]
        public string? Nombre { get; set; }

        [DisplayName("Pais")]
        public int? PaisesID { get; set; }

        [DisplayName("Pais")]
        public virtual Paises? Paises { get; set; }

    }
}
