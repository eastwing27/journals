using Journals.App.Resources;
using Journals.Core;
using Journals.Core.DataObjects;
using System.Linq;

namespace Journals.App.Extensions
{
    public static class PostHtmlExtensions
    {
        static string master = HtmlTemplates.master;
        static string post = HtmlTemplates.post;
        static string bookmark = HtmlTemplates.bookmarkPost;

        public static string GetHtml(this BookmarkPostObject Source)
        {
            return string.Format(bookmark, Source.Id, Source.JournalTitle, Source.PostMemberName, Source.Title, Source.Content);
        }

        public static string GetHtml(this PostObject Source)
        {
            return string.Format(post, Source.Id, Source.Title, Source.Content);
        }

        public static string GetHtml(this PostObject[] Source)
        {
            var body = Source
                .Select(post => 
                    post is BookmarkPostObject 
                        ? (post as BookmarkPostObject).GetHtml() 
                        : post.GetHtml())
                .Join("<hr>");

            return string.Format(master, body);
        }
    }
}
