using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorEscolar.Models
{
    [Table("Professores")]
    public class Professor
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome do Professor")]
        [Column("Nome")]
        [StringLength(100, MinimumLength = 3)]
        public string Nome { get; set; }

        [Required]
        [Column("Disciplina")]
        [Display(Name = "Disciplina")]
        public string Disciplina { get; set; }

        [Required]
        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Column("Senha")]
        [Display(Name = "Senha")]
        public string Senha { get; set; }
    }
}
