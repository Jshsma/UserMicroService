using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserMicroService.Models;

namespace UserMicroService.DataAccess
{
    public static class UserDB
    {
        public static List<User> users = new List<User>();

        public static List<User> GetAllUsers()
        {
            return users;
        }
        public static User getUserId(int id)
        {
            foreach (User user in users)
            {
                if (user.userId == id)
                {
                    return user;
                }
            }//ovo moze skraceno sa LINQ
            return null; 
        }
        public static User CreateUser(User user)
        {
            users.Add(user);
            return getUserId(user.userId);
        }
    }
}