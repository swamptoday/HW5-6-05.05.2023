using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core.Domain.Entities
{
    public class Order
    {
        [Required]
        [Key]
        public int ord_id { get; set; }
        public DateTime ord_datetime { get; set; }
        public int ord_an { get; set; }
        [ForeignKey("ord_an")]
        public virtual Analys Analys { get; set; }

    }
}
