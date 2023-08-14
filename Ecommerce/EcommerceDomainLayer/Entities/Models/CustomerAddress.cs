using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDomainLayer.Entities.Models
{
    public  class CustomerAddress
    {
        [Key]
        public int Id { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public int Zipcode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }




    }
}
