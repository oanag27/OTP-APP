using Microsoft.EntityFrameworkCore;
using OTP_APP.Domain;
//using OTP_APP.Domain;

namespace OTP_APP.Repository
{
    public class UserRegisterRepository:IUserRegisterRepository
    {
        private readonly AppDbContext appDbContext;
        private readonly DbSet<RegisterUser> registerUsers;
        public UserRegisterRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
            registerUsers = appDbContext.Set<RegisterUser>();
        }

        public async Task AddUserAsync(RegisterUser userRegister)
        {
            await registerUsers.AddAsync(userRegister);
            await appDbContext.SaveChangesAsync();
        }
        public async Task<RegisterUser> GetUserByEmail(string email)
        {
            var user = await appDbContext.Set<RegisterUser>().FirstOrDefaultAsync(x => x.Email == email);
            return user;
        }

    }
}
