using System.ComponentModel.DataAnnotations;

namespace PizzaPlace.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El nombre debe contener solo letras.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Calle { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "La ciudad debe contener solo letras.")]
        public string? Ciudad { get; set; }
    }

}
