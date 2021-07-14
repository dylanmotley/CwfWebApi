using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CwfWebApi.Models {
    public class Invoice {

        public int Id { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        public decimal TotalAmount { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public DateTime SentToCustomer { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsPaid { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public int? PaymentId { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
