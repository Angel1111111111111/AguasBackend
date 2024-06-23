using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LOGIN.Dtos.Communicates
{
    public class CreateCommunicateDto
    {
        [Display(Name = "Título")]
        [Required(ErrorMessage = "El {0} es Requerido")]
        public string Tittle { get; set; }

        [Display(Name = "Fecha")]
        [Required(ErrorMessage = "La {0} es Requerido")]
        public DateTime Date { get; set; }

        [Display(Name = "Tipo de Comunicado")]
        [Required(ErrorMessage = "El {0} es Requerido")]
        public string Type_Statement { get; set; }

        [Display(Name = "Contenido")]
        [Required(ErrorMessage = "El {0} es Requerido")]
        public string Content { get; set; }

    }
}
