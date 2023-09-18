using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiweb.eventPlus.codeFirst.Domains
{
    [Table("EventTypes")]
    public class EventType
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome do tipo do evento é obrigatório")]
        public string TypeName { get; set; }
    }
}
