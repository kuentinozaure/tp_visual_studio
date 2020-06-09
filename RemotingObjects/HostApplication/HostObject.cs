using RemotingObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostApplication
{
    class HostObject : MarshalByRefObject, RemotingObjects.IRemoteObject
    {
        private int nbCall = 0;
        public String sayHello(String name)
        {
            nbCall += 1;
            return "Hello " + name + " number of invocations : "
                + nbCall.ToString();
        }

    }
}
