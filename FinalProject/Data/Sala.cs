using System.ComponentModel.DataAnnotations;

namespace FinalProject.Data
{
    public enum Tipo
    {
        [Display(Name = "Estándar")]
        Estandar,
        
        [Display(Name = "Infantil")]
        Infantil,

        [Display(Name = "VIP")]
        VIP,
        
        [Display(Name = "4DX")]
        CuatroDX,
        
        [Display(Name = "IMAX")]
        IMAX
    }
    public class Sala
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo 'Número de Sala' es obligatorio.")]
        [Range(1, 12, ErrorMessage = "El número de sala debe estar entre 1 y 12.")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "El campo 'Capacidad' es obligatorio.")]
        public int Capacidad { get; set; }

        [Required(ErrorMessage = "El campo 'Tipo de Sala' es obligatorio.")]
        public Tipo Tipo { get; set; }
    }
}
