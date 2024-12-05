using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample
{
    //concret factory 2
    public class SouthLandFactory : IFactory
    {
        public ILanguage CreateLanguage()
        {
            return new Elvish();
        }

        public INation CreateNation()
        {
            return new SouthLands();
        }
    }
}
