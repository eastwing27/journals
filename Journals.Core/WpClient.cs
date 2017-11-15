using Journals.Core.DataObjects;
using Nwc.XmlRpc;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Journals.Core
{
    public class WpClient
    {
        private string uri { get; set; }
        private string login { get; set; } = "";
        private string password { get; set; } = "";
        private int userId { get; set; } = 0;
        private int blogId { get; set; } = 0;

        public WpClient(string Login, string Password, string Uri)
        {
            login = Login;
            password = Password;
            uri = Uri;
        }

        private async Task<IEnumerable<T>> SendRequest<T>
            (string Method, IEnumerable<object> Parameters) 
            where T : DataObject, new()
        {
            var client = new XmlRpcRequest();
            client.MethodName = Method;
            foreach (var param in Parameters)
                client.Params.Add(param);

            var response = await Task.Run(() => client.Send(uri));

            var value = (response.Value as IList).Cast<Hashtable>();
            return value.Select(item => item.ToDataObject<T>());
        }

        public async Task<UserBlogObject[]> GetBlogs()
        {
            var result = await SendRequest<UserBlogObject>("wp.getUsersBlogs", 
                new[] 
                {
                    login,
                    password
                });
            return result.ToArray();   
        }

        public async Task<PostObject[]> GetPosts(string BlogId, int Number, int Offset)
        {
            var result = await SendRequest<PostObject>("wp.getPosts",
                new object[]
                {
                    BlogId,
                    login,
                    password,
                    new
                    {
                        number = Number,
                        offset = Offset
                    }
                });

            return result.ToArray();
        }
    }
}
