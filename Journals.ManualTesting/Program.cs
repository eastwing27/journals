using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Journals.Core;
//using Calabonga.XmlRpc;
using Newtonsoft.Json;

namespace Journals.ManualTesting
{
    class Post : Dictionary<string, object> { }
    class Program
    {
        static void Main(string[] args)
        {


            var wp = new WpClient("eastwing", "Timka511", "https://journals.ru/xmlrpc.php");

            var blogs = wp.GetBlogs().Result;
            var posts = wp.GetPosts(blogs[0].Id, 20, 0).Result;

            Console.ReadKey();
        }

    }
}
