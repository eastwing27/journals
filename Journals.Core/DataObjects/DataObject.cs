using System;
using System.Collections.Generic;

namespace Journals.Core.DataObjects
{
    public abstract class DataObject : Dictionary<string, object>
    {
        private T get<T>(string key) => ContainsKey(key) && this[key] != null
            ? (T)this[key]
            : default(T);

        protected string getString(string key) => this[key] as string;

        protected int getInt(string key) => get<int>(key);

        protected bool getBoolean(string key) => get<bool>(key);

        protected DateTime getDateTime(string key) => get<DateTime>(key);
    }
}