using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.Factory.AutoRegistrationTest
{
    public enum EDITYPES { VB, MP }
    interface IEDI
    {
        IEDI CreateEDI();
    }
}
