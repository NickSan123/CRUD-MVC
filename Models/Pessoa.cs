using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace CRUD_MVC.Models
{
    [Table("pessoa")]
    public class Pessoa
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("data_nascimento")]
        public DateTime DataNascimento { get; set; }
        [Column("cpf")]
        public string Cpf { get; set; }
        public List<Endereco>? Enderecos { get; set; }
    }
}
