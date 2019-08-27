using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigRight.Controllers
{

    public class GlobalConfigurationSettings
    {
        public Logging Logging { get; set; }
        public Customerconfig CustomerConfig { get; set; }
        public Producerconfig ProducerConfig { get; set; }
    }

    public class Logging
    {
        public Loglevel LogLevel { get; set; }
    }

    public class Loglevel
    {
        public string Default { get; set; }
        public string System { get; set; }
        public string Microsoft { get; set; }
    }

    public class Customerconfig
    {
        public string CustomerKeyurl { get; set; }
        public string CustomerdetailsUrl { get; set; }
        public Agency Agency { get; set; }
    }

    public class Agency
    {
        public string AgencyID { get; set; }
        public int AccountKey { get; set; }
    }

    public class Producerconfig
    {
        public string Key1 { get; set; }
        public string Key2 { get; set; }
    }

}
