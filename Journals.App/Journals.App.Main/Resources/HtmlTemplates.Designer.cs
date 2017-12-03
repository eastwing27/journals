﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Journals.App.Resources {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class HtmlTemplates {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal HtmlTemplates() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Journals.App.Resources.HtmlTemplates", typeof(HtmlTemplates).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &lt;div class=&quot;journalsPost&quot; id=&quot;{4}&quot;&gt;
        ///    &lt;div class=&quot;row&quot;&gt;
        ///        &lt;span class=&quot;label label-primary&quot;&gt;&lt;strong&gt;Журнал: &lt;/strong&gt;{1}&lt;/span&gt;
        ///        &lt;span class=&quot;label label-success&quot;&gt;&lt;strong&gt;Автор: &lt;/strong&gt;{2}&lt;/span&gt;
        ///    &lt;/div&gt;
        ///    &lt;h2&gt;{0}&lt;/h2&gt;
        ///    &lt;p&gt;{3}&lt;/p&gt;
        ///&lt;/div&gt;.
        /// </summary>
        internal static string bookmarkPost {
            get {
                return ResourceManager.GetString("bookmarkPost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &lt;html&gt;
        ///&lt;head&gt;
        ///    &lt;link rel=&quot;stylesheet&quot; href=&quot;https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css&quot; /&gt;
        ///    &lt;link rel=&quot;stylesheet&quot; href=&quot;styles.css&quot;&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///    &lt;div class=&quot;container&quot;&gt;
        ///        {0}
        ///    &lt;/div&gt;
        ///&lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string master {
            get {
                return ResourceManager.GetString("master", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &lt;!DOCTYPE html&gt;
        ///
        ///&lt;html lang=&quot;en&quot; xmlns=&quot;http://www.w3.org/1999/xhtml&quot;&gt;
        ///&lt;head&gt;
        ///    &lt;meta charset=&quot;utf-8&quot; /&gt;
        ///    &lt;title&gt;&lt;/title&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///
        ///&lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string post {
            get {
                return ResourceManager.GetString("post", resourceCulture);
            }
        }
    }
}
