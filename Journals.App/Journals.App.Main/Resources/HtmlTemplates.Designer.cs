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
        ///   Ищет локализованную строку, похожую на &lt;h2&gt;{0}&lt;/h2&gt;
        ///&lt;div class=&quot;row&quot;&gt;
        ///    &lt;div class=&quot;col-md-7&quot;&gt;
        ///        &lt;strong&gt;Журнал: &lt;/strong&gt;{1}
        ///    &lt;/div&gt;
        ///    &lt;div class=&quot;col-md-5&quot;&gt;
        ///        &lt;strong&gt;Автор: &lt;/strong&gt;{2}
        ///    &lt;/div&gt;
        ///&lt;/div&gt;
        ///&lt;p&gt;{3}&lt;/p&gt;.
        /// </summary>
        internal static string bookmarkPost {
            get {
                return ResourceManager.GetString("bookmarkPost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &lt;html&gt;
        ///&lt;head&gt;
        ///    &lt;script src=&quot;https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/js/bootstrap.min.js&quot;&gt;&lt;/script&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///    {0}
        ///&lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string master {
            get {
                return ResourceManager.GetString("master", resourceCulture);
            }
        }
    }
}