using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class ExpertDocumentWorker:DocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохренен в новом формате");
        }
    }
}
