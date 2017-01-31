using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JenkinsApp.Models
{
    //public class Build
    //{
    //    [JsonProperty("FullDisplayName")]
    //    public string FullDisplayName { get; }

    //    [JsonProperty("Job")]
    //    public Job Job { get; set; }

    //    [JsonProperty("Number")]
    //    public string Number { get; }

    //    [JsonProperty("ShortDescription")]
    //    public string ShortDescription { get; }

    //    [JsonProperty("Url")]
    //    public string Url { get; }
    //}

    public class Build
    {        
        public string FullDisplayName { get; }
        
        public Job Job { get; set; }
        
        public string Number { get; }
        
        public string ShortDescription { get; }
        
        public string Url { get; }
    }
}