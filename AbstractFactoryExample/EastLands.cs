using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample
{
    //Concrete product B2
    public class EastLands : INation
    {
       
        public int GetMilitaryPower()
        {
            return 780;
        }

        public List<string> ListRaceRatio()
        {
            return new List<string>
            {
                "Human = 80%",
                "Elvish = 10%",
                "Orcish = 10%"
                
            };
        }
    }
}
