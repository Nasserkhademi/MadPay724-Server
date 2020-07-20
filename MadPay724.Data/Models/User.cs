using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MadPay724.Data.Models
{
    public class User : BaseEntity<string>
    {
        public User()
        {
            ID = Guid.NewGuid().ToString();
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }
        [Required(ErrorMessage = "لطفا مقدار {0} را وارد نمائید")]
        public string Name { get; set; }
        [Required(ErrorMessage = "لطفا مقدار {0} را وارد نمائید")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "لطفا مقدار {0} را وارد نمائید")]
        public byte[] PasswordHash { get; set; }
        [Required(ErrorMessage = "لطفا مقدار {0} را وارد نمائید")]
        public byte[] PasswordSalt { get; set; }
        public string Gender { get; set; }
        [Required(ErrorMessage = "لطفا مقدار {0} را وارد نمائید")]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
       
        public string City { get; set; }
        [Required(ErrorMessage = "لطفا مقدار {0} را وارد نمائید")]
        public bool IsActive { get; set; }
        [Required(ErrorMessage = "لطفا مقدار {0} را وارد نمائید")]
        public string Status { get; set; }
        public string DateOfBirth { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<BankCard> BankCards { get; set; }

    }
}
