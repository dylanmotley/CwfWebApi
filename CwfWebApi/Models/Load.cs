using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CwfWebApi.Models {
    public class Load {

        public int Id { get; set; }
        [StringLength(30), Required]
        public string Lane { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        public decimal Cost { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        public decimal Revenue { get; set; }
        [StringLength(255)]
        public string Description { get; set; }

        public int? InvoiceId { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}
