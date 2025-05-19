using System.ComponentModel.DataAnnotations;

namespace FinalProject.Data
{
    public enum Clasificacion
    {
        [Display(Name = "AA")]
        AA,    

        [Display(Name = "A")]
        A,     

        [Display(Name = "B")]
        B,     

        [Display(Name = "B15")]
        B15,   

        [Display(Name = "C")]
        C,

        [Display(Name = "D")]
        D
    }

    public class Pelicula
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo 'Título' es obligatorio.")]
        [StringLength(100, ErrorMessage = "El campo 'Titulo' no puede exceder los 100 caracteres.")]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "El campo 'Duración' es obligatorio.")]
        [Range(typeof(TimeSpan), "00:00:01", "23:59:59",
            ErrorMessage = "La duración debe estar entre 1 segundo y 24 horas.")]
        public TimeSpan? Duracion { get; set; }

        [Required(ErrorMessage = "El campo 'Clasificación' es obligatorio.")]
        public Clasificacion? Clasificacion { get; set; }

        [Required(ErrorMessage = "El campo 'Género' es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo 'Género' no puede exceder los 50 caracteres.")]
        public string? Genero { get; set; }
    }
}
