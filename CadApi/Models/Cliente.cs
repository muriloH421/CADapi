using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CadApi.Models
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }

        [Required(ErrorMessage = "O Campo Nome é Obrigatório")]
        public string ClienteNome { get; set; }

        [Required(ErrorMessage = "O Campo Data de Nascimento é Obrigatório")]
        public DateTime DataNasc { get; set; }

        public DateTime? DataCadastro { get; set; } = DateTime.Now;
        public bool? CadastroAtivo { get; set; } = true;

        public Guid? IdentityUserId { get; set; }
        public IdentityUser? IdentityUser { get; set; }
    }
}
