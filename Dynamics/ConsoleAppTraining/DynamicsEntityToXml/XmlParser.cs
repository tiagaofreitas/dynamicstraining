using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicsEntityToXml
{
    public class XmlParser
    {
        Entity _entity;

        public XmlParser(Entity entity)
        {
            _entity = entity;
        }
    }
}
