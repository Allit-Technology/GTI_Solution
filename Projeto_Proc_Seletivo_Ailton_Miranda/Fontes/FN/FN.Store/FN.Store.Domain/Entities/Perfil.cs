using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FN.Store.Domain.Entities
{
    [Table("Perfil")]
    public class Perfil:Entity
    {
        [Column(TypeName ="varchar")]
        [StringLength(50, ErrorMessage ="Limite excedido")]
        [Required(ErrorMessage ="Campo obrigatório")]
        public string Nome { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
            = new List<Usuario>();


    }
}
