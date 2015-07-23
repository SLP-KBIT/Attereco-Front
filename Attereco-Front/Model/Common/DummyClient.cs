using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attereco_Front.Model.Common
{
    public class DummyClient : IClient
    {
        public User PostUser(string sid)
        {
            User user = new User("ほげ太郎", "s00t000");
            user.LoginTime = new DateTime(2015, 1, 1, 12, 0, 0);
            Console.WriteLine(user);
            return user;
        }
    }
}
