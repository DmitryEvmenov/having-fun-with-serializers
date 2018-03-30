using System.IO;
using System.Xml.Serialization;
using Abstractions;

namespace XML
{
    public class MyXmlSerializer : MyBaseSerializer<XmlSerializer>, INamed
    {
        protected override XmlSerializer GetNewSerializer<TObj>() => new XmlSerializer(typeof(TObj));

        protected override void HandleSerialization<TObj>(TObj data, string pathTo)
        {
            using (var streamWriter = new StreamWriter(pathTo))
            {
                Serializer.Serialize(streamWriter, data);
            }  
        }

        protected override TObj HandleDeserialization<TObj>(string pathFrom)
        {
            using (var fileStream = new FileStream(pathFrom, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                return (TObj)Serializer.Deserialize(fileStream);
            }
        }

        public string FriendlyName => "XML";
    }
}
