using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MuchLikeMyIP
{
    [Table("Paste")]
    public class Paste : Entity
    {
        public String Name { get; set; }
        public String Text { get; set; }
    }
}
