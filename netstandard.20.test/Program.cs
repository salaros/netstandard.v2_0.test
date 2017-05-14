using netstandard.v2_0.lib;

namespace netstandard.v2_0.test
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var s in MyFancyUtil.SimplierThanThis)
            {
                s.ToString();
            }
        }
    }
}
