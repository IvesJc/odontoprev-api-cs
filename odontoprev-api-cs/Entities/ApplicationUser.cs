using Microsoft.AspNetCore.Identity;

namespace odontoprev_api_cs.Entities;

public class ApplicationUser : IdentityUser
{
    public int? BeneficiarioId { get; set; }
    public Beneficiario Beneficiario { get; set; }
}