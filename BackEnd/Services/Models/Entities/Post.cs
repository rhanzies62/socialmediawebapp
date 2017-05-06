using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.Services.Models.Entities
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }
        public int UserId { get; set; }
        public string UserPost { get; set; }
    }
}
