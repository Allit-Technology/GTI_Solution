using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FN.Store.Domain.Entities
{
    [Table(nameof(ClientesEndereco))]
    public class ClientesEndereco : Entity
    {
        [Column(TypeName = "varchar")]
        [StringLength(9, ErrorMessage = "Limite de caracteres excedido")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Cep { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50, ErrorMessage = "Limite de caracteres excedido")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Logradouro { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(6, ErrorMessage = "Limite de caracteres excedido")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Numero { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(30, ErrorMessage = "Limite de caracteres excedido")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Complemento { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20, ErrorMessage = "Limite de caracteres excedido")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Bairro { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20, ErrorMessage = "Limite de caracteres excedido")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Cidade { get; set; }

        public int ClienteId { get; set; }

        [ForeignKey(nameof(ClienteId))]
        public virtual Cliente Cliente { get; set; }

        public int UFId { get; set; }
        [ForeignKey(nameof(UFId))]
        public virtual UnidadeFederativa UnidadeFederativa { get; set; }

    }
}
