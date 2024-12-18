﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Text.Json.Serialization;

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

        // Relacionamento com Endereços
        public List<Endereco> Enderecos { get; set; }
    }
}
