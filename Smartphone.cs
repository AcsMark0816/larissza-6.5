using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace larissza7
{
    public record Smartphone(string Brand, string Model, int ReleaseYear)
    {
        private int releaseYear { get; set; } = ReleaseYear;
        private int price { get; set; }
        public double Rating { get; set; }



        public int GetReleaseYear()
        {
            return releaseYear;
        }
        public void SetPrice(int nprice)
        {
            price = nprice;
        }
        public void UP(int p)
        {
            price = price * (100 - p) / 100;
        }


    }   
}
