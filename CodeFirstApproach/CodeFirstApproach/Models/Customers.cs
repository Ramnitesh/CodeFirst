using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproach.Models
{
    public class Customers
    {
        //[Key]
        public Guid Id { get; set; }

        //[Column("Name", TypeName = "ntext")]
        //[MaxLength(20)]
        public string CustomerName { get; set; }

        public Guid UserId { get; set; }



        //[ForeignKey("UserId")]
        public virtual Users Users { get; set; }
    }
}
