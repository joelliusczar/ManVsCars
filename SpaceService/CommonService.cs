using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;

namespace SpaceService
{
    public abstract class CommonService: Service1
    {
        public virtual bool ServiceIsRunning()
        {
            return true;
        }

        public virtual string[] ServiceInfo()
        {
            return new[] { String.Format("Name: {0}", OperationContext.Current.Host.Description.Name),
                            String.Format("Endpoints: {0}",String.Join(",",OperationContext.Current.Host.Description.Endpoints.Select(e => e.ListenUri)))};
        }


    }
}