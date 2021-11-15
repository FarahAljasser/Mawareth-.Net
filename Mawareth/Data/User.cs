using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mawareth.Data
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string Country { get; set; }
        public DateTime? DOB { get; set; }
        public string Identity { get; set; }
        public virtual ICollection<Issue> Issues { get; set; }
    }
}
