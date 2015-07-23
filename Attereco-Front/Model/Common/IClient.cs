using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attereco_Front.Model.Common
{
    public interface IClient
    {
        User PostUser(string sid);
    }
}
