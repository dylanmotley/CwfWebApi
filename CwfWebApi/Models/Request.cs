using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CwfWebApi.Models {
    public class Request {

        public int Id { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        public decimal RequestAmount { get; set; }
        [StringLength(30), Required]
        public string ReasonForIncrease { get; set; }
        [StringLength(30), Required]
        public string WhenNeeded { get; set; }
        public bool IsClosed { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
