using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColocTour
{
    public class Tour
    {
        public string Country { get; set; }
        public int Duration { get; set; }
        public decimal Price { get; set; }

        public Tour(string country, int duration, decimal price)
        {
            Country = country;
            Duration = duration;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Country} - {Duration} дней - {Price} руб.";
        }
    }
}
