using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Services.Interfaces;

public interface ITokenService
{
    string CreateToken(ApplicationUser applicationUser);
}