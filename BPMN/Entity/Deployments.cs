using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMN.Entity
{
    public class Deployments
    {
        List<Deployment> deployment { get; set; }
        public int total { get; set; }
        int start { get; set; }
        string sort { get; set; }
        string order {get; set;}
        int size { get; set; }
    }
}
