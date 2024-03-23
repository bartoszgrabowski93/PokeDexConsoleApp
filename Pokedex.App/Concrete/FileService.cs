using Pokedex.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pokedex.App.Concrete
{
    public class FileService
    {
        private XmlRootAttribute _root;
        
        public FileService()
        {
            XmlRootAttribute root = new XmlRootAttribute();
            root = _root;
        } 
        
        public void SaveToXMLFile(string filePath, List<Pokemon> objectToWrite, string objectName, bool append) 
        {
            XmlRootAttribute root = new XmlRootAttribute();
            root.ElementName = objectName;
            root.IsNullable = true;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Pokemon>), root);
            using StreamWriter sw = new StreamWriter(filePath);
            serializer.Serialize(sw, objectToWrite);

        }

        
    }
}
