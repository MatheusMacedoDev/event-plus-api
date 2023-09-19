using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiweb.eventPlus.codeFirst.Domains
{
    [Table("EventPresences")]
    public class EventPresence
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column(TypeName = "BIT")]
        [Required(ErrorMessage = "O estado da presença é obrigatório")]
        public bool PresenceConfirmed { get; set; }

        // User Reference

        [Required(ErrorMessage = "O usuário da presença tem que ser definido")]
        public Guid UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User? User { get; set; }

        // Event Reference

        [Required(ErrorMessage = "O evento precisa ser definido")]
        public Guid EventId { get; set; }

        [ForeignKey(nameof(EventId))]
        public Event? Event { get; set; }
    }
}
