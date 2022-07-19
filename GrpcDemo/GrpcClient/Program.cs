using Grpc.Net.Client;
using MagicOnion.Client;
using Shared;

namespace GrpcClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.Title = "GrpcDemo by 蓝创精英团队";
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var demo = MagicOnionClient.Create<IDemo>(channel);
            Console.WriteLine(await demo.Say1("123"));
            Console.WriteLine(await demo.Say2("demo", 6, new List<string>() { "6" }, Kind.b));
            Console.WriteLine(await demo.Say3(1, new List<string>(), Kind.a));
            Console.WriteLine("不错，完成了任务!");
            Console.ReadLine();
        }
    }
}