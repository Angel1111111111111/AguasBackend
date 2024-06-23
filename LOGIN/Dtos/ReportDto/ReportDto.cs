using LOGIN.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace LOGIN.Dtos.ReportDto
{
    public class ReportDto
    {

        public Guid Id { get; set; }

        public string Key { get; set; }

        public string Name { get; set; }

        public string DNI { get; set; }

        public string Cellphone { get; set; }

        public DateTime Date { get; set; }

        public string Report { get; set; }

        public string Direction { get; set; }

        public string Observation { get; set; }

        public string Photo { get; set; }

        public string State_Id { get; set; }

        [ForeignKey(nameof(State_Id))]
        public virtual StateEntity State { get; set; }

    }
}
