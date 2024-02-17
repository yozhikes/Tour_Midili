﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TourTest.Context.Models
{
    public class Tour
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string CountryCode { get; set; }
        public virtual Country Country { get; set; }

        public int TicketCount { get; set; } = 1;

        public decimal Price { get; set; }

        public bool IsActual { get; set; } = true;

        public string Description { get; set; }

        public byte[] ImagePreview { get; set; }

        public virtual ICollection<Hotel> Hotels { get; set; }

        public virtual ICollection<Type> Types { get; set; }

        public Tour()
        {
            Hotels = new HashSet<Hotel>();
            Types = new HashSet<Type>();
        }
    }
}
