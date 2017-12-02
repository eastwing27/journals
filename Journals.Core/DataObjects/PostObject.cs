using System;
using System.Collections.Generic;
using System.Text;

namespace Journals.Core.DataObjects
{
    public class PostObject : DataObject
    {
        public string Id => getString("post_id");
        public string Title => getString("post_title");
        public DateTime CreationTime => getDateTime("post_date");
        public DateTime CreationTimeGmt => getDateTime("post_date_gmt");
        public DateTime ModifyTime => getDateTime("post_modified");
        public DateTime ModifyTimeGmt => getDateTime("post_modified_gmt");
        public string Status => getString("post_status");
        public string Type => getString("post_type");
        public string Name => getString("post_name");
        public string AuthorId => getString("post_author");
        public string PostPassword => getString("post_password");
        public string Excerpt => getString("post_excerpt");
        public string Content => getString("post_content");
        public string ParentId => getString("post_parent");
        public string MimeType => getString("post_mime_type");
        public string Link => getString("link");
        public string Guid => getString("guid");
        public int MenuOrder => getInt("menu_order");
        public string CommentStatus => getString("comment_status");
        public string PingStatus => getString("ping_status");
        public int Sticky => getInt("sticky");
        public object Thumbnail => this["post_thumbnail"];
        public string Format => getString("post_format");
        public object CustomFields => this["custom_fields"];
        public string ShortUrl => getString("short_url");
        public object Terms => this["terms"];
    }
}
