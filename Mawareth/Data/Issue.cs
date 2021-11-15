using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mawareth.Data
{
    public class Issue
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Dead> Deads { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
