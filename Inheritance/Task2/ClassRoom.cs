using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ClassRoom
    {
        Pupil[] array = null;
        public ClassRoom(Pupil firstPupil, Pupil secondPupil, Pupil thirdPupil, Pupil forthPupil)
        {
            array = new Pupil[4];
            array[0] = firstPupil;
            array[1] = secondPupil;
            array[2] = thirdPupil;
            array[3] = forthPupil;
        }
        public ClassRoom(Pupil firstPupil, Pupil secondPupil, Pupil thirdPupil)
        {
            array = new Pupil[3];
            array[0] = firstPupil;
            array[1] = secondPupil;
            array[2] = thirdPupil;

        }
        public ClassRoom(Pupil firstPupil, Pupil secondPupil)
        {
            array = new Pupil[2];
            array[0] = firstPupil;
            array[1] = secondPupil;
        }

        public void OutputInformation()
        {
            foreach (var pupil in this.array)
            {
                Console.WriteLine(pupil.ToString());
                Console.WriteLine("Skills:");
                pupil.Read();
                pupil.Write();
                pupil.Study();
                pupil.Relax();
                Console.WriteLine();
            }
        }
    }
}
