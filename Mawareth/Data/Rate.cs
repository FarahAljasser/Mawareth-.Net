using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mawareth.Data
{
    public class Rate
    {
        [Key]
        public int Id { get; set; }
        public byte Stars { get; set; }
    }
}
