using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelentPupil excelent = new ExcelentPupil("Masha", "Ivanovna", 12);
            GoodPupil good = new GoodPupil("Petya", "Petrov", 11);
            ClassRoom classRoom = new ClassRoom(excelent, good);
            classRoom.OutputInformation();
            Console.ReadLine();
        }
    }
}
