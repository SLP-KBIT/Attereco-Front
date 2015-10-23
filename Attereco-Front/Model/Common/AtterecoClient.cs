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
using System.Net.Http.Headers;
using System.Net;

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

        public User AttendBase(string url)
        {
            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                client.Headers[HttpRequestHeader.ContentEncoding] = "utf-8";
                try
                {
                    User user = new User();
                    string response = client.UploadString(url, "POST", "");
                    var result = DynamicJson.Parse(response);
                    user.Sid = result["sid"];
                    user.Name = result["name"];
                    return user;
                }
                catch (WebException e)
                {
                    Log.Write(e.Status.ToString());
                    Console.WriteLine(e.Source);
                    throw new NullReferenceException();
                }
            }
        }

        public User AttendSid(User user)
        {
            string url = settings.Url + "/users/" + user.Sid 
                                      + "/attend_sid?token=" + settings.Token;
            return AttendBase(url);
        }

        public User AttendIdm(string idm)
        {
            string url = settings.Url + "/users/" + idm
                                      + "/attend_idm?token=" + settings.Token;
            return AttendBase(url);
        }
    }
}
