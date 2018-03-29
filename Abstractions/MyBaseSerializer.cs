namespace Abstractions
{
    public abstract class MyBaseSerializer<TSerializer> : IMySerializer
    {
        public void Serialize<TObj>(TObj data, string pathTo)
        {
            Serializer = GetNewSerializer<TObj>();
            HandleSerialization(data, pathTo);
        }

        public TObj Deserialize<TObj>(string pathFrom)
        {
            Serializer = GetNewSerializer<TObj>();
            return HandleDeserialization<TObj>(pathFrom);
        }

        protected TSerializer Serializer;

        protected abstract TSerializer GetNewSerializer<TObj>();

        protected abstract void HandleSerialization<TObj>(TObj data, string pathTo);
        protected abstract TObj HandleDeserialization<TObj>(string pathFrom);

    }
}
