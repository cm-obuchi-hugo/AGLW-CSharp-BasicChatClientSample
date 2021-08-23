using System;

namespace AGLW_CSharp_BasicChatClientSample
{
    class Program
    {
        static private ChatClient client = new ChatClient();
        static void Main(string[] args)
        {
            client.Start();

            while(client.IsAlive)
            {

            }

            Console.WriteLine("Program ends.");
        }
    }
}
