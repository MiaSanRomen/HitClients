using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using HitClients.Types;

namespace HitClients.Helpers
{
    class FormHelper
    {
        public static void Save(string name, FormState state)
        {
            string fileName = Path.Combine(FolderHelper.HitClientsPath, $"{name}.xml");
            FileStream file = File.Create(fileName);
            XmlSerializer writer = new XmlSerializer(typeof(FormState));
            writer.Serialize(file, state);
            file.Close();
        }

        public static FormState Load(string name)
        {
            string fileName = Path.Combine(FolderHelper.HitClientsPath, $"{name}.xml");
            if (!File.Exists(fileName)) return null;
            XmlSerializer reader = new XmlSerializer(typeof(FormState));
            StreamReader file = new StreamReader(fileName);
            FormState state = (FormState)reader.Deserialize(file);
            file.Close();
            return state;
        } 
    }
}
