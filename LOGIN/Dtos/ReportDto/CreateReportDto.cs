using System.ComponentModel.DataAnnotations;

namespace LOGIN.Dtos.ReportDto
{
    public class CreateReportDto
    {
        [Display(Name = "Clave Catastral")]
        [Required(ErrorMessage = "La {0} es Requerida")]
        public string Key { get; set; }

        [Display(Name = "Nombre del Abonado")]
        [Required(ErrorMessage = "El {0} es Requerido")]
        public string Name { get; set; }

        [Display(Name = "Identidad")]
        [Required(ErrorMessage = "La {0} es Requerida")]
        public string DNI { get; set; }

        [Display(Name = "Telefono Celular")]
        [Required(ErrorMessage = "El {0} es Requerido")]
        public string Cellphone { get; set; }

        [Display(Name = "Fecha")]
        [Required(ErrorMessage = "La {0} es Requerida")]
        public DateTime Date { get; set; }

        [Display(Name = "Reporte")]
        [Required(ErrorMessage = "El {0} es Requerido")]
        public string Report { get; set; }

        [Display(Name = "Direccion Exacta")]
        [Required(ErrorMessage = "La {0} es Requerida")]
        public string Direction { get; set; }

        [Display(Name = "Observacion")]
        [Required(ErrorMessage = "La {0} es Requerida")]
        public string Observation { get; set; }
            
        [Display(Name = "Foto")]
        [Required(ErrorMessage = "La {0} es Requerida")]
        public string Photo { get; set; }

    }
}
