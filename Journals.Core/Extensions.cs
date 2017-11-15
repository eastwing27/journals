using Journals.Core.DataObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Journals.Core
{
    public static class Extensions
    {
        public static string Join (this IEnumerable<string> Source, string Separator)
        {
            return string.Join(Separator, Source);
        }

        public static T ToDataObject<T>(this Hashtable Source)
            where T : DataObject, new()
        {
            var result = new T();
            foreach (var item in Source)
            {
                var i = (DictionaryEntry)item;
                result.Add((string)i.Key, i.Value);
            }
            return result;
        }
    }
}
