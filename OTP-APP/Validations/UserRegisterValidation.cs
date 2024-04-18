namespace OTP_APP.Validations
{
    public class UserRegisterValidation
    {
        public static bool IsValidEmail(string email)
        {
            return email.Length >= 5 && email.Contains("@") && email.Contains(".");
        }

        public static bool IsValidUsername(string username)
        {
            return username.Length >= 5;
        }
    }
}
