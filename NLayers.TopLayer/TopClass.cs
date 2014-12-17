using NLayers.MiddleLayer;
using NLayers.Models;

namespace NLayers.TopLayer
{
    public class TopClass : ITopClass
    {
        private readonly IMiddleClass _middleClass;

        public TopClass(IMiddleClass middleClass)
        {
            _middleClass = middleClass;
        }

        public int GetResult(MyValue value)
        {
            return _middleClass.GetResult(value);

        }
    }
}