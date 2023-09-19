using apiweb.eventPlus.codeFirst.Contexts;
using apiweb.eventPlus.codeFirst.Domains;
using apiweb.eventPlus.codeFirst.Interfaces;

namespace apiweb.eventPlus.codeFirst.Repositories
{
    public class UserTypesRepository : IUserTypeRepository
    {
        private readonly EventContext _context;

        public UserTypesRepository()
        {
            _context= new EventContext();
        }

        public void Create(UserType userType)
        {
            _context.UserTypes.Add(userType);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            UserType findedUserType = GetById(id);

            if (findedUserType != null)
            {
                _context.Remove(findedUserType);
                _context.SaveChanges();
            }
        }

        public UserType GetById(Guid id)
        {
            return _context.UserTypes.FirstOrDefault(userType => userType.Id == id)!;
        }

        public List<UserType> ListAll()
        {
            return _context.UserTypes.ToList();
        }

        public void Update(UserType userType)
        {
            throw new NotImplementedException();
        }
    }
}
