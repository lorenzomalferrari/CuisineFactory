using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cusine_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parole valide: italian o american o chinese
            string typeMenu = "italian";
            ICuisine menu = Chef.Cook(typeMenu);

            Console.WriteLine("Ho scelto: "+ menu.Model);
            Console.ReadLine();
            
        }
    }
}
