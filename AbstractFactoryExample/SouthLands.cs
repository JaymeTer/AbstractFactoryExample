using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample
{
    //Concret product b2
    public class SouthLands : INation
    {
        public int GetMilitaryPower()
        {
            return 450;
        }

        public List<string> ListRaceRatio()
        {
            return new List<string>
            {
                "Human = 30%",
                "Elvish = 60%",
                "Orcish = 10%"

            };
        }
    }
}
