using apiweb.eventPlus.codeFirst.Domains;

namespace apiweb.eventPlus.codeFirst.Interfaces
{
    public interface IUserTypeRepository
    {
        void Create(UserType userType);
        List<UserType> ListAll();
        UserType GetById(Guid id);
        void Update (UserType userType);
        void Delete(Guid id);
    }
}
