using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.ComponentModel;

namespace Zasylogic_Prueba.Models
{
    public class Formulario
    {
        [Key]
        public int FormularioId { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string? Celular { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public string Motivo { get; set; }
        [DisplayName("Fecha")]
        public DateTime FechaAlta { get; set; }
        

    }
}
