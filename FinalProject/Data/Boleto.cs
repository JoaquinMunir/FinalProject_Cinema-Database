using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Data
{
    public class Boleto
    {
        [Key]
        public int Id { get; set; }

        public int IdFuncion { get; set; }

        [Required(ErrorMessage = "El campo 'Asiento' es obligatorio.")]
        public int Asiento { get; set; }

        [Required(ErrorMessage = "El campo 'Precio' es obligatorio.")]
        [Column(TypeName = "decimal(6,2)")]
        [Range(0.01, 9999.99, ErrorMessage = "El precio debe ser mayor a 0.")]
        public decimal Precio { get; set; }

        [ForeignKey("IdFuncion")]
        public virtual Funcion? Funcion { get; set; }
    }
}
