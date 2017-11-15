using System;
using System.Collections.Generic;
using System.Text;

namespace Journals.Core.DataObjects
{
    public class PostObject : DataObject
    {
        string Id => getString("post_id");
        string Title => getString("post_title");
        DateTime CreationTime => getDateTime("post_date");
        DateTime CreationTimeGmt => getDateTime("post_date_gmt");
        DateTime ModifyTime => getDateTime("post_modified");
        DateTime ModifyTimeGmt => getDateTime("post_modified_gmt");
        string Status => getString("post_status");
        string Type => getString("post_type");
        string Name => getString("post_name");
        string AuthorId => getString("post_author");
        string PostPassword => getString("post_password");
        string Excerpt => getString("post_excerpt");
        string Content => getString("post_content");
        string ParentId => getString("post_parent");
        string MimeType => getString("post_mime_type");
        string Link => getString("link");
        string Guid => getString("guid");
        int MenuOrder => getInt("menu_order");
        string CommentStatus => getString("comment_status");
        string PingStatus => getString("ping_status");
        int Sticky => getInt("sticky");
        object Thumbnail => this["post_thumbnail"];
        string Format => getString("post_format");
        object CustomFields => this["custom_fields"];
        string ShortUrl => getString("short_url");
        object Terms => this["terms"];
    }
}
