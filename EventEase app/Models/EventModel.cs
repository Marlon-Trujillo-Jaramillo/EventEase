using System;
using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class EventModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }

        public string Description { get; set; }
    }
}