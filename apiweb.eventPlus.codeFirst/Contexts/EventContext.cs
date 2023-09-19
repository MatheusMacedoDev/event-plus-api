using apiweb.eventPlus.codeFirst.Domains;
using Microsoft.EntityFrameworkCore;

namespace apiweb.eventPlus.codeFirst.Contexts
{
    public class EventContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<EventComment> EventComments { get; set; }
        public DbSet<EventPresence> EventPresences { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server = NOTE17-S14; Database = event_plus_auto; User Id = sa; Pwd = Senai@134; TrustServerCertificate = True");
    }
}
