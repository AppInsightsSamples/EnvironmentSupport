using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace DemoSite
{
    /// <summary>
    /// This class contains global AI telemetry configuration settings 
    /// 1. Application version
    /// 2. Tag string
    /// 3. Insrtumentation key
    /// </summary>
    public static class ApplicationInsightsConfigSettings
    {
        // Application version based on assemblyinfo.cs version
        private static string version;
        public static string Version
        {
            get
            {
                if (string.IsNullOrEmpty(version)) 
                { 
                    version = typeof(WebApiApplication).Assembly.GetName().Version.ToString(); 
                };
                return version;
            }
        }

        //custom tags from web.config
        private static string tag;
        public static string Tag
        {
            get
            {
                if (string.IsNullOrEmpty(tag))
                {
                    tag = WebConfigurationManager.AppSettings["tag"];
                    if (string.IsNullOrEmpty(tag)) { throw new Exception("Missing tag in Web.config"); };
                };
                return tag;
            }
        }

        //iKey from web.config
        private static string iKey;
        public static string InstrumentationKey
        {
            get
            {
                if (string.IsNullOrEmpty(iKey)) 
                { 
                    iKey = System.Web.Configuration.WebConfigurationManager.AppSettings["iKey"];
                    if (string.IsNullOrEmpty(iKey)) { throw new Exception("Missing instrumentation key in Web.config"); };
                };
                return iKey;
            }
        }
    }
}