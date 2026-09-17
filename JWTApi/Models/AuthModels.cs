namespace JWTApi.Models;

public record RegisterRequest(
    string FirstName, 
    string LastName, 
    string Email, 
    string Password);

public record LoginRequest(
    string Email, 
    string Password);

public record AddRoleRequest(
    string Email, 
    string Role);

public record AuthResponse(
    string UserId,
    string Email,
    IEnumerable<string> Roles,
    string Token,
    DateTime ExpiresAt);