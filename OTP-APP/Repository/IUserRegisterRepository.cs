using OTP_APP.Domain;

namespace OTP_APP.Repository
{
    public interface IUserRegisterRepository
    {
        Task AddUserAsync(RegisterUser userRegister);
        Task<RegisterUser> GetUserByEmail(string email);
    }
}
