using Microsoft.ApplicationInsights.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace DemoSite
{
    /// <summary>
    /// This class is called during telemetry context initialization for any TelemetryClient instances. 
    /// It contains logic for setting global properties for all telemetry items types:
    /// 1. Application version
    /// 2. Tag string
    /// </summary>
    public class ApplicationInsightsConfigInitializer
        : IContextInitializer
    {

        public void Initialize(Microsoft.ApplicationInsights.DataContracts.TelemetryContext context)
        {
            // Configure app version
            context.Component.Version = ApplicationInsightsConfigSettings.Version;
            // Set arbitrary tags 
            context.Properties["tag"] = ApplicationInsightsConfigSettings.Tag;
        }
    }
}