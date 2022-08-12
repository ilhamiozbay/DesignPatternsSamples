using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal sealed class LazyLogger
    {
        private static readonly Lazy<LazyLogger> _lazyLogger = new Lazy<LazyLogger>(() => new LazyLogger());

        private LazyLogger()
        {
            LoggerGuid = Guid.NewGuid();
        }
        //to prevent to create multi instance in multi-thread apps
        public Guid LoggerGuid { get; private set; }

        public static LazyLogger GetInstance()
        {
            return _lazyLogger.Value;
        }
    }
}
