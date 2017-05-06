using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Services.Models.Entities;


namespace BackEnd.Services.Methods
{
    public class AccountService
    {
      

        private readonly Models.AccountContext database;
        public AccountService()
        {
            database = new Models.AccountContext();
        }

        public List<User> GetUser()
        {
            return database.UserList.ToList();
        }

        private User GetUserId(long userId)
        {
            return database.UserList.Where(u => u.UserId.Equals(userId)).FirstOrDefault();
        }

        public User GetFirstName(string firstName)
        {
            return database.UserList.Where(u => u.FirstName.Equals(firstName)).FirstOrDefault();
        }

        public User GetLastName(string lastName)
        {
            return database.UserList.Where(u => u.LastName.Equals(lastName)).FirstOrDefault();
        }
        public User GetBirthday(string birthDay)
        {
            return database.UserList.Where(u => u.Birthday.Equals(birthDay)).FirstOrDefault();
        }
        public User GetGender(string genDer)
        {
            return database.UserList.Where(u => u.Gender.Equals(genDer)).FirstOrDefault();
        }
        public User GetEmail(string emailAddress)
        {
            return database.UserList.Where(u => u.EmailAddress.Equals(emailAddress)).FirstOrDefault();
        }
        public User GetPassword(string passWord)
        {
            return database.UserList.Where(u => u.Password.Equals(passWord)).FirstOrDefault();
        }
        public User GetConfirmtPassword(string confirmPassword)
        {
            return database.UserList.Where(u => u.ConfirmPassword.Equals(confirmPassword)).FirstOrDefault();
        }
     

        public void Save(User user)
        {
            database.UserList.Add(user);
            database.SaveChanges();
        }
    }
}


