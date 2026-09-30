using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace larissza7
{
    public record Restaurant(string name,string city,string category)
    {
        private double AVGP {  get; set; }
        private double Rating {  get; set; }

        public double GTR()
        {
            return Rating;
        }

        public double GTA()
        {

        }


        public void NAVG(double NA)
        {
            if(NA > 0.0 && NA <= 10.0)
            {
                Rating = NA;
            }
            
        }
        public string D()
        {
            if(AVGP >= 12000)
            {
                return "Drage";
            }
            else
            {
                return "nem draga";
            }
        }

        public void PA(double i)
        {
            AVGP = i;
        }
    }
}
