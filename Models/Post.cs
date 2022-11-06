using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace CheeseApp.Models
{
    public class Post
    {

        public int ID { get; set; }

        [Required]
        [Display(Name = "Fecha de publicación")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        // Initialize Date


        [Required]
        [
            StringLength(
                100,
                ErrorMessage = "Descripción no puede estar vacía",
                MinimumLength = 2)
        ]
        public string Descripcion { get; set; }

        public string? ImagenUrl { get; set; }
        // Image type
        [Display(Name = "Subir una imagen ")]
        [NotMapped]
        public IFormFile? ImagenFile { get; set; }

    }
}
