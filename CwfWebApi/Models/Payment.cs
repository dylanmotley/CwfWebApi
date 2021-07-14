using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CwfWebApi.Models {
    public class Payment {

        public int Id { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        public decimal PaymentAmount { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        [StringLength(255)]
        public string Description { get; set; }


    }
}
