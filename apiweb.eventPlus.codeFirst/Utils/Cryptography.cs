namespace apiweb.eventPlus.codeFirst.Utils
{
    public static class Cryptography
    {
        public static string GetHashByPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool IsEqualHashes(string password, string databasePasswordHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, databasePasswordHash);
        }
    }
}
