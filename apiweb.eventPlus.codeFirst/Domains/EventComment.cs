using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiweb.eventPlus.codeFirst.Domains
{
    [Table("EventComments")]
    public class EventComment
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "O comentário do evento deve conter um texto")]
        public string? Description { get; set; }

        [Column(TypeName = "BIT")]
        public bool ShouldShow { get; set; } = false;

        // User Reference

        [Required(ErrorMessage = "O usuário do comentário tem que ser definido")]
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
