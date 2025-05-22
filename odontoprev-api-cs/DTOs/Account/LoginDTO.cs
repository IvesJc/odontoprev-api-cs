using System.ComponentModel.DataAnnotations;

namespace odontoprev_api_cs.DTOs.Register;

public class LoginDTO
{
    [Required] public string Username { get; set; }
    
    [Required] public string Password { get; set; }
}