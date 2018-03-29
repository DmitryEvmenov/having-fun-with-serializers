using System;
using System.Xml.Serialization;
using Abstractions;

namespace XML
{
    public class MyXmlSerializer : IMySerializer
    {
        private readonly XmlSerializer Serializer;

        public TObj Deserialize<TObj>(string pathFrom)
        {
            throw new NotImplementedException();
        }

        public void Serialize<TObj>(TObj data, string pathTo)
        {
            throw new NotImplementedException();
        }
    }
}
