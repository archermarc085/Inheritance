using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Pupil
    {
        protected string FirstName { get; set; }
        protected string SecondName { get; set; }
        protected int Age { get; set; }

        public Pupil(string firstName, string secondName, int age)
        {
            FirstName = firstName;
            SecondName = secondName;
            Age = age;
        }
        public virtual void Study() { }
        public virtual void Read() { }
        public virtual void Write() { }
        public virtual void Relax() { }
        public override
            string ToString()
        {
            return string.Format(@"Name & SerName: {0} {1}
           Age: {2}", FirstName, SecondName, Age);
        }
    }
    class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string firstName, string secondName, int age)
            : base(firstName, secondName, age)
        {

        }
        public override void Study()
        {
            Console.WriteLine("Excelent Study");
        }
        public override void Read()
        {
            Console.WriteLine("Excelent Read");
        }
        public override void Write()
        {
            Console.WriteLine("Excelent Write");
        }
        public override void Relax()
        {
            Console.WriteLine("Excelent Relax");
        }
    }
    class GoodPupil : Pupil
    {
        public GoodPupil(string firstName, string secondName, int age)
            : base(firstName, secondName, age)
        {

        }
        public override void Study()
        {
            Console.WriteLine("Good Study");
        }
        public override void Read()
        {
            Console.WriteLine("Good Read");
        }
        public override void Write()
        {
            Console.WriteLine("Good Write");
        }
        public override void Relax()
        {
            Console.WriteLine("Good Relax");
        }
    }
    class BadPupil : Pupil
    {
        public BadPupil(string firstName, string secondName, int age)
            : base(firstName, secondName, age)
        {

        }
        public override void Study()
        {
            Console.WriteLine("Bad Study");
        }
        public override void Read()
        {
            Console.WriteLine("Bad Read");
        }
        public override void Write()
        {
            Console.WriteLine("Bad Write");
        }
        public override void Relax()
        {
            Console.WriteLine("Bad Relax");
        }
    }
}
