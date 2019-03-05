using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Class_3_4_2019.Models
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public DateTime Year{ get; set; }
        public decimal Price { get; set; }
        public enum CarType
        {
            SUV,
            Sedan,
            Supercar
        }
    }
}