using OTP_APP.Domain;
using OTP_APP.Repository;

namespace OTP_APP.Service
{
    public class UserRegisterService:IUserRegisterService
    {
        private readonly IUserRegisterRepository _userRegisterRepository;

        public UserRegisterService(IUserRegisterRepository userRegisterRepository)
        {
            _userRegisterRepository = userRegisterRepository;
        }

        public async Task<RegisterUser> GetUserByEmailAsync(string email)
        {
            return await _userRegisterRepository.GetUserByEmail(email);
        }

        public async Task AddUserAsync(RegisterUser userRegister)
        {
            await _userRegisterRepository.AddUserAsync(userRegister);
        }
    }
}
