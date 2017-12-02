using System;
using System.Collections.Generic;
using System.Text;

namespace Journals.App
{
    public interface INative
    {
        string BaseUrl { get; }
        Action<string> Notify { get; }
    }
}
