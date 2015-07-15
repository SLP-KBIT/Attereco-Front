using Codeplex.Data;
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
            this.Json = this.SetJson();
        }

        /// <summary>
        /// IDm
        /// </summary>
        public String IDm { get; private set; }

        public DynamicJson Json { get; private set; }

        /// <summary>
        /// IDmをJsonにするクラス
        /// </summary>
        /// <returns>dynamicのまま返す</returns>
        private DynamicJson SetJson()
        {
            dynamic json = new DynamicJson();
            json["IDm"] = this.IDm;
            return json;
        }
    }
}
