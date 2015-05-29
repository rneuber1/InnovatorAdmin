﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aras.Tools.InnovatorAdmin.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Aras.Tools.InnovatorAdmin.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to &lt;Item type=&quot;Property&quot; action=&quot;get&quot; select=&quot;name,source_id(id,name)&quot;&gt;
        ///  &lt;id condition=&quot;in&quot;&gt;(SELECT p.id
        ///from innovator.PROPERTY p
        ///inner join innovator.ITEMTYPE it
        ///on p.SOURCE_ID = it.id
        ///where p.CREATED_BY_ID &amp;lt;&amp;gt; &apos;AD30A6D8D3B642F5A2AFED1A4B02BEFA&apos; and it.CORE = 1 and it.CREATED_BY_ID = &apos;AD30A6D8D3B642F5A2AFED1A4B02BEFA&apos;)&lt;/id&gt;
        ///&lt;/Item&gt;.
        /// </summary>
        internal static string CustomUserProperties {
            get {
                return ResourceManager.GetString("CustomUserProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Item type=&quot;DatabaseUpgrade&quot; action=&quot;merge&quot; id=&quot;{0}&quot;&gt;
        ///  &lt;upgrade_status&gt;0&lt;/upgrade_status&gt;
        ///  &lt;is_latest&gt;0&lt;/is_latest&gt;
        ///  &lt;type&gt;1&lt;/type&gt;
        ///  &lt;os_user&gt;{1}\{2}&lt;/os_user&gt;
        ///  &lt;name&gt;{3}&lt;/name&gt;
        ///  &lt;description&gt;{4}&lt;/description&gt;
        ///  &lt;applied_on&gt;__now()&lt;/applied_on&gt;
        ///&lt;/Item&gt;.
        /// </summary>
        internal static string DbUpgrade_Start {
            get {
                return ResourceManager.GetString("DbUpgrade_Start", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Item type=&quot;Property&quot; action=&quot;get&quot; select=&quot;source_id,item_behavior,name&quot; related_expand=&quot;0&quot;&gt;
        ///  &lt;data_type&gt;item&lt;/data_type&gt;
        ///  &lt;data_source&gt;
        ///    &lt;Item type=&quot;ItemType&quot; action=&quot;get&quot;&gt;
        ///      &lt;is_versionable&gt;1&lt;/is_versionable&gt;
        ///    &lt;/Item&gt;
        ///  &lt;/data_source&gt;
        ///  &lt;item_behavior&gt;float&lt;/item_behavior&gt;
        ///  &lt;name condition=&quot;not in&quot;&gt;&apos;config_id&apos;,&apos;id&apos;&lt;/name&gt;
        ///&lt;/Item&gt;.
        /// </summary>
        internal static string FloatProperties {
            get {
                return ResourceManager.GetString("FloatProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Item type=&quot;Method&quot; action=&quot;get&quot; select=&quot;config_id&quot;&gt;
        ///  &lt;core&gt;1&lt;/core&gt;
        ///&lt;/Item&gt;.
        /// </summary>
        internal static string GetCoreMethods {
            get {
                return ResourceManager.GetString("GetCoreMethods", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Item type=&quot;PackageElement&quot; action=&quot;get&quot; select=&quot;element_id,element_type,name&quot;&gt;
        ///  &lt;source_id condition=&quot;in&quot;&gt;(select id
        ///from innovator.PACKAGEGROUP
        ///where SOURCE_ID = &apos;{0}&apos;)&lt;/source_id&gt;
        ///&lt;/Item&gt;.
        /// </summary>
        internal static string GetPackageElements {
            get {
                return ResourceManager.GetString("GetPackageElements", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Item type=&quot;ItemType&quot; action=&quot;get&quot; select=&quot;is_versionable,is_dependent,implementation_type,core,name&quot;&gt;
        ///&lt;/Item&gt;.
        /// </summary>
        internal static string ItemTypeData {
            get {
                return ResourceManager.GetString("ItemTypeData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to and not [List].[id] in (
        ///select l.id
        ///from innovator.LIST l
        ///inner join innovator.PROPERTY p
        ///on l.id = p.DATA_SOURCE
        ///and p.name = &apos;itemtype&apos;
        ///inner join innovator.ITEMTYPE it
        ///on it.id = p.SOURCE_ID
        ///and it.IMPLEMENTATION_TYPE = &apos;polymorphic&apos;
        ///).
        /// </summary>
        internal static string ListSqlCriteria {
            get {
                return ResourceManager.GetString("ListSqlCriteria", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Item action=&quot;get&quot; type=&quot;RelationshipType&quot; related_expand=&quot;0&quot; select=&quot;related_id,source_id,relationship_id,name&quot; /&gt;.
        /// </summary>
        internal static string RelationshipData {
            get {
                return ResourceManager.GetString("RelationshipData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Item type=&quot;SQL&quot; action=&quot;get&quot; select=&quot;id,name&quot;&gt;&lt;/Item&gt;.
        /// </summary>
        internal static string SqlItems {
            get {
                return ResourceManager.GetString("SqlItems", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Item type=&quot;Identity&quot; action=&quot;get&quot; select=&quot;id,name&quot;&gt;
        ///  &lt;name condition=&quot;in&quot;&gt;&apos;World&apos;, &apos;Creator&apos;, &apos;Owner&apos;, &apos;Manager&apos;, &apos;Innovator Admin&apos;, &apos;Super User&apos;&lt;/name&gt;
        ///&lt;/Item&gt;.
        /// </summary>
        internal static string SystemIdentities {
            get {
                return ResourceManager.GetString("SystemIdentities", resourceCulture);
            }
        }
    }
}
