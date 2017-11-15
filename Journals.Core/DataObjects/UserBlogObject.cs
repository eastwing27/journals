namespace Journals.Core.DataObjects
{
    public class UserBlogObject : DataObject
    {
        public string Url => getString("url");
        public string Id => getString("blogid");
        public string Name => getString("blogName");
        public string XmlRpc => getString("xmlrpc");
        public bool IsUserAdmin => getBoolean("isAdmin");
    }
}
