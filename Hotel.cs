using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace larissza7
{
public record Hotel(string Name,string City, int Stars)

    {
        private int stars { get; set; } = Stars;
        private int PriceN { get; set; }
        public double Rating { get; set; }


        public bool STars4()
        {
          return stars >= 4;

        }
        public void SetPrice(int nprice)
        {
            PriceN = nprice;
        }

        public int SunP(int price)
        {
            return PriceN * price;
        }
    }
}
