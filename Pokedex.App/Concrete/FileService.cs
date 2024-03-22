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
            
            _root.ElementName = objectName;
            _root.IsNullable = true;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Pokemon>), _root);
            using StreamWriter sw = new StreamWriter(filePath);
            serializer.Serialize(sw, objectToWrite);

        }

        public List<Pokemon> LoadXmlFile(string filePath)
        {
            String xml = File.ReadAllText(filePath);
            StringReader stringReader = new StringReader(xml);            
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Pokemon>), _root);
            var xmlList = (List<Pokemon>)xmlSerializer.Deserialize(stringReader);
            return xmlList;
        }
 
    }
}
