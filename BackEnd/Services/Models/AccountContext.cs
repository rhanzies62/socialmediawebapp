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
        public AccountContext() : base("DatabaseConnectionString") { }
        public IDbSet<Entities.User> Users { get; set; }
        public IDbSet<Entities.Post> Posts { get; set; }
    }
}
