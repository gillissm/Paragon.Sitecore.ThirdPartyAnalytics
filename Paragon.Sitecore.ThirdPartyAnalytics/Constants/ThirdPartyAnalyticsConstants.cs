using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Paragon.Sitecore.ThirdPartyAnalytics.Constants
{
    public static class ThirdPartyAnalyticsConstants
    {
        public const string TemplateIdString = "44e49bc7-9a57-4341-a47c-2fa1e9c5a0a6";
        public static readonly ID TemplateId = new ID(TemplateIdString);
        public const string TemplateName = "ThirdPartyAnalytics";


        public static readonly ID GoogleAnalyticsIDFieldId = new ID("6bbb5892-ba93-4c39-bf26-8156377b9789");
        public const string GoogleAnalyticsIDFieldName = "GoogleAnalyticsID";


        public static readonly ID GoogleTagManagerIDFieldId = new ID("869e2bd9-9501-47ae-945b-0890d79b70db");
        public const string GoogleTagManagerIDFieldName = "GoogleTagManagerID";        
    }
}