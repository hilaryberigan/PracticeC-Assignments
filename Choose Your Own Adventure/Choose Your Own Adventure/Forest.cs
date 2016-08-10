using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Own_Adventure
{
    class Forest
    {
        string treeType;
        string treeColor;


        public string chooseTreeColor()
        {
            Console.WriteLine("What color are the trees? [Enter any color]");
            treeColor = Console.ReadLine();
            return treeColor;
        }
        public string getTreeColor()
        {
            return treeColor;
        }
        public string chooseTreeType()
        {
            Console.WriteLine("What type of trees? [Enter any type of tree]");
            treeType = Console.ReadLine();
            return treeType;
        }
        public string getTreeType()
        {
            return treeType;
        }
    }

}

