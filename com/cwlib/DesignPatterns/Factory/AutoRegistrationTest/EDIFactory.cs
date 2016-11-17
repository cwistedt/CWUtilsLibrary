using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.Factory.AutoRegistrationTest
{
    class EDIFactory
    {
        Dictionary<EDITYPES, IEDI> EDIS = new Dictionary<EDITYPES, IEDI>();
        
        public static EDIFactory Instance { get; }

        static EDIFactory()
        {
            Instance = new EDIFactory();
            Instance.Initialize();
        }   

        public void Initialize()
        {
            System.Reflection.Assembly ass = System.Reflection.Assembly.GetExecutingAssembly();
                
            Type[] types = ass.GetTypes();

            IEnumerable<Type> iEDIClasses = types.Where(Type => Type.IsClass && !Type.IsInterface && Type.GetInterface("IEDI") != null && Type.GetProperty("Key", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public) != null);

            foreach (Type type in iEDIClasses)
            {
                EDITYPES ediType = (EDITYPES)type.GetProperty("Key", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null, null);
                EDIS.Add(ediType, (IEDI)Activator.CreateInstance(type));
            }
        }

        public IEDI GetEDI(EDITYPES type)
        {
            Console.WriteLine("Returning " + EDIS[type].GetType().Name);
            return EDIS[type];
        }        
    }
}
