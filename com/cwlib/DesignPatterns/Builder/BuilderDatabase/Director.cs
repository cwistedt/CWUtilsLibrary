using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.Builder.BuilderDatabase
{
    class Director
    {
        public void Build(IDatabaseBuilder Builder)
        {
            Builder.BuildConnection();
            Builder.BuildCommand();
            Builder.SetSettings();
        }
    }
}
