using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample
{
    //concrete product a2   
    public class Elvish : ILanguage
    {
        public void Greet()
        {
            Console.WriteLine(" Nation = SouthLands ");
            Console.WriteLine(" Language = Elvish ");
        }
    }
}
