using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebMVCMusica.Models
{
    [ModelMetadataType(typeof(GirasMetadata))]
    public partial class Giras { }

    public class GirasMetadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage =("Es necesario introducir el nombre de la gira"))]
        [DisplayName("Nombre de la gira")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage =("Es necesario indicar el grupo al que pertenece la gira"))]
        [DisplayName("Grupo")]
        public int? GruposId { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Fecha de inicio de la gira")]
        public DateOnly? FechaInicio { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Fecha de fin de la gira")]
        public DateOnly? FechaFin { get; set; }

        [DisplayName("Grupo")]
        public virtual Grupos? Grupos { get; set; }
    }
}
