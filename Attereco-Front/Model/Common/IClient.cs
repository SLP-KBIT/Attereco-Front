using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attereco_Front.Model.Common
{
    public interface IClient
    {
        User AttendSid(User user);
        User AttendIdm(string idm);
    }
}
