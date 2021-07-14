using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CwfWebApi.Models {
    public class User {

        public int Id { get; set; }
        [StringLength(30), Required]
        public string Firstname { get; set; }
        [StringLength(30), Required]
        public string Lastname { get; set; }
        [StringLength(30), Required]
        public string Department { get; set; }
        public bool Editor { get; set; }
        public bool Submitter { get; set; }
    }
}
