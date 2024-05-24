using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebMVCMusica.Models
{
    [ModelMetadataType(typeof(FuncionesMetadata))]
    public partial class Funciones { }

    public class FuncionesMetadata
    {
        public int Id { get; set; }

        [DisplayName("Funcion")]
        public string? Nombre { get; set; }
    }
}
