using System;

namespace Sample.MultiTarget.Library
{
    public class Demo
    {
        private readonly string _version;

        public Demo()
        {
#if NETFRAMEWORK
            _version = "Target Framework is .Net Framework";
#elif NETCOREAPP
            _version = "Target Framework is .Net Core";
#endif
        }

        public string GetVersion()
        {
            return _version;
        }
    }
}
