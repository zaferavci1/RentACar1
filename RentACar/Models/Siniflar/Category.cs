using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentACar.Models.Siniflar
{
    public class Category

    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public List<Car> Cars { get; set; }
    }
}