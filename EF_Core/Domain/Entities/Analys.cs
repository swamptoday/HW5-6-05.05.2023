using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core.Domain.Entities
{
    public class Analys
    {
        [Required]
        [Key]
        public int an_id { get; set; }
        public string an_name { get; set; }
        public float an_cost { get; set; }
        public float an_price { get; set; }
        public int an_group { get; set; }
        [ForeignKey("an_group")]
        public virtual Group Group { get; set; }
    }
}
