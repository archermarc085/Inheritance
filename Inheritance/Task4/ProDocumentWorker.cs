﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class ProDocumentWorker:DocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредоктирован");
        }
    }
}