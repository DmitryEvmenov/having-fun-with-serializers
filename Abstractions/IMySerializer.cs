namespace Abstractions
{
    public interface IMySerializer
    {
        void Serialize<TObj>(TObj data, string pathTo);
        TObj Deserialize<TObj>(string pathFrom);
    }
}
