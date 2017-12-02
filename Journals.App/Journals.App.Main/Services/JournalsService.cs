using Journals.Core;
using Journals.Core.DataObjects;
using Journals.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journals.App.Services
{
    public class JournalsService
    {
        JournalsClient client = null;
        string blogId;

        public bool IsValid => client != null && !string.IsNullOrEmpty(blogId);

        (bool, string) ValidationError => (false, "Служба journals.ru не инициализирована!");
        (bool State, string Message) GetExceptionResult(Exception e) => (false, $"Во время выполнения операции произошла ошибка:{Environment.NewLine}{e.Message}");

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
                    return (true, null);
                }
                return (false, "Перед началом работы с Journals.ru необходимо создать блог");
            }
            catch(JClientException e)
            {
                return (false, e.FaultString);
            }
            catch(Exception e)
            {
                return GetExceptionResult(e);
            }
        }

        public async Task<(bool Success, string ErrorMessage, BookmarkPostObject[] Content)> GetBookmarksAsync()
        {
            try
            {
                var posts = await client.GetBookmarkPosts();
                return (true, "", posts);
            }
            catch (JClientException e)
            {
                return (false, e.FaultString, null);
            }
            catch (Exception e)
            {
                var result = GetExceptionResult(e);
                return (result.State, result.Message, null);
            }
        }
    }
}
