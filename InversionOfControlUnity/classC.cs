using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InversionOfControlUnity
{
    public class classC
    {
        private IclassA a;
        private IclassB b;

        public classC(IclassA t1, IclassB t2)
        {
            a=t1;
            b = t2;

        }

    }
}
