using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThiPIIT.Models
{
    public class Market
    {
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("Market Name")]
        [Required(ErrorMessage = "Please enter market name")]
        public string Name { get; set; }
        [DisplayName("Market Description")]
        [Required(ErrorMessage = "Please enter market description")]
        public string Description { get; set; }
        [DisplayName("CreatedAt")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("UpdatedAt")]
        public DateTime UpdatedAt { get; set; }
        [DisplayName("Status")]
        public string Status { get; set; }
        public virtual ICollection<Coin> Coins { get; set; }
    }
}