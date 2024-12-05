using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample
{
    //Abstract product B
    public interface INation
    {
        int GetMilitaryPower();
        List<string> ListRaceRatio();
    }
}
