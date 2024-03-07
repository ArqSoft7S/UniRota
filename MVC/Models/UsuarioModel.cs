using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Models
{
    [Table("Usuarios")]
    public class UsuarioModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public string? NumeroCelular { get; set; }
        public string? CEP { get; set; }
        public string? Rua { get; set; }
        public int Numero { get; set; }
        public string? Cidade { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
    }
}
