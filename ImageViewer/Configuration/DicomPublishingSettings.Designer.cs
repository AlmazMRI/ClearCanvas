﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.ImageViewer.Configuration {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.5.0.0")]
    internal sealed partial class DicomPublishingSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static DicomPublishingSettings defaultInstance = ((DicomPublishingSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new DicomPublishingSettings())));
        
        public static DicomPublishingSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Specifies that created SOP instances are to be published to the Source AE as specified in the study&apos;s headers
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Specifies that created SOP instances are to be published to the Source AE as spec" +
            "ified in the study\'s headers")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SendLocalToStudySourceAE {
            get {
                return ((bool)(this["SendLocalToStudySourceAE"]));
            }
        }
    }
}
