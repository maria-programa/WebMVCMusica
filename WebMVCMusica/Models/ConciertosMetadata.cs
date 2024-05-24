using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace WebMVCMusica.Models
{
    [ModelMetadataType(typeof(ConciertosMetadata))]
    public partial class Conciertos { }

    public class ConciertosMetadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage =("Es necesario introducir el nombre de la gira"))]
        [DisplayName("Gira")]
        public int? GirasId { get; set; }

        [DataType(DataType.Date)]
        public DateOnly? Fecha { get; set; }

        [DisplayName("Ciudad")]
        public int? CiudadesId { get; set; }

        public string? Direccion { get; set; }

        [DisplayName("Ciudad")]
        public virtual Ciudades? Ciudades { get; set; }

        [DisplayName("Gira")]
        public virtual Giras? Giras { get; set; }
    }
}
