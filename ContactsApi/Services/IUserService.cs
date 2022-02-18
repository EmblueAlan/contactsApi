using ContactsApi.Entities;
using ContactsApi.Models.Authentication;

namespace ContactsApi.Services
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
