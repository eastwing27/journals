using System;
using System.Collections.Generic;
using System.Text;

namespace Journals.Core.DataObjects
{
    public class BookmarkPostObject : PostObject
    {
        public int PostMemberId => getInt("jr_post_member_id");
        public string PostAvatarUrl => getString("jr_post_avatar");
        public int ClubId => getInt("jr_club");
        public string JournalTitle => getString("jr_journal_title");
        public int CommentsCount => getInt("jr_comments_number");
        public string UserTitle => getString("jr_post_usertitle");
        public string AuthorName => getString("jr_post_author_name");
        public string PostMemberName => getString("jr_post_member_name");
    }
}
