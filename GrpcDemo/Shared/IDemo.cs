using MagicOnion;

namespace Shared
{
public interface IDemo : IService<IDemo>
{
    UnaryResult<string> Say1(string msg);
    UnaryResult<int> Say2(string a, int b, List<string> c, Kind kind);
    UnaryResult<Kind> Say3(int b, List<string> c, Kind kind);   
}
public enum Kind
{
    a,
    b
}
}