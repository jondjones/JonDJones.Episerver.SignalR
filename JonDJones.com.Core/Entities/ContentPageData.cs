using EPiServer.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JonDJones.com.Core.ScheduledTasks
{
    public class ContentPageData
    {
        [JsonProperty(PropertyName = "name")]
        public string PageName { get; set; }

        public ContentReference ParentContentReference { get; set; }

        [JsonProperty(PropertyName = "seotitle")]
        public string SeoTitle { get; set; }

        [JsonProperty(PropertyName = "keywords")]
        public string Keywords { get; set; }
    }
}
