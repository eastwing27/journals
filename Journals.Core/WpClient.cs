using Nwc.XmlRpc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Journals.Core
{
    public class WpClient
    {
        private string uri => "https://journals.ru/xmlrpc.php";
        private string login { get; set; } = "";
        private string password { get; set; } = "";
        private int userId { get; set; } = 0;
        private int blogId { get; set; } = 0;

        public WpClient(string Login, string Password)
        {
            login = Login;
            password = Password;

            var blogs = GetBlogs().Result;
            blogId = Convert.ToInt32(blogs["blogid"]);
        }

        private async Task<IList> SendRequest(string Method, IEnumerable<string> Parameters)
        {
            var client = new XmlRpcRequest();
            client.MethodName = Method;
            foreach (var param in Parameters)
                client.Params.Add(param);

            var resTask = Task.Run(() => client.Send(uri));
            var response = await resTask;

            return response.Value as IList;
        }

        public async Task<Hashtable> GetBlogs()
        {
            var result = await SendRequest("wp.getUsersBlogs", new[] { login, password });
            return result[0] as Hashtable;    
        }
    }
}
