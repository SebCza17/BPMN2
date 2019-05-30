using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace BPMN
{
    class Program
    {
        static void Main(string[] args)
        {
            DAO.DeploymentDAO deploymentDAO = new DAO.DeploymentDAO();

            Console.WriteLine(deploymentDAO.getDeployments().total);
            Console.ReadKey();
        }

        
    }
}
