using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFService_2Way_20180140067;

namespace ServerChatApp_20180140067_Yusuf_Johan_Kelana
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost serviceHost = null;
            try
            {
                serviceHost = new ServiceHost(typeof(ServiceCallback));
                serviceHost.Open();

                Console.WriteLine("Server On, Ready to use");
                Console.ReadLine();

                serviceHost.Close();
            }
            catch (Exception ex)
            {
                serviceHost = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
