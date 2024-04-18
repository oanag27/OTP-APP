using Microsoft.AspNetCore.Mvc;

namespace OTP_APP.Controllers.OTP
{
    public class OtpController : Controller
    {
        [HttpGet("api/GenerateOTPPassword")]
        public IActionResult GenerateOTPPassword()
        {
            string otpPassword = GenerateOTP();
            return Ok(new { otpPassword });
        }

        private string GenerateOTP()
        {
                string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                string digits = "0123456789";
                string special_characters = "!@#%^$&*~|<>?/()[]{}+=_";

                string charactersString=letters;
                charactersString += digits + special_characters;
                int length = 32;
                string otp = string.Empty;
                for (int i = 0; i < length; i++)
                {
                    string character = string.Empty;
                    do
                    {
                        int index = new Random().Next(0, charactersString.Length);
                        character = charactersString.ToCharArray()[index].ToString();
                    } while (otp.IndexOf(character) != -1);

                    otp += character;
                }
                return otp;
        }
            
    }
}

