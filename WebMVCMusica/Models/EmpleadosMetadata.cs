using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebMVCMusica.Models
{
    [ModelMetadataType(typeof(EmpleadosMetadata))]
    public partial class Empleados { }

    public class EmpleadosMetadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Es necesario que introduzca su nombre")]
        [DisplayName("Nombre Completo")]
        public string? NombreCompleto { get; set; }

        [DisplayName("Puesto")]
        public int? RolesId { get; set; }

        [DisplayName("Puesto")]
        public virtual Roles? Roles { get; set; }
    }
}
