using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Own_Adventure
{
    class Lake
    {
        string lakeSize;
        string lakeColor;


        public void chooseLakeColor()
        {
            Console.WriteLine("What color is the water? [Enter any color]");
            lakeColor = Console.ReadLine();
        }
        public string getLakeColor()
        {
            return lakeColor;
        }
        public void chooseLakeSize()
        {
            Console.WriteLine("How big is the lake? [Enter big or small]");
            lakeSize = Console.ReadLine();
        
        }
        public string getLakeSize()
        {
            return lakeSize;
        }
    }
  
}
