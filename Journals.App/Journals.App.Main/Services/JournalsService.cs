using Journals.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Journals.App.Services
{
    public class JournalsService
    {
        JournalsClient client = null;
        string blogId;

        public async void Init (string Login, string Password, string ApiEndpoint)
        {
            var tmpClient = new JournalsClient(Login, Password, ApiEndpoint);
            var blog = (await tmpClient.GetBlogs())[0];
            if (blog != null)
            {
                client = tmpClient;
                blogId = blog.Id;
            }
        }
    }
}
