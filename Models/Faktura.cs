using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUsage.Models
{
    public class Faktura
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FakturaId { get; set; }

        [Required]
        [StringLength(20)]
        public string Numer { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Wartosc { get; set; }

        public virtual ICollection<Pozycja> Pozycje { get; set; }

        public Faktura()
        {
            Pozycje = new HashSet<Pozycja>();
        }

    }
}
