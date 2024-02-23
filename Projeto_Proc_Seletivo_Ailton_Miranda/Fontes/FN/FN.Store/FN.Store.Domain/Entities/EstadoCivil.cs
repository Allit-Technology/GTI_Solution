using FN.Store.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FN.Store.Domain.Entities
{
    [Table(nameof(EstadoCivil))]
    public class EstadoCivil : Entity
    {
        [Column(TypeName = "varchar")]
        [StringLength(100, ErrorMessage = "Limite de caracteres excedido")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }
    }
}
