using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CRUD_MVC.Models
{
    [Table("endereco")]
    public class Endereco
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("rua")]
        public string Rua { get; set; }
        [Column("bairro")]
        public string Bairro { get; set; }
        [Column("cidade")]
        public string Cidade { get; set; }
        [Column("tipo")]
        public int Tipo { get; set; } = 1; //1 - padrão, 2 - cobrança, 3 - adicional
        [Column("cep")]
        public string Cep { get; set; }  // Alterado para string para permitir zeros à esquerda

        // Relacionamento com Pessoa
        [ForeignKey("Pessoa")]
        public int PessoaId { get; set; }

    }
}
