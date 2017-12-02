using Journals.App.Resources;
using Journals.Core;
using Journals.Core.DataObjects;
using System.Linq;

namespace Journals.App.Extensions
{
    public static class BookmarkExtensions
    {
        static string master = HtmlTemplates.master;
        static string bookmark = HtmlTemplates.bookmarkPost;

        public static string GetHtml(this BookmarkPostObject Source)
        {
            return string.Format(bookmark, Source.Title, Source.JournalTitle, Source.PostMemberName, Source.Content);
        }

        public static string GetHtml(this BookmarkPostObject[] Source)
        {
            var body = Source
                .Select(post => post.GetHtml())
                .Join("<hr>");

            return string.Format(master, body);
        }
    }
}
