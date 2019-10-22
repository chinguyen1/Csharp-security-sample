using System;
using System.Collections.Generic;

namespace MSGraphSecurity
{
    public class TiIndicator
    {
        //properties of TI Indicator - NEED TO FINISH THIS class
        public string Action { get; set; }
        public List<string> ActivityGroupNames { get; set; }
        public string AdditionalInformation { get; set; }
        public string AzureTenantId { get; set; }
        public int Confidence { get; set; }
        public string Description { get; set; }
        public string DiamondModel { get; set; }
        public DateTimeOffset ExpirationDateTime { get; set; }
        public string ExternalId { get; set; }
        public string Id { get; set; }
        public DateTimeOffset IngestedDateTime { get; set; }
        public bool IsActive { get; set; }
        public List<string> KillChain { get; set; }
        public string KnownFalsePositives { get; set; }
        public DateTimeOffset LastReportedDateTime { get; set; }
        public List<string> MalwareFamilyNames { get; set; }
        public bool PassiveOnly { get; set; }
        public int Severity { get; set; }
        public List<string> Tags { get; set; }
        public string TargetProduct { get; set; }
        public string ThreatType { get; set; }
        public string TlpLevel { get; set; }
        public string Url { get; set; }
    }
}
