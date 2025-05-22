using System.ComponentModel.DataAnnotations;

namespace odontoprev_api_cs.DTOs.Register;

public class RegisterDTO
{
    [Required] public string? Username { get; set; }

    [Required] [EmailAddress] public string? Email { get; set; }

    [Required] public string? Password { get; set; }
}