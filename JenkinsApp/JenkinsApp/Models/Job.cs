using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JenkinsApp.Models
{
    //public class Job
    //{
    //    [JsonProperty("Name")]
    //    public string Name  { get; set; }

    //    [JsonProperty("Url")]
    //    public string Url  { get; set; }

    //    [JsonProperty("Color")]        
    //    public string Color  { get; set; }

    //    [JsonProperty("DisplayName")]
    //    public string DisplayName { get; set; }

    //    [JsonProperty("UpstreamProjects")]
    //    public string UpstreamProjects { get; set; }

    //    [JsonProperty("DownstreamProjects")]
    //    public string DownstreamProjects { get; set; }

    //    [JsonProperty("Builds")]
    //    public List<Build> Builds { get; set; }

    //    [JsonProperty("LastBuild")]
    //    public string LastBuild { get; set; }

    //    [JsonProperty("LastCompletedBuild")]
    //    public string LastCompletedBuild { get; set; }

    //    [JsonProperty("LastFailedBuild")]
    //    public string LastFailedBuild { get; set; }

    //    [JsonProperty("LastStableBuild")]
    //    public string LastStableBuild { get; set; }

    //    [JsonProperty("LastSuccessfulBuild")]
    //    public string LastSuccessfulBuild { get; set; }

    //    [JsonProperty("LastUnsuccessfulBuild")]
    //    public string LastUnsuccessfulBuild { get; set; }

    //}

    public class Job
    {
        public string Name { get; set; }

        [DisplayName("API Url")]
        public string Url { get; set; }

        [DisplayName("Status/Color")]
        public string Color { get; set; }

        public string DisplayName { get; set; }

        public string UpstreamProjects { get; set; }

        public string DownstreamProjects { get; set; }

        public List<Build> Builds { get; set; }

        public string LastBuild { get; set; }

        public string LastCompletedBuild { get; set; }

        public string LastFailedBuild { get; set; }

        public string LastStableBuild { get; set; }

        public string LastSuccessfulBuild { get; set; }

        public string LastUnsuccessfulBuild { get; set; }

    }
}