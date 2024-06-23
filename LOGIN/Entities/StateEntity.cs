
using System.ComponentModel.DataAnnotations.Schema;

namespace LOGIN.Entities
{

    [Table("state", Schema ="reports")]
    public class StateEntity
    {

        public Guid Id { get; set; }

        public string Name { get; set; }

    }
}
