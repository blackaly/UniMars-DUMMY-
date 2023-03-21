using UniMars.Models;

namespace UniMars.Services.Interfaces
{
    public interface IAuthService
    {
        Task<AuthModel> Register(RegisterationModel model);
        Task<AuthModel> Login(LoginModel model);
    }
}
