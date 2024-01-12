using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoMVC2024.Models
{
    [Table("Formulario")]
    public class Formulario
    {
        [Display(Name = "Codigo")]
        [Column("Id")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        [Column("Nome")]
        public string? Nome { get; set; }
        [Display(Name = "SobreNome")]
        [Column("SobreNome")]
        public string? SobreNome { get; set; }
        [Display(Name = "Email")]
        [Column("Email")]
        public string? Email { get; set; }
        [Display(Name = "Telefone")]
        [Column("Telefone")]
        public string? Telefone { get; set; }
        [Display(Name = "DataNascimento")]
        [Column("DataNascimento")]
        public string? DataNascimento { get; set; }
    }
}
