using Abstractions;
using Binary;

namespace BinaryAdapt
{
    public class BinarySerializerAdapter : IMySerializer, INamed
    {
        private readonly BinarySerializer _serializer = new BinarySerializer();

        public void Serialize<TObj>(TObj data, string pathTo)
            => _serializer.Serialize(data, pathTo);

        public TObj Deserialize<TObj>(string pathFrom)
            => (TObj)_serializer.Deserialize(pathFrom);

        public string FriendlyName => "Binary";
    }
}
