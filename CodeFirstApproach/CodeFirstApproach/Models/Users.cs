using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproach.Models
{
    public class Users
    {
        [Key]
        public Guid Id { get; set; }

        [Column("Name", TypeName = "ntext")]
        [MaxLength(20)]
        public string Name { get; set; }

        [NotMapped]
        public string ShortName { get; set; }

        public string LongName { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        //public string CountryCode { get; set; }

        public virtual ICollection<Customers> Customers { get; set; }
    }
}
