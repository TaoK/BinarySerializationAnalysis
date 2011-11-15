using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySerializationAnalysis
{
    [Serializable]
    class DummyClass
    {
        public List<int> someList;
        public string someString;
        public DummyClass subObject;
    }
}
