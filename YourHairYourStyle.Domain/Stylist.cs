using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourHairYourStyle.Domain
{
    public class Stylist
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Schedule { get; set; }
        public string Availability { get; set; }
    }
}
