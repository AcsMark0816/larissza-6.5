using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace larissza8
{
    public record Product(string name,string category,string manufacturer)
    {
        private int price { get; set; }
        private int stock { get; set; }


        public int PS(int s)
        {
            stock += s;
            return stock;
        }

        public int WP()
        {
            return price * stock;
        }

        public int PR() 
        { 
            return price;
        }
        public int RS()
        {
                        return stock;
        }
        public void SetPrice(int p)
        {
            price = p;
        }
        public void SS(int s)
        {
            stock = s;
        }
    }
}
