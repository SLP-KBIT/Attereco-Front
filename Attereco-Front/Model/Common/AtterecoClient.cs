using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Attereco_Front;
using Attereco_Front.Model;
using Attereco_Front.Model.Common;
using Codeplex.Data;

namespace Attereco_Front.Model.Common
{
    /// <summary>
    /// HTTPリクエストのためのクライアント
    /// </summary>
    public class AtterecoClient : IClient
    {
        private HttpClient httpClient;

        private Settings settings;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public AtterecoClient()
        {
            httpClient = new HttpClient();
            settings = XMLFileManager.ReadXml<Settings>("Settings.xml");
        }

        /// <summary>
        /// 出席処理
        /// </summary>
        /// <param name="user">対象のユーザデータ</param>
        /// <returns>レスポンスをセットしたユーザデータ</returns>
        public User PostUser(User user)
        {
            Dictionary<string, string> form = new Dictionary<string,string>
            {
                {"token",  settings.Token}
            };
            string url = settings.Url + "/attereco/api/v1/users/" + user.Sid + "/attend_sid";
            var content = new FormUrlEncodedContent(form);
            try
            {
                var response = httpClient.PostAsync(url, content);
                var contents = response.Result.Content.ReadAsStringAsync();
                dynamic obj = DynamicJson.Parse(contents.Result);
                user.Sid = obj["sid"];
                user.Name = obj["name"];
                return user;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Source);
                throw new NullReferenceException();
            }
        }
    }
}
