using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDomainLayer.Entities.Models
{
    public class Customers
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }  
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        [ForeignKey("CustomerAddress")]
        public int AddressId { get; set; }
        public bool IsDeleted { get; set; }

    }
}
