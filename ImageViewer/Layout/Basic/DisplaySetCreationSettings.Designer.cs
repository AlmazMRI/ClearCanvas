﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.ImageViewer.Layout.Basic {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.5.0.0")]
    public sealed partial class DisplaySetCreationSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static DisplaySetCreationSettings defaultInstance = ((DisplaySetCreationSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new DisplaySetCreationSettings())));
        
        public static DisplaySetCreationSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// XML document storing user options on how DICOM series should be presented in the viewer context menu.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("XML document storing user options on how DICOM series should be presented in the " +
            "viewer context menu.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Xml.XmlDocument DisplaySetCreationSettingsXml {
            get {
                return ((global::System.Xml.XmlDocument)(this["DisplaySetCreationSettingsXml"]));
            }
            set {
                this["DisplaySetCreationSettingsXml"] = value;
            }
        }
        
        /// <summary>
        /// &quot;Single Image&quot; (e.g. projection) modalities.  By default, series will be split into single image display sets, meaning each image will have it&apos;s own entry in the context menu.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("\"Single Image\" (e.g. projection) modalities.  By default, series will be split in" +
            "to single image display sets, meaning each image will have it\'s own entry in the" +
            " context menu.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CR,DX,MG,KO")]
        public string SingleImageModalities {
            get {
                return ((string)(this["SingleImageModalities"]));
            }
        }
        
        /// <summary>
        /// Modalities where you might encounter &quot;mixed multiframe&quot; series, meaning there are one or more multiframes and/or single images in the same series.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Modalities where you might encounter \"mixed multiframe\" series, meaning there are" +
            " one or more multiframes and/or single images in the same series.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CT,MG,MR,NM,PT,RF,SC,US,XA")]
        public string MixedMultiframeModalities {
            get {
                return ((string)(this["MixedMultiframeModalities"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CR,DX,ES,MG,RF,US,XA,KO")]
        public string AllImagesModalities {
            get {
                return ((string)(this["AllImagesModalities"]));
            }
        }
    }
}
