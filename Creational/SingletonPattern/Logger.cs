using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class Logger
    {
        private static Logger _logger;
        private static object _lockObject = new object();

        private Logger()
        {
        }

        public Guid LoggerGuid { get; private set; }

        public static Logger GetInstance()
        {
            if (_logger == null)
            {
                lock (_lockObject) //to prevent to create multi instance in multi-thread apps
                {
                    if (_logger == null)
                    {
                        _logger = new Logger() { LoggerGuid = Guid.NewGuid() };
                    }
                }
            }

            return _logger;
        }
    }
}
