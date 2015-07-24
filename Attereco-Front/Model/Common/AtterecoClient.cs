using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Attereco_Front.Model;
using Attereco_Front.Model.Common;

namespace Attereco_Front.Model.Common
{
    public class AtterecoClient : IClient
    {
        private HttpClient httpClient;

        private Settings settings;

        public AtterecoClient()
        {
            httpClient = new HttpClient();
            settings = XMLFileManager.ReadXml<Settings>("Settings.xml");
        }

        public User PostUser(User user)
        {
            Dictionary<string, string> form = new Dictionary<string,string>
            {
                {"token",  settings.Token}
            };
            string url = settings.Url + "/attereco/api/v1/users/" + user.Sid + "/attend_sid";
            Task task = Task.Factory.StartNew(
                async () =>
                {
                    var content = new FormUrlEncodedContent(form);
                    var response = await httpClient.PostAsync(url, content);
                    Console.WriteLine(response.ToString());
                }
            );
            try
            {
                task.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Source);
            }
            return user;
        }
    }
}
