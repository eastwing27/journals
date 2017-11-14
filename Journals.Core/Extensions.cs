using System;
using System.Collections.Generic;
using System.Text;

namespace Journals.Core
{
    public static class Extensions
    {
        public static string Join (this IEnumerable<string> Source, string Separator)
        {
            return string.Join(Separator, Source);
        }
    }
}
