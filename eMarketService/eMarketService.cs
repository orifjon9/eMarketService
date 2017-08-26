using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace eMarketService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "eMarketService" in both code and config file together.
    public class eMarketService : IeMarketService
    {
        public string Status()
        {
            return "is alive";
        }
    }
}
