using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakturaForms.Models
{
    public class Pozycja
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "numeric(18,0)")]
        public decimal PozycjaId { get; set; }

        [Required]
        [Column(TypeName = "numeric(18,0)")]
        public decimal FakturaId { get; set; }

        [Required]
        [StringLength(20)]
        public string Nazwa { get; set; }

        [Column(TypeName = "decimal(18,0)")]
        public decimal Wartosc { get; set; }

        [ForeignKey("FakturaId")]
        public virtual Faktura Faktura { get; set; }
    }
}
