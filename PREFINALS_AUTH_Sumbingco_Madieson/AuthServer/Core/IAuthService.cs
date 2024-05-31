using AuthServer.Core;

public interface IAuthService
{
    string GenerateToken(User user);
    // Add other methods if necessary
}