using System.ComponentModel.DataAnnotations;

public class ConfirmEmailDto
{
    [Required]
    public string UserId { get; set; }

    [Required]
    public string Token { get; set; }
}
