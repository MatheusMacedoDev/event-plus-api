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
            try
            {
                User findedUser = _context.Users
                    .Select(user => new User
                    {
                        Id = user.Id,
                        UserName = user.UserName,
                        Email = user.Email,
                        Password = user.Password,
                        UserType = new UserType
                        {
                            TypeName = user.UserType!.TypeName
                        }
                    }).FirstOrDefault(user => user.Email == email)!;

                if (findedUser != null)
                {
                    if (Cryptography.IsEqualHashes(password, findedUser.Password!))
                    {
                        return findedUser;
                    }
                }

                return null!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public User GetById(Guid id)
        {
            try
            {
                User user = _context.Users
                    .Select(user => new User
                    {
                        Id = user.Id,
                        UserName = user.UserName,
                        UserType = new UserType
                        {
                            TypeName = user.UserType!.TypeName
                        }
                    }).FirstOrDefault(user => user.Id == id)!;

                return user;
            }
            catch (Exception)
            {
                throw;
            }
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
