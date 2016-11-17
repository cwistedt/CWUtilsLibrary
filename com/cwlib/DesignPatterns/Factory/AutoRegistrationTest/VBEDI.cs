using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.Factory.AutoRegistrationTest
{
    class VBEDI : IEDI
    {
        public static EDITYPES Key { get { return EDITYPES.VB; } }
        public IEDI CreateEDI()
        {
            return new VBEDI();
        }

        public VBEDI()
        {
            Console.WriteLine("Created instance of VBEDI");
        }
    }
}
