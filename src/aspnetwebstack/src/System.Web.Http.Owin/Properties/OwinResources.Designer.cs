﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Web.Http.Owin.Properties {
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
    internal class OwinResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal OwinResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Web.Http.Owin.Properties.OwinResources", typeof(OwinResources).Assembly);
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
        ///   Looks up a localized string similar to HttpAuthenticationChallengeContext.Request must not be null..
        /// </summary>
        internal static string HttpAuthenticationChallengeContext_RequestMustNotBeNull {
            get {
                return ResourceManager.GetString("HttpAuthenticationChallengeContext_RequestMustNotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HttpAuthenticationContext.Request must not be null..
        /// </summary>
        internal static string HttpAuthenticationContext_RequestMustNotBeNull {
            get {
                return ResourceManager.GetString("HttpAuthenticationContext_RequestMustNotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No OWIN authentication manager is associated with the request..
        /// </summary>
        internal static string IAuthenticationManagerNotAvailable {
            get {
                return ResourceManager.GetString("IAuthenticationManagerNotAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The OWIN context&apos;s Request property must not be null..
        /// </summary>
        internal static string OwinContext_NullRequest {
            get {
                return ResourceManager.GetString("OwinContext_NullRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The OWIN context&apos;s Response property must not be null..
        /// </summary>
        internal static string OwinContext_NullResponse {
            get {
                return ResourceManager.GetString("OwinContext_NullResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The request must have a request context..
        /// </summary>
        internal static string Request_RequestContextMustNotBeNull {
            get {
                return ResourceManager.GetString("Request_RequestContextMustNotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The message handler did not return a response message..
        /// </summary>
        internal static string SendAsync_ReturnedNull {
            get {
                return ResourceManager.GetString("SendAsync_ReturnedNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.{1} must not be null..
        /// </summary>
        internal static string TypePropertyMustNotBeNull {
            get {
                return ResourceManager.GetString("TypePropertyMustNotBeNull", resourceCulture);
            }
        }
    }
}