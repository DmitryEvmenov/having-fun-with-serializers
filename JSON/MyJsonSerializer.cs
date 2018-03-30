using System.IO;
using Abstractions;
using Newtonsoft.Json;

namespace JSON
{
    public class MyJsonSerializer : MyBaseSerializer<JsonSerializer>, INamed
    {
        protected override JsonSerializer GetNewSerializer<TObj>() => new JsonSerializer();
        protected override void HandleSerialization<TObj>(TObj data, string pathTo)
        {
            using (var streamWriter = new StreamWriter(pathTo))
            using (var writer = new JsonTextWriter(streamWriter))
            {
                Serializer.Serialize(writer, data);
            }
        }

        protected override TObj HandleDeserialization<TObj>(string pathFrom)
        {
            using (var fileStream = new FileStream(pathFrom, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (var reader = new StreamReader(fileStream))
            {
                return (TObj)Serializer.Deserialize(reader, typeof(TObj));
            }
        }

        public string FriendlyName => "JSON";
    }
}
