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
        public String? FechaPost { get; set; }

        [Required]
        [
            StringLength(
                100,
                ErrorMessage = "Descripción no puede estar vacía",
                MinimumLength = 2)
        ]
        public string? Descripcion { get; set; }

        public string ImagenUrl { get; set; }
        // Image type
        [Required]
        [Display(Name = "Subir una imagen ")]
        [NotMapped]
        public IFormFile ImagenFile { get; set; }

    }
}
