﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.ImageViewer.StudyManagement.Core.WorkItemProcessor {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.5.0.0")]
    public sealed partial class WorkItemServiceSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static WorkItemServiceSettings defaultInstance = ((WorkItemServiceSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new WorkItemServiceSettings())));
        
        public static WorkItemServiceSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Number of threads allocated for processing normal priority work items.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Number of threads allocated for processing normal priority work items.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("6")]
        public int NormalThreadCount {
            get {
                return ((int)(this["NormalThreadCount"]));
            }
        }
        
        /// <summary>
        /// Number of threads allocated for processing stat priority work items.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Number of threads allocated for processing stat priority work items.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int StatThreadCount {
            get {
                return ((int)(this["StatThreadCount"]));
            }
        }
        
        /// <summary>
        /// Idle time in seconds before a postponed work item is resumed.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Idle time in seconds before a postponed work item is resumed.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("15")]
        public int PostponeSeconds {
            get {
                return ((int)(this["PostponeSeconds"]));
            }
        }
        
        /// <summary>
        /// Delay time in seconds before an indeterminate progress work item is considered complete.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Delay time in seconds before an indeterminate progress work item is considered co" +
            "mplete.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public int ExpireDelaySeconds {
            get {
                return ((int)(this["ExpireDelaySeconds"]));
            }
        }
        
        /// <summary>
        /// Delay time in minutes before a completed work item is purged from the activity monitor.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Delay time in minutes before a completed work item is purged from the activity mo" +
            "nitor.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("120")]
        public int DeleteDelayMinutes {
            get {
                return ((int)(this["DeleteDelayMinutes"]));
            }
        }
        
        /// <summary>
        /// Maximum number of times to retry a failed work item.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Maximum number of times to retry a failed work item.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int RetryCount {
            get {
                return ((int)(this["RetryCount"]));
            }
        }
        
        /// <summary>
        /// Number of instances to process in a single batch for a study processing work item.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Number of instances to process in a single batch for a study processing work item" +
            ".")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("25")]
        public int StudyProcessBatchSize {
            get {
                return ((int)(this["StudyProcessBatchSize"]));
            }
        }
        
        /// <summary>
        /// Delay time in seconds before a newly queued work item will start.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Delay time in seconds before a newly queued work item will start.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int InsertDelaySeconds {
            get {
                return ((int)(this["InsertDelaySeconds"]));
            }
        }
    }
}
