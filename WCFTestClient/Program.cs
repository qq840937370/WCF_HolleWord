using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFTestClient.MyWCFReference;

namespace WCFTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MyWCFServiceClient client = new MyWCFServiceClient();
            Console.WriteLine(client.GetData(123456));
            CompositeType cType = new CompositeType()
            {
                StringValue = "Hello World!",
                BoolValue = true
            };
            Console.WriteLine(client.GetDataUsingDataContract(cType).StringValue);
            client.Close();
            Console.ReadLine();
        }
    }
}
