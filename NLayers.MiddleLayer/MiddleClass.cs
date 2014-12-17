using NLayers.BottomLayer;
using NLayers.Models;

namespace NLayers.MiddleLayer
{
    public class MiddleClass : IMiddleClass
    {
        private readonly IBottomClass _bottomClass;

        public MiddleClass(IBottomClass bottomClass)
        {
            _bottomClass = bottomClass;
        }

        public int GetResult(MyValue value)
        {
           return _bottomClass.GetResult(value);
        }
    }
}