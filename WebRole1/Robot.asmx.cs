using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.Services;


namespace WebRole1
{
    /// <summary>
    /// Summary description for Robot
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Robot : System.Web.Services.WebService
    {

        public string URL { get; private set; }

        public List<string> rules { get; private set; }
        //private List<CrawlDelayRule> crawlDelayRules;



        public Robot(string URL, List<string> rules)
        {
            this.URL = URL;
            this.rules = rules;
        }
        
    }

    

    
}
