using Journals.Core.DataObjects;
using Journals.Core.Exceptions;
using Nwc.XmlRpc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Journals.Core
{
    public partial class JournalsClient
    {
        private string uri { get; set; }
        private string login { get; set; } = "";
        private string password { get; set; } = "";
        private int userId { get; set; } = 0;
        private int blogId { get; set; } = 0;

        public JournalsClient(string Login, string Password, string Uri)
        {
            login = Login;
            password = Password;
            uri = Uri;
        }

        private async Task<XmlRpcResponse> SendRequest
            (string Method, object[] Parameters) 
        {
            var request = new XmlRpcRequest();
            request.MethodName = Method;
            foreach (var param in Parameters)
                request.Params.Add(param);

            var result = await Task.Run(() => request.Send(uri));

            if (result.IsFault)
                throw new JClientException(result.FaultCode, result.FaultString);

            return result;
        }

        private async Task<T> Retrieve<T>(string Method, object[] Parameters)
            where T : DataObject, new()
        {
            var response = await SendRequest(Method, Parameters);
            return (response.Value as Hashtable).ToDataObject<T>();
        }

        private async Task<T[]> RetrieveArray<T> (string Method, object[] Parameters)
            where T : DataObject, new()
        {
            var response = await SendRequest(Method, Parameters);
            var value = (response.Value as IList).Cast<Hashtable>();
            return value
                .Select(item => item.ToDataObject<T>())
                .ToArray();
        }

        private async Task<object> Send(string Method, object[] Parameters)
        {
            var result = await SendRequest(Method, Parameters);
            return result.Value;
        }

        public async Task<UserBlogObject[]> GetBlogs()
        {
            return await RetrieveArray<UserBlogObject>(GET_USERS_BLOGS,
                new[]
                {
                    login,
                    password
                });
        }

        public async Task<PostObject> GetPost(int PostId)
        {
            return await Retrieve<PostObject>(GET_POST,
                new object[]
                {
                    login,
                    password,
                    PostId
                });
        }

        public async Task<PostObject[]> GetPosts(string BlogId, int Number, int Offset)
        {
            return await RetrieveArray<PostObject>(GET_POSTS,
                new object[]
                {
                    BlogId,
                    login,
                    password,
                    new Hashtable
                    {
                        { "number", Number },
                        { "offset", Offset }
                    }
                });
        }

        public async Task<string> CreatePost(int BlogId, int AuthorId, string Title, string Body)
        {
            var dto = new Hashtable
            {
                {"post_type", "post"},
                {"post_status", "private"},
                {"post_title", Title},
                {"post_author", AuthorId},
                {"post_excerpt", ""},
                {"post_content", Body},
                {"post_date_gmt", DateTime.UtcNow},
                {"post_date", DateTime.Now },
                {"post_format", "standard"},
                {"post_name", ""},
                {"post_password", ""},
                {"comment_status", "open"},
                {"ping_status", "open"},
                {"sticky", 1},
                {"post_thumbnail", new ArrayList()},
                {"post_parent", 0},
                {"custom_fields", new ArrayList()},
                {"terms", new ArrayList()},
                {"terms_names", new ArrayList()},
                {"enclosure", new object()}
            };

            var result = await Send(NEW_POST,
                new object[]
                {
                    BlogId,
                    login,
                    password,
                    dto
                });

            return (string)result;
        }
    }
}
