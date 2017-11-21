using Journals.Core;
using Journals.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Journals.App.Services
{
    public class JournalsService
    {
        JournalsClient client = null;
        string blogId;

        public async Task<(bool Success, string ErrorMessage)> TryInitAsync (string Login, string Password)
        {
            try
            {
                var tmpClient = new JournalsClient(Login, Password, Constants.API_URL);
                var blog = (await tmpClient.GetBlogs())[0];
                if (blog != null)
                {
                    client = tmpClient;
                    blogId = blog.Id;
                    return (true, "");
                }
                return (false, "Перед началом работы с Journals.ru необходимо создать блог");
            }
            catch(JClientException e)
            {
                return (false, e.FaultString);
            }
            catch(Exception e)
            {
                return (false, $"Во время входа произошла ошибка:{Environment.NewLine}{e.Message}");
            }
        }
    }
}
