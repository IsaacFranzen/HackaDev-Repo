using BC = BCrypt.Net.BCrypt;

namespace TECBank.Backend.Services;

public static class PasswordService
{
    private const int workFactor = 12;

    public static string Hash(string password)
    {
        var hash = BC.HashPassword(password, workFactor);
        return hash;
    }

    public static bool Verify(string password, string hash)
    {
        if (password == "" || hash == "") return false;
        
        var validationResult = BC.Verify(password, hash);
        return validationResult;
    }

    public static bool CheckIfMatch(
        string password, string passwordConfirmation)
    {
        return string.Equals(password, passwordConfirmation);
    }
}
