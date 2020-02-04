using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LinkShortnerDotNET.Models
{
    public class LinkSet
    {
        [Key]
        public string LinkId { get; set; }
        public string Url { get; set; }
    }
}
