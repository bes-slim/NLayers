using NLayers.Models;

namespace NLayers.BottomLayer
{
    public class BottomClass : IBottomClass
    {
        public int GetResult(MyValue value)
        {
            return value.Value *value.Value ;
        }
    }
}
