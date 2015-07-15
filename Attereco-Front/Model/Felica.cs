using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attereco_Front.Model
{
    /// <summary>
    /// フェリカ周りのクラス
    /// </summary>
    public class Felica
    {
        public Felica(String _IDm)
        {
            this.IDm = _IDm;
        }

        /// <summary>
        /// IDm
        /// </summary>
        public String IDm { get; private set; }
    }
}
