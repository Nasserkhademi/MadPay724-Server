using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MadPay724.Data.Models
{
    public class Photo : BaseEntity<string>
    {
        public Photo()
        {
            ID = Guid.NewGuid().ToString();
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }
 
        [Required(ErrorMessage = "لطفا مقدار {0} را وارد نمائید")]
        public string Url { get; set; }
        public string Description { get; set; }
        public string AltText { get; set; }
        [Required(ErrorMessage = "لطفا مقدار {0} را وارد نمائید")]
        public bool IsMain { get; set; }
        [Required(ErrorMessage = "لطفا مقدار {0} را وارد نمائید")]
        public string UserId { get; set; }
        public User User { get; set; }


    }
}
