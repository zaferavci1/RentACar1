using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentACar.Models.Siniflar
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string Brand { get; set; }
        public Color Color { get; set; }
        public int Price { get; set; }
        public int SeatCount { get; set; }

    }
}