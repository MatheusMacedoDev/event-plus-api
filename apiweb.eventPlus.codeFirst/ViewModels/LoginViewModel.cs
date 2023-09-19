using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace apiweb.eventPlus.codeFirst.ViewModels
{
    public class LoginViewModel
    {
        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O e-mail do usuário é obrigatório")]
        public string? Email { get; set; }

        [Column(TypeName = "CHAR(60)")]
        [Required(ErrorMessage = "A senha do usuário é obrigatória")]

        public string? Password { get; set; }
    }
}
