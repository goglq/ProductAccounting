using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccounting.Data
{
    public class SavePath
    {
        private static SavePath instance;

        public static SavePath Instance {
            get {
                if (instance == null)
                    instance = new SavePath();
                return instance;
            }
        }

        public string ProductsSavePath { get; }
        public string ProcurementsSavePath { get; }
        public string WriteOffsSavePath { get; }
        public string InventoriesSavePath { get; }

        private SavePath() {
            if (!Directory.Exists("saves"))
                Directory.CreateDirectory("saves");

            ProductsSavePath = Path.Combine("saves", "products.xml");
            ProcurementsSavePath = Path.Combine("saves", "procurements.xml");
            WriteOffsSavePath = Path.Combine("saves", "writeOffs.xml");
            InventoriesSavePath = Path.Combine("saves", "invetories.xml");
        }
    }
}
