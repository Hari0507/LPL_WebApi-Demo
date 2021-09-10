using System;
using System.ComponentModel.DataAnnotations;

namespace UserInfoApi.Models
{
    public class UserDetails
    {
        public UserDetails()
        {
        }
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
