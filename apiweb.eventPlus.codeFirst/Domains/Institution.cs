using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiweb.eventPlus.codeFirst.Domains
{
    [Table("Institutions")]
    [Index(nameof(CNPJ), IsUnique = true)]
    public class Institution
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome fantasia é obrigatório")]
        public string FancyName { get; set; } 
        
        [Column(TypeName = "CHAR(14)")]
        [Required(ErrorMessage = "O CNPJ é obrigatório")]
        public string CNPJ { get; set; } 
        [Column(TypeName = "CHAR(14)")]
        [Required(ErrorMessage = "O endereço é obrigatório")]
        public string Address { get; set; }
    }
}
