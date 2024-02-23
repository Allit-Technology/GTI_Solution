using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FN.Store.Domain.Entities
{
    [Table(nameof(Sexo))]
    public class Sexo : Entity
    {
        [Column(TypeName = "varchar")]
        [StringLength(100, ErrorMessage = "Limite de caracteres excedido")]
        public string Descricao { get; set; }
    }
}
