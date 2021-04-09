using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWebService.Models
{
    public class User
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string PostalCode { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool IsProducer { get; set; }
        //public UserType UserType { get; set; }
    }

    /*public class UserType
    {
        public long UserTypeId { get; set; }
        public string UserTypeDescription { get; set; }
    }*/
}
