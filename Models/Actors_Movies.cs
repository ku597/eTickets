using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actors_Movies
    {
        public int MovieID { get; set; }

        public Movie Movie { get; set; }

        public int ActorID { get; set; }

        public Actor Actor { get; set; }
    }
}
