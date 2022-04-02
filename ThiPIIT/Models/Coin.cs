using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThiPIIT.Models
{
    public class Coin
    {
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("Coin Name")]
        [Required(ErrorMessage = "Please enter coin name")]
        public string Name { get; set; }
        [DisplayName("Coin Base Asset")]
        [Required(ErrorMessage = "Please enter coin base asset")]
        public string BaseAsset { get; set; }
        [DisplayName("Coin Quote Asset")]
        [Required(ErrorMessage = "Please enter coin quote asset")]
        public string QuoteAsset { get; set; }
        [DisplayName("Coin Last Price")]
        [Required(ErrorMessage = "Please enter coin last price")]
        public string LastPrice { get; set; }
        [DisplayName("Coin Volumn 24h")]
        [Required(ErrorMessage = "Please enter coin volumn 24h")]
        public int Volumn24h { get; set; }
        [DisplayName("Coin Market")]
        [Required(ErrorMessage = "Please choose market")]
        public int MarketId { get; set; }
        [DisplayName("Created At")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Created At")]
        public DateTime UpdatedAt { get; set; }
        public string Status { get; set; }
        public virtual Market Market { get; set; }

    }
}