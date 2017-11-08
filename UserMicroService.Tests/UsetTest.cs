using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMicroService.DataAccess;
using UserMicroService.Models;

namespace UserMicroService.Tests
{
    public class UsetTest
    {
        public void CleanUsers()
        {
            UserDB.users.Clear();
        }

        [Test]
        public void Create_User_Success()
        {
            User testUser = new User
            {
                userId = 1,
                userName="Miljan"
            };
            UserDB.CreateUser(testUser);
            Assert.AreEqual(1, UserDB.users.Count);//pitamo da li je duzina liste jednaka 1
        }
    }
}
