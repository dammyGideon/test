using saltGenerator = BCrypt.Net.BCrypt;

namespace Herbzhub.Infrastructure.Helper
{
   
        public static class PasswordHandler
        {
            public static string EncryptPassword(string password)
            {
                string salt = saltGenerator.GenerateSalt();
                string hashPassword = saltGenerator.HashPassword(password, salt);
                return hashPassword;

            }

            public static bool VerifyPassword(string password, string hashPassword)
            {
                try
                {
                    bool checkPassword = saltGenerator.Verify(password, hashPassword);
                    return checkPassword;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    
}
