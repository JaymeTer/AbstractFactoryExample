using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample
{
    //concrete factory 1
    public class EastLandFactory : IFactory
    {
        public ILanguage CreateLanguage()
        {
            return new Common();
        }

        public INation CreateNation()
        {
            return new EastLands();
        }
    }
}
