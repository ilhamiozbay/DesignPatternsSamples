using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class CustomOperation
    {
        private readonly IJsonSerializer _jsonSerializer;

        public CustomOperation(IJsonSerializer jsonSerializer)
        {
            _jsonSerializer = jsonSerializer;
        }

        public string SerializeObject(object value)
        {
            return _jsonSerializer.SerializeObject(value);
        }
    }
}
