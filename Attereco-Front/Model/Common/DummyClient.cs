using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attereco_Front.Model.Common
{
    public class DummyClient : IClient
    {
        public User AttendSid(User user)
        {
            user.Name = "ほげ太郎";
            // user.Sid = "s00t000";
            user.LoginTime = new DateTime(2015, 1, 1, 12, 0, 0);
            Console.WriteLine(user);
            return user;
        }

        public User AttendIdm(string idm)
        {
            User user = new User();
            user.Name = "ほげ太郎_IDm";
            // user.Sid = "s00t000";
            user.LoginTime = new DateTime(2015, 1, 1, 12, 0, 0);
            Console.WriteLine(user);
            return user;
        }

    }
}
