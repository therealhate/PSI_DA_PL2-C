using ICantina_v1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICantina_v1.Models
{
    internal class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}
