using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public enum Formato
    {
        [Display(Name = "2D")]
        DosD,

        [Display(Name = "3D")]
        TresD,

        [Display(Name = "4DX")]
        CuatroDX,

        [Display(Name = "IMAX")]
        IMAX
    }

    public class Funcion : IValidatableObject
    {
        [Key]
        public int Id { get; set; }

        public int IdPelicula { get; set; }

        public int IdSala { get; set; }

        [Required(ErrorMessage = "El campo 'Fecha' es obligatorio.")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El campo 'Horario' es obligatorio.")]
        [DataType(DataType.Time)]
        [Range(typeof(TimeSpan), "11:00:00", "23:30:00",
            ErrorMessage = "El horario debe estar entre 11:00 AM y 11:30 PM")]
        public TimeSpan Horario { get; set; }

        [Required(ErrorMessage = "El campo 'Formato' es obligatorio.")]
        public Formato Formato { get; set; }

        [ForeignKey("IdPelicula")]
        public virtual Pelicula? Pelicula { get; set; }

        [ForeignKey("IdSala")]
        public virtual Sala? Sala { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var dbContext = (FinalProjectDbContext)validationContext.GetService(typeof(FinalProjectDbContext));

            if (dbContext == null)
            {
                yield break;
            }

            bool existeConflicto = dbContext.Funciones.Any(f =>
                f.IdSala == this.IdSala &&
                f.Fecha == this.Fecha &&
                f.Horario == this.Horario &&
                f.Id != this.Id
            );

            if (existeConflicto)
            {
                yield return new ValidationResult(
                    "Ya existe una función programada en esta sala, fecha y horario.",
                    new[] { nameof(IdSala), nameof(Fecha), nameof(Horario) });
            }
        }
    }
}
