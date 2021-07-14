using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CwfWebApi.Models {
    public class Customer {

        public int Id { get; set; }
        [StringLength(50), Required]
        public string CompanyName { get; set; }
        [StringLength(100), Required]
        public string Address { get; set; }
        [StringLength(50), Required]
        public string City { get; set; }
        [StringLength(2), Required]
        public string State { get; set; }
        [StringLength(5), Required]
        public string Zip { get; set; }
        [StringLength(25), Required]
        public string Phone { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
    }
}
