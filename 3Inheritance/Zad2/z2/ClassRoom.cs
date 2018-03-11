using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class ClassRoom
    {
        Random rand = new Random();
        Pupil[] pupil = new Pupil[4];
        
        public ClassRoom()
        {
            pupil[0] = genPupil();
            pupil[1] = genPupil();
            pupil[2] = genPupil();
            pupil[3] = genPupil();
        }
        
        public void Study()
        {
            foreach(Pupil p in pupil)
            {
                p.Study();
            }
        }

        public void Read()
        {
            foreach (Pupil p in pupil)
            {
                p.Read();
            }
        }

        Pupil genPupil()
        {
            int r = rand.Next(1, 4);

            switch (r)
            {
                case 1: return new ExcelentPupil();
                case 2: return new GoodPupil();
                case 3: return new BadPupil();
            }
            return new BadPupil();
        }
    }
}
