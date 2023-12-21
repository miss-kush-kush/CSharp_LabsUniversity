using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUsage.Models
{
    public class Pozycja
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PozycjaId { get; set; }

        [Required]
        public int FakturaId { get; set; }

        [Required]
        [StringLength(20)]
        public string Nazwa { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Wartosc { get; set; }

        [ForeignKey("FakturaId")]
        public virtual Faktura Faktura { get; set; }
    }
}
