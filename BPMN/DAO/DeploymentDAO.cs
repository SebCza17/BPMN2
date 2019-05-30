using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BPMN.DAO
{
    class DeploymentDAO
    {
        private RestApp restApp;

        public DeploymentDAO()
        {
            restApp = new RestApp();
        }
        public Entity.Deployments getDeployments()
        {
            return JsonConvert.DeserializeObject<Entity.Deployments>(restApp.makeGet("activiti-rest/service/repository/deployments/"));
        }
    }
}
