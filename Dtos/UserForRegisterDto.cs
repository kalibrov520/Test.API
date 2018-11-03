using System;
using System.ComponentModel.DataAnnotations;

namespace Test.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        [RegularExpression("^[0-9A-Za-z]{1,8}$")]
        public string Username { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{4,8}$")]
        public string Password { get; set; }
        
        [Required]
        [RegularExpression("^M$|^F$")]
        public string Gender { get; set; }
        
        [Required]
        public DateTime DateOfBirth { get; set; }
        
        [Required]
        [RegularExpression("^[А-Яа-я]{1,30}")]
        public string FirstName { get; set; }
        
        [Required]
        [RegularExpression("^[А-Яа-я]{1,30}")]
        public string LastName { get; set; }
        
        [Required]
        [RegularExpression("^[0-9]{10}")]
        public string PassportNumber { get; set; }
    }
}