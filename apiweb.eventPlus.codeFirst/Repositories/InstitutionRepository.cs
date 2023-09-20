using apiweb.eventPlus.codeFirst.Contexts;
using apiweb.eventPlus.codeFirst.Domains;
using apiweb.eventPlus.codeFirst.Interfaces;

namespace apiweb.eventPlus.codeFirst.Repositories
{
    public class InstitutionRepository : IInstitutionRepository
    {
        private readonly EventContext _context;

        public InstitutionRepository()
        {
            _context = new EventContext();
        }

        public void Create(Institution institution)
        {
            _context.Add(institution);
            _context.SaveChanges();
        }
    }
}
