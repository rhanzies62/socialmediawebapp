using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BackEnd.Services.Models
{
    public class AccountContext : DbContext
    {
        public AccountContext() : base("DbConnectionString") { }
        public IDbSet<Entities.User> UserList { get; set; }
   
    }
}
