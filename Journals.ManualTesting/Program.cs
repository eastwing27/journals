using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Journals.Core;
using Journals.Core.Exceptions;

namespace Journals.ManualTesting
{
    class Post : Dictionary<string, object> { }
    class Program
    {
        static void Main(string[] args)
        {


            var client = new JournalsClient("eastwing", "Password1", "https://journals.ru/xmlrpc.php");

            try
            {
                var blogs = client.GetBookmarkPosts().Result;
                Console.Write(blogs.Length);
            }
            catch(AggregateException e)
            {
                e.Handle(x => 
                {
                    if (x is JClientException)
                    {
                        var clientEx = x as JClientException;
                        Console.Write(clientEx.FaultString);
                        return true;
                    }
                    return false;
                });
 
            }
            //var posts = client.GetPosts(blogs[0].Id, 20, 0).Result;
            //var post = client.GetPost(4943770);

            //Encoding utf8 = Encoding.GetEncoding("UTF-8");
            //Encoding win1251 = Encoding.GetEncoding("Windows-1251");

            //byte[] utf8Bytes = win1251.GetBytes("Привет из консоли!");
            //byte[] win1251Bytes = Encoding.Convert(utf8, win1251, utf8Bytes);

            //var newPostId = client.CreatePost(108891, 108891, "Test entry #10", win1251.GetString(win1251Bytes)).Result;
            //Console.Write(newPostId);

            Console.ReadKey();
        }

    }
}
