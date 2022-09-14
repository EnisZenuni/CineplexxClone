using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Domain.Models
{
    public class Movie : BaseEntity
    {
      
        [Required]
        [Display(Name = "Movie Name")]
        public string MovieName { get; set; }

        [Display(Name = "Movie Description")]
        public string MovieDescription { get; set; }
        [Display(Name = "Image")]


        public string movieImageUrl { get; set; }
        [Required]
        [Display(Name = "Genre")]

        public string MovieGenre { get; set; }
        [Required]

        [Display(Name = "Trailer")]
        public string MovieTrailerUrl { get; set; } 


        public int Rating { get; set; }
        //TODO maybe add date
        public ICollection<Ticket> Tickets { get; set; }

    }
}
