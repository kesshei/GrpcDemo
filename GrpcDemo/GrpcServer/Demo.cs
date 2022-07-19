using MagicOnion;
using MagicOnion.Server;
using Shared;

namespace GrpcServer
{
public class Demo : ServiceBase<IDemo>, IDemo
{
    public async UnaryResult<string> Say1(string msg)
    {
        return msg;
    }

    public async UnaryResult<int> Say2(string a, int b, List<string> c, Kind kind)
    {
        return b;
    }

    public async UnaryResult<Kind> Say3(int b, List<string> c, Kind kind)
    {
        return kind;
    }
}
}
