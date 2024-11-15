using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kebabhouse
{
    public class sef
    {
        public int PocetMasaKebabu(kebab Kebab)
        {
            switch (Kebab.Nazev.ToLower())
            {
                case "malý kebab":
                    return 5;
                case "střední kebab":
                    return 10;
                case "velký kebab":
                    return 20;
                case "kebab bez masa":
                    return 0;
                default:
                    return 0;
            }
        }
    }
}
