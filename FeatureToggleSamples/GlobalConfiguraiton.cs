using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeatureToggleSamples
{

    public class GlobalConfiguraiton
    {
        public CustomerFeature2019toggle CustomerFeature2019Toggle { get; set; }
    }

    public class CustomerFeature2019toggle
    {
        public bool CustomerUI { get; set; }
        public bool CustomerDigitalPayment { get; set; }
        public Customerdb CustomerDB { get; set; }
    }

    public class Customerdb
    {
        public string ConnectionString { get; set; }
        public int AccountKey { get; set; }
    }


}
