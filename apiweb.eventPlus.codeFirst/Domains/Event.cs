using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiweb.eventPlus.codeFirst.Domains
{
    [Table("Events")]
    public class Event
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome do evento é obrigatório")]
        public string? Name { get; set; }
        
        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "A descrição do evento é obrigatório")]
        public string? Description { get; set; }

        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }

        // EventType Reference

        [Required(ErrorMessage = "O tipo do evento é obrigatório")]
        public Guid EventTypeId { get; set; }

        [ForeignKey(nameof(EventTypeId))]
        public EventType? EventType { get; set; }

        // Institution Reference

        [Required(ErrorMessage = "A instituição do evento é obrigatório")]
        public Guid InstitutionId { get; set; }

        [ForeignKey(nameof(InstitutionId))]
        public Institution? Institution { get; set; }
    }
}
