﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.ImageViewer.Externals.Config {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.5.0.0")]
    internal sealed partial class ExternalsConfigurationSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static ExternalsConfigurationSettings defaultInstance = ((ExternalsConfigurationSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ExternalsConfigurationSettings())));
        
        public static ExternalsConfigurationSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// XML document containing all user-configured external applications, which can be launched from within the viewer.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("XML document containing all user-configured external applications, which can be l" +
            "aunched from within the viewer.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::ClearCanvas.ImageViewer.Externals.ExternalCollection Externals {
            get {
                return ((global::ClearCanvas.ImageViewer.Externals.ExternalCollection)(this["Externals"]));
            }
            set {
                this["Externals"] = value;
            }
        }
    }
}
