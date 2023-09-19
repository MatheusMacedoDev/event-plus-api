using apiweb.eventPlus.codeFirst.Contexts;
using apiweb.eventPlus.codeFirst.Domains;
using apiweb.eventPlus.codeFirst.Interfaces;
using apiweb.eventPlus.codeFirst.Utils;

namespace apiweb.eventPlus.codeFirst.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly EventContext _context;

        public UserRepository()
        {
            _context = new EventContext();
        }

        public User GetByEmailAndPassword(string email, string password)
        {
            throw new NotImplementedException();
        }

        public User GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Register(User user)
        {
            try
            {
                user.Password = Cryptography.GetHashByPassword(user.Password!);

                _context.Users.Add(user);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
