using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebMVCMusica.Models
{
    [ModelMetadataType(typeof(RepresentantesMetadata))]
    public partial class Representantes { }
    public class RepresentantesMetadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Es necesario introducir su nombre completo")]
        [DisplayName("Nombre Completo")]
        public string? NombreCompleto { get; set; }

        [DataType(DataType.Date)]
        public DateOnly? FechaNacimiento { get; set; }

        [DisplayName("Identificacion")]
        public string? Identificacion { get; set; }

        [DataType(DataType.EmailAddress)]
        [DisplayName("Email")]
        public string? mail { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string? Telefono { get; set; }

        [DisplayName("Ciudad")]
        public int? CiudadesID { get; set; }

        [DisplayName("Ciudad")]
        public virtual Ciudades? Ciudades { get; set; }

    }
}
