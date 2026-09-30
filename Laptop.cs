using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace larissza7
{
    public record Laptop(string brand, string model, string processor)
    {
        private int price { get; set; }
        private string _processor { get; set; } = processor;
        public int Memory { get; set; }


        public int GP()
        {
            return price;
        }
        public string PP()
        {
            return processor;
        }

        public void LP(int p)
        {
                price += p;
        }
        public void MP(int m)
        {
            Memory = Memory + m;
        }
    }
}
