using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.Factory.AutoRegistrationTest
{
    class MPEDI : IEDI
    {
        public static EDITYPES Key { get { return EDITYPES.MP; } }

        public IEDI CreateEDI()
        {
            return new MPEDI();
        }

        public MPEDI()
        {        
            Console.WriteLine("Created instance of MPEDI");
        }
    }
}
