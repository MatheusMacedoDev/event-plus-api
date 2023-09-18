using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiweb.eventPlus.codeFirst.Domains
{
    [Table("Users")]
    [Index(nameof(Email), IsUnique = true)]
    public class User
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O nome do usuário é obrigatório")]
        public string? UserName { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O e-mail do usuário é obrigatório")]
        public string? Email { get; set; }

        [Column(TypeName = "CHAR(60)")]
        [Required(ErrorMessage = "A senha do usuário é obrigatória")]

        public string? Password { get; set; }


        // UserTypes reference

        [Required(ErrorMessage = "O tipo do usuário é obrigatório")]
        public Guid UserTypeId { get; set; }

        [ForeignKey(nameof(UserTypeId))]
        public UserType? UserType { get; set; }
    }
}
