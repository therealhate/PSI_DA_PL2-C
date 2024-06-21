using ICantina_v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICantina_v1.Models
{
    public class Reservation
    {
        public Client Client { get; set; }
        public DateTime Dia { get; set; }
        public string Menu { get; set; }
        public string Extras { get; set; }

        public override string ToString()
        {
            return $"{Client.Nome} - {Dia.ToShortDateString()} - {Menu} - {Extras}";
        }
    }
}

