using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Own_Adventure
{
    class Warehouse
    {
        string warehouseSize;
        string warehouseColor;

        public void chooseWarehouseSize()
        {
            Console.WriteLine("How big is the abandoned warehouse? [huge or medium-sized]");
            warehouseSize = Console.ReadLine();
        }

        public void chooseWarehouseColor()
        {
            Console.WriteLine("What color is the abandoned warehouse? [choose any color]");
            warehouseColor = Console.ReadLine();
        }
        public string getWarehouseSize()
        {
            return this.warehouseSize;
        }
        public string getWarehouseColor()
        {
            return this.warehouseColor;
        }
    }
}

