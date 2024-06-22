using System.ComponentModel.DataAnnotations;

namespace LOGIN.Dtos.RolDTOs
{
    public class CreateRoleDto
    {
        [Required]
        public string RoleName { get; set; }

    }
}
