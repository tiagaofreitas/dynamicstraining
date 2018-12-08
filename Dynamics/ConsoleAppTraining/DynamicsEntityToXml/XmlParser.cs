using Logger;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DynamicsEntityToXml
{
    public class XmlParser
    {
        Entity _entity;

        public XmlParser(Entity entity)
        {
            _entity = entity;
        }

        public void SerializeEntityToXml()
        {
            Log.LogInformation("Serializing entity to XML...");

            var serializer = new XmlSerializer(_entity.GetType());

            try
            {
                serializer.Serialize(Console.Out, _entity);
            }
            catch (Exception ex)
            {
                Log.LogError(ex.Message);
                throw ex;
            }
        }
    }
}
