﻿namespace BPMN.Entity
{
    internal class Deployment
    {
        int id { get; set; }
        string name { get; set; }
        string deploymentTime { get; set; }
        string category { get; set; }
        string url { get; set; }
        string tenantId { get; set; }
    }
}