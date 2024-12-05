using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample
{
    //Concrete product A1
    public class Common : ILanguage
    {
        public void Greet()
        {
            Console.WriteLine(" Nation = EastLands ");
            Console.WriteLine(" Language = Common ");
        }
    }
}
