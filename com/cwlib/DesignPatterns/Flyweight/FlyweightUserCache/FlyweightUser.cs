using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cwlib.DesignPatterns.Flyweight.FlyweightUserCache
{
    class FlyweightUser
    {
        public Guid UserID { get; set; }
        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<FlyweightUser> Followers { get; set; }

        public static FlyweightUser GetUser(Guid userID)
        {
            // get user from the database

            // demo user with random id
            return new FlyweightUser
            {
                UserID = Guid.NewGuid()
            };
        }

    }
}
