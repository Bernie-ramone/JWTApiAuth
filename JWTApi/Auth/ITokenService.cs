using JWTApi.Entities;

namespace JWTApi.Auth;

public interface ITokenService
{
   (string Token, DateTime ExpiresAt) CreateToken(ApplicationUser user, IEnumerable<string> roles);
}