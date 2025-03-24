using Logic.Models;

namespace Logic.Interfaces
{
    public interface IAuthService
    {
        Task<(int, string)> Registration(RegistrationRequestModel model, string role);
        Task<(int, string)> Login(LoginRequestModel model);
    }
}