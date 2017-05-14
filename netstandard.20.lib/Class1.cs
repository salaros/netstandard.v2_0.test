using System.Collections.Generic;

namespace netstandard.v2_0.lib
{
    public class MyFancyUtil
    {
        public static readonly Dictionary<string, string> SimplierThanThis;

        static MyFancyUtil()
        {
            SimplierThanThis = new Dictionary<string, string>
            {
                { "foo", "bar" }
            };
        }
    }
}
