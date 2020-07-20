using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MadPay724.Data.Models
{
    public class BankCard : BaseEntity<string>
    {
        public BankCard()
        {
            ID = Guid.NewGuid().ToString();
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }
 
        [Required(ErrorMessage = "لطفا مقدار {0} را وارد نمائید")]
        public string BankName { get; set; }

        [Required(ErrorMessage = "لطفا مقدار {0} را وارد نمائید")]
        [StringLength(maximumLength:16,MinimumLength = 16)]
        public string CardNumber { get; set; }
        public string Shaba { get; set; }
        [Required(ErrorMessage = "لطفا مقدار {0} را وارد نمائید")]
        [StringLength(maximumLength: 2, MinimumLength = 2)]
        public string ExpireMonth { get; set; }
        [Required(ErrorMessage = "لطفا مقدار {0} را وارد نمائید")]
        [StringLength(maximumLength: 2, MinimumLength = 2)]
        public string ExpireYear { get; set; }
        [Required(ErrorMessage = "لطفا مقدار {0} را وارد نمائید")]
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
