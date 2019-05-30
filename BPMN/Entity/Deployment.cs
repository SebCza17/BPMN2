using System;

namespace BPMN.Entity
{
    public class Deployment
    {
        public string id { get; set; }
        public string name { get; set; }
        public DateTime deploymentTime { get; set; }
        public string category { get; set; }
        public string url { get; set; }
        public object tenantId { get; set; }
    }


   

}