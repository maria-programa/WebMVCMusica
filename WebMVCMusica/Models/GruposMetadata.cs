using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebMVCMusica.Models
{
    [ModelMetadataType(typeof(GruposMetadata))]
    public partial class Grupos { }
    public class GruposMetadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Es necesario introducir el nombre del grupo")]
        [StringLength(200)]
        public string? Nombre { get; set; }

        [DisplayName("Grupo")]
        public bool grupo { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Fecha de creación")]
        public DateOnly? FechaCreacion { get; set; }

        [DisplayName("Ciudad")]
        public int? CiudadesId { get; set; }

        [DisplayName("Representante")]
        public int? RepresentantesId { get; set; }

        [DisplayName("Genero")]
        public int? GenerosId { get; set; }

        [DisplayName("Ciudad")]
        public virtual Ciudades? Ciudades { get; set; }

        [DisplayName("Genero")]
        public virtual Generos? Generos { get; set; }

        [DisplayName("Representante")]
        public virtual Representantes? Representantes { get; set; }
    }
}
