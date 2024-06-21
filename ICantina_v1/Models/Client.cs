using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICantina_v1.Models
{
    internal class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
