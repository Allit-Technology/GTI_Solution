using System;
using System.ComponentModel.DataAnnotations;

namespace FN.Store.Domain.Entities
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}
