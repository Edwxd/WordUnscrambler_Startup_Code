﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab5 {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class en_lang {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal en_lang() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Lab5.en-lang", typeof(en_lang).Assembly);
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
        ///   Looks up a localized string similar to Enter scrambled word(s) manually or as a file: F - file / M - manual.
        /// </summary>
        internal static string EntreForM {
            get {
                return ResourceManager.GetString("EntreForM", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter word(s) manually (separated by commas if multiple):.
        /// </summary>
        internal static string entrewords {
            get {
                return ResourceManager.GetString("entrewords", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;The program will be terminated..
        /// </summary>
        internal static string exception {
            get {
                return ResourceManager.GetString("exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter full path including the file name: (&quot;C:\Users\edwar\source\repos\Lab5\Lab5\bin\Debug\Scrambledwords.txt&quot;).
        /// </summary>
        internal static string fullpath {
            get {
                return ResourceManager.GetString("fullpath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Would you like to go again ? (y for yes/ any other key for no).
        /// </summary>
        internal static string goagain {
            get {
                return ResourceManager.GetString("goagain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The entered option was not recognized..
        /// </summary>
        internal static string optionnotreco {
            get {
                return ResourceManager.GetString("optionnotreco", resourceCulture);
            }
        }
    }
}