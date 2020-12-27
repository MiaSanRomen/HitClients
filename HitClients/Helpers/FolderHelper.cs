using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitClients.Helpers
{
    class FolderHelper
    {
        public static string HitClientsPath;

        static FolderHelper()
        {
            string myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            HitClientsPath = Path.Combine(myDocuments, "HitClients");
            if (!Directory.Exists(HitClientsPath))
            {
                Directory.CreateDirectory(HitClientsPath);
            }

        }
    }
}
