using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudCliente.Models
{
    public class Pais
    {
        [Key]
        public int PaisId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(300)")]
        public string Nome { get; set; }
    }
}
