using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cusine_Factory
{
    static class Chef
    {
        public static ICuisine Cook(string typeFood)
        {
            if (typeFood == "italian")
            {
                return new Italian();
            }
            else if (typeFood == "american")
            {
                return new American();
            }
            else if (typeFood == "chinese")
            {
                return new Chinese();
            }
            else 
            {
                throw new Exception();
            }
        }
    }
}
