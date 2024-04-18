///using OTP_APP.Domain;

using OTP_APP.Domain;

namespace OTP_APP.Service
{
    public interface IUserRegisterService
    {
        Task<RegisterUser> GetUserByEmailAsync(string email);
        Task AddUserAsync(RegisterUser userRegister);
    }
}
