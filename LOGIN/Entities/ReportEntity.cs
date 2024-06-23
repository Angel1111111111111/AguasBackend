using System.ComponentModel.DataAnnotations.Schema;

namespace LOGIN.Entities
{
    [Table("report", Schema = "reports")]
    public class ReportEntity
    {

        public Guid Id { get; set; }

        [Column("state_id")]
        public Guid StateId { get; set; }

        [ForeignKey(nameof(StateId))]
        public virtual StateEntity State { get; set; }

        public string Key { get; set; }

        public string Name { get; set; }

        public string DNI { get; set; }

        public string Cellphone { get; set; }

        public DateTime Date { get; set; }

        public string Report {  get; set; }

        public string Direction { get; set; }

        public string Observation { get; set; }

        public string Photo { get; set; }
        
    }
}
