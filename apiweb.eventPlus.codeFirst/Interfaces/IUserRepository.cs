using apiweb.eventPlus.codeFirst.Domains;

namespace apiweb.eventPlus.codeFirst.Interfaces
{
    public interface IUserRepository
    {
        void Register(User user);
        User GetById(Guid id);
        User GetByEmailAndPassword(string email, string password);
    }
}
