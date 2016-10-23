using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight.FlyweightUserCache
{
    class FlyweightUserFactory
    {
        public static int UsersCount = 0;
        private Dictionary<Guid, FlyweightUser> FlyweightUsers = new Dictionary<Guid, FlyweightUser>();

        public FlyweightUser GetUser(Guid userID)
        {
            if (FlyweightUsers.ContainsKey(userID))
                return FlyweightUsers[userID];

            FlyweightUser user = FlyweightUser.GetUser(userID);
            FlyweightUsers.Add(userID, user);
            UsersCount++;
            return user;
                
        } 
    }
}
