﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.Dicom.ServiceModel.Streaming {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.5.0.0")]
    internal sealed partial class StreamingSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static StreamingSettings defaultInstance = ((StreamingSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new StreamingSettings())));
        
        public static StreamingSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// The timeout, in seconds, for establishing a connection to a streaming server.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("The timeout, in seconds, for establishing a connection to a streaming server.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int ClientTimeoutSeconds {
            get {
                return ((int)(this["ClientTimeoutSeconds"]));
            }
        }
    }
}
