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
        public required string Rua { get; set; }

        [Column("bairro")]
        public string Bairro { get; set; }

        [Column("cidade")]
        public string Cidade { get; set; }

        [Column("tipo")]
        public int Tipo { get; set; } = 1; // 1 - endereco padrão, 2 - endereco de cobranca, 3 - endereco adicional

        [Column("cep")]
        public int Cep { get; set; }

        // FK para a entidade Pessoa
        [ForeignKey("Pessoa")]
        public int PessoaId { get; set; }

        // Propriedade de navegação para a relação inversa
        [JsonIgnore]
        public Pessoa? Pessoa { get; set; }
    }
}
