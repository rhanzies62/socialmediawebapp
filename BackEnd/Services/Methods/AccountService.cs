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

        public List<User> GetUsers()
        {
            return database.Users.ToList();
        }

        public void AddUser(User Info)
        {
            database.Users.Add(Info);
            database.SaveChanges();
        }

        private Models.Entities.User GetUserId(long userId)
        {
            return database.Users.Where(u => u.UserId.Equals(userId)).FirstOrDefault();
        }

        public Models.Entities.User GetFirstName(string firstName)
        {
            return database.Users.Where(u => u.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
        }

        public Models.Entities.User GetLastName(string lastName)
        {
            return database.Users.Where(u => u.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
        }
        public Models.Entities.User GetEmail(string emailAddress)
        {
            return database.Users.Where(u => u.EmailAddress.Equals(emailAddress, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
        }
        public Models.Entities.User GetPassword(string passWord)
        {
            return database.Users.Where(u => u.Password.Equals(passWord, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
        }
        public Models.Entities.User GetConfirmtPassword(string confirmPassword)
        {
            return database.Users.Where(u => u.ConfirmPassword.Equals(confirmPassword, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
        }
        public Models.Entities.User GetBirthday(string birthDay)
        {
            return database.Users.Where(u => u.Birthday.Equals(birthDay, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
        }
        public Models.Entities.User GetGender(string genDer)
        {
            return database.Users.Where(u => u.Gender.Equals(genDer, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
        }

        public void Save(User user)
        {
            database.Users.Add(user);
            database.SaveChanges();
        }
    }
}


