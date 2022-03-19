using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Profile Picture URL")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Name")]
        public  string FullName { get; set; }

        [Display(Name = "Bio")]
        public string Bio { get; set; }

        //Relationships
        public List<Actors_Movies> Actors_Movies { get; set; }
    }
}
