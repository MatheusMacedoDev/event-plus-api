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
            throw new NotImplementedException();
        }

        public UserType GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<UserType> ListAll()
        {
            throw new NotImplementedException();
        }

        public void Update(UserType userType)
        {
            throw new NotImplementedException();
        }
    }
}
