using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace HostApplication
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                // used for tp1 & tp2
                // TcpChannel channel = new TcpChannel(12000);

                // user for tp3
                HttpChannel channel = new HttpChannel(14000);

                // tp1
                //ChannelServices.RegisterChannel(channel, true);
                //RemotingConfiguration.RegisterWellKnownServiceType(
                //   typeof(HostObject), "HostObject", WellKnownObjectMode.Singleton);

                //Console.WriteLine("Remote object ready at server side !");
                //Console.ReadLine();


                // tp2
                //ChannelServices.RegisterChannel(channel, true);
                //RemotingConfiguration.RegisterWellKnownServiceType(
                //   typeof(HostObject), "HostObject", WellKnownObjectMode.SingleCall);

                //Console.WriteLine("Remote object ready at server side !");
                //Console.ReadLine();

                // tp3 
                ChannelServices.RegisterChannel(channel, false);
                RemotingConfiguration.RegisterWellKnownServiceType(
                   typeof(HostObject), "HostObject", WellKnownObjectMode.Singleton);

                Console.WriteLine("Remote object ready at server side, using http !");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Error creating/ registring the channel !");
            }

        }
    }
}
