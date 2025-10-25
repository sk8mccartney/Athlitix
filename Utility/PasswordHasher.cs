namespace Athlitix.Utility;

using System;
using System.Security.Cryptography;
using System.Text;

public static class PasswordHasher
{
    public static string HashPassword(string password, string salt)
    {
        // Convert strings to byte arrays
        var saltBytes = Encoding.UTF8.GetBytes(salt);
        var passwordBytes = Encoding.UTF8.GetBytes(password);

        // Use PBKDF2 (Rfc2898DeriveBytes)
        using var pbkdf2 = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 100000, HashAlgorithmName.SHA256);
        var hash = pbkdf2.GetBytes(32); // 32 bytes = 256-bit hash

        // Return as Base64 string
        return Convert.ToBase64String(hash);
    }
}
