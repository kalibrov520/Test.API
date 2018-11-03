using System;

namespace Test.API.Dtos
{
    public class UsersToListDto
    {
        //public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string Gender { get; set; }
        public string PassportNumber { get; set; }
        public int Age { get; set; }
    }
}