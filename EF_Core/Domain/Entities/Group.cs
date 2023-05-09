using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core.Domain.Entities
{
    public class Group
    {
        [Required]
        [Key]
        public int gr_id { get; set; }
        public string gr_name { get; set; }
        public float gr_temp { get; set; }
    }
}
