﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.Desktop {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.5.0.0")]
    internal sealed partial class ExceptionHandlerSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static ExceptionHandlerSettings defaultInstance = ((ExceptionHandlerSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ExceptionHandlerSettings())));
        
        public static ExceptionHandlerSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Indicates whether exception stack trace is shown in a dialog box.  For security reasons, this should not be enabled in production.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Indicates whether exception stack trace is shown in a dialog box.  For security r" +
            "easons, this should not be enabled in production.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowStackTraceInDialog {
            get {
                return ((bool)(this["ShowStackTraceInDialog"]));
            }
        }
    }
}
