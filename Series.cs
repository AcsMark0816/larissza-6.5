using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace larissza7
{
    public record Series(string title,string genre,string studio)
    {
        private int episodes {  get; set; }
        private double rating { get; set; }



        public void R(double R)
        {
            rating = R;
        }
        public void EPS(int e)
        {
            episodes = e;   
        }
        public int E()
        {
            return episodes;
        }
        public double RR()
        {
            return rating;
        }
        public int ep(int e)
        {
            return episodes += e;
        }
        public bool L()
        {
            if(episodes >= 40)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
