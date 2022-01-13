using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorEscolar.Models
{
    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Column("Nome")]
        [Display(Name = "Nome do Aluno")]
        public string Nome { get; set; }

        [Required]
        [Column("Turma")]
        [Display(Name = "Turma do Aluno")]
        public string Turma { get; set; }
        [Column("Nota1")]
        public double Nota1 { get; set; }
        [Column("Nota2")]
        public double Nota2 { get; set; }
        [Column("Nota3")]
        public double Nota3 { get; set; }
        [Column("Nota4")]
        public double Nota4 { get; set; }
        [Column("Media")]
        public double Media { get; set; }
    }
}
