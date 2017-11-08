using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserMicroService.Models
{
    public class User
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }
        public string userAddress { get; set; }
        public string zipCode { get; set; }
        public string cityName { get; set; }
        public string countryName { get; set; }
        public int userPhone { get; set; }

        public User()
        {

        }
    }
}