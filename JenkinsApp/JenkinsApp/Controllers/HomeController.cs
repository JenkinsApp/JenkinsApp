using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using JenkinsApp.Models;
using Newtonsoft.Json;
using System.Configuration;

namespace JenkinsApp.Controllers
{
    public class HomeController : Controller
    {
        string baseUrl = ConfigurationManager.AppSettings["BaseUrl"].ToString();
        string valuesApi = ConfigurationManager.AppSettings["ValuesApi"].ToString();

        public ActionResult Index()
        {
            List<Job> _jobs = new List<Job>();
            try
            {
                dynamic dynJson = GetResponseFromServer(baseUrl, valuesApi);                
                foreach (var item in dynJson)
                {
                    Job _job = new Job();                    
                    _job.Name = item.Name.ToString();
                    _job.Url = item.Url.ToString();
                    _job.Color = item.Color.ToString();
                    _jobs.Add(_job);
                    
                }
            }
            catch (Exception ex)
            {

            }
            return View _jobs;
        }

        public ActionResult GetTriggerBuild(string jobName)
        {
            dynamic dynJson = null;
            
            try
            {
                dynJson =
                    GetResponseFromServer(baseUrl, valuesApi + "/" + "GetTriggerBuild?jobName=" + jobName + "&projectToken=" + ConfigurationManager.AppSettings[jobName + "Token"]);                
            }
            catch (Exception)
            {
                throw;
            }

            return Json(dynJson, JsonRequestBehavior.AllowGet);
        }


        public dynamic GetResponseFromServer(string baseUrl, string api)
        {
            dynamic returnVal = null;           
            
            try
            {
                var client = new HttpClient();
                string jenkinsUrl = baseUrl + api;
                var response = client.GetAsync(jenkinsUrl).Result;
                if (response.IsSuccessStatusCode)
                {
                    string responseString = response.Content.ReadAsStringAsync().Result;
                    returnVal = JsonConvert.DeserializeObject(responseString);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return returnVal;
        }

        public ActionResult Details(string Name)
        {

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
