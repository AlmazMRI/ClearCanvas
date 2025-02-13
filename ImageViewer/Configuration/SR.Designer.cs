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
    internal class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ClearCanvas.ImageViewer.Configuration.SR", typeof(SR).Assembly);
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
        ///   Looks up a localized string similar to {0} other servers exist with the same AE Title, but different host names and/or ports. Are you sure you want to apply this change?.
        /// </summary>
        internal static string ConfirmAETitleConflict_MultipleServers {
            get {
                return ResourceManager.GetString("ConfirmAETitleConflict_MultipleServers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Another server exists with the same AE Title, but a different host name and/or port. Are you sure you want to apply this change?.
        /// </summary>
        internal static string ConfirmAETitleConflict_OneServer {
            get {
                return ResourceManager.GetString("ConfirmAETitleConflict_OneServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If you wish to keep your existing studies, you must manually copy them to the new
        ///location before restarting the local service. Otherwise, you should restart the local service
        ///and immediately re-index..
        /// </summary>
        internal static string DescriptionFileStoreChanged {
            get {
                return ResourceManager.GetString("DescriptionFileStoreChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please check the servers that should be automatically searched for prior studies..
        /// </summary>
        internal static string DescriptionPriorsServers {
            get {
                return ResourceManager.GetString("DescriptionPriorsServers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file store location cannot be changed unless the local service is stopped. Once the file store has changed, you must either manually copy files over from the old location before restarting the local service, or simply restart the local service and immediately re-index.
        ///
        ///If the maximum disk usage is exceeded, the Workstation will refuse to import images or receive them over the network in order to avoid exhausting the disk. If the used space is reaching the maximum, it is recommended you increase the m [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DescriptionStorageOptions {
            get {
                return ResourceManager.GetString("DescriptionStorageOptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DICOM Send.
        /// </summary>
        internal static string DicomSendConfiguration {
            get {
                return ResourceManager.GetString("DicomSendConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Example Group.
        /// </summary>
        internal static string ExampleGroup {
            get {
                return ResourceManager.GetString("ExampleGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rm 101.
        /// </summary>
        internal static string ExampleLocation {
            get {
                return ResourceManager.GetString("ExampleLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Example Server.
        /// </summary>
        internal static string ExampleServer {
            get {
                return ResourceManager.GetString("ExampleServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} (Offline)
        ///The configuration is currently unavailable..
        /// </summary>
        internal static string FormatLocalServerConfigurationUnavailable {
            get {
                return ResourceManager.GetString("FormatLocalServerConfigurationUnavailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}
        ///AE Title: {1}
        ///Host: {2}
        ///Listening Port: {3}.
        /// </summary>
        internal static string FormatLocalServerDetails {
            get {
                return ResourceManager.GetString("FormatLocalServerDetails", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} (Offline)
        ///AE Title: {1}
        ///Host: {2}
        ///Listening Port: {3}.
        /// </summary>
        internal static string FormatLocalServerOfflineDetails {
            get {
                return ResourceManager.GetString("FormatLocalServerOfflineDetails", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The server properties conflict with an existing entry ({0}).
        ///Each server must have a unique Name and cannot have the same AE Title, Host and Port as another server..
        /// </summary>
        internal static string FormatServerConflict {
            get {
                return ResourceManager.GetString("FormatServerConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}
        ///AE Title: {1}
        ///Host: {2}
        ///Listening Port: {3}.
        /// </summary>
        internal static string FormatServerDetails {
            get {
                return ResourceManager.GetString("FormatServerDetails", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Server Group &apos;{0}&apos; conflicts with &apos;{1}&apos;.
        ///Please choose another Server Group Name..
        /// </summary>
        internal static string FormatServerGroupConflict {
            get {
                return ResourceManager.GetString("FormatServerGroupConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Streaming Header Port: {0}
        ///Streaming Image Port: {1}.
        /// </summary>
        internal static string FormatStreamingDetails {
            get {
                return ResourceManager.GetString("FormatStreamingDetails", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Context Menu.
        /// </summary>
        internal static string LabelContextMenu {
            get {
                return ResourceManager.GetString("LabelContextMenu", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Main Menu.
        /// </summary>
        internal static string LabelMainMenu {
            get {
                return ResourceManager.GetString("LabelMainMenu", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Toolbar.
        /// </summary>
        internal static string LabelToolbar {
            get {
                return ResourceManager.GetString("LabelToolbar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start Local Service.
        /// </summary>
        internal static string LinkLabelStartLocalService {
            get {
                return ResourceManager.GetString("LinkLabelStartLocalService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stop Local Service.
        /// </summary>
        internal static string LinkLabelStopLocalService {
            get {
                return ResourceManager.GetString("LinkLabelStopLocalService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Local.
        /// </summary>
        internal static string LocalConfiguration {
            get {
                return ResourceManager.GetString("LocalConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Location: {0}.
        /// </summary>
        internal static string Location {
            get {
                return ResourceManager.GetString("Location", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add server.
        /// </summary>
        internal static string MenuAddServer {
            get {
                return ResourceManager.GetString("MenuAddServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add server group.
        /// </summary>
        internal static string MenuAddServerGroup {
            get {
                return ResourceManager.GetString("MenuAddServerGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &amp;Customize....
        /// </summary>
        internal static string MenuCustomizeActionModels {
            get {
                return ResourceManager.GetString("MenuCustomizeActionModels", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete.
        /// </summary>
        internal static string MenuDelete {
            get {
                return ResourceManager.GetString("MenuDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Edit.
        /// </summary>
        internal static string MenuEdit {
            get {
                return ResourceManager.GetString("MenuEdit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to System Configuration.
        /// </summary>
        internal static string MenuSharedConfiguration {
            get {
                return ResourceManager.GetString("MenuSharedConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Verify.
        /// </summary>
        internal static string MenuVerify {
            get {
                return ResourceManager.GetString("MenuVerify", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to update action models.
        /// </summary>
        internal static string MessageActionModelUpdateFailure {
            get {
                return ResourceManager.GetString("MessageActionModelUpdateFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File Store and Study Deletion must be changed separately.
        /// </summary>
        internal static string MessageCannotChangeFileStoreAndStudyDeletionSimultaneously {
            get {
                return ResourceManager.GetString("MessageCannotChangeFileStoreAndStudyDeletionSimultaneously", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to C-ECHO Verification:.
        /// </summary>
        internal static string MessageCEchoVerificationPrefix {
            get {
                return ResourceManager.GetString("MessageCEchoVerificationPrefix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to     {0}: fail    .
        /// </summary>
        internal static string MessageCEchoVerificationSingleServerResultFail {
            get {
                return ResourceManager.GetString("MessageCEchoVerificationSingleServerResultFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to     {0}: successful    .
        /// </summary>
        internal static string MessageCEchoVerificationSingleServerResultSuccess {
            get {
                return ResourceManager.GetString("MessageCEchoVerificationSingleServerResultSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to delete the selected server?.
        /// </summary>
        internal static string MessageConfirmDeleteServer {
            get {
                return ResourceManager.GetString("MessageConfirmDeleteServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to delete the selected server group?.
        /// </summary>
        internal static string MessageConfirmDeleteServerGroup {
            get {
                return ResourceManager.GetString("MessageConfirmDeleteServerGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to save priors server changes..
        /// </summary>
        internal static string MessageFailedToSavePriorsServers {
            get {
                return ResourceManager.GetString("MessageFailedToSavePriorsServers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File store has changed.
        /// </summary>
        internal static string MessageFileStoreChanged {
            get {
                return ResourceManager.GetString("MessageFileStoreChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Host Name cannot be empty..
        /// </summary>
        internal static string MessageHostNameCannotBeEmpty {
            get {
                return ResourceManager.GetString("MessageHostNameCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The shortcut {0} is already assigned to {1}. Do you wish to reassign the shortcut?.
        /// </summary>
        internal static string MessageKeyStrokeAlreadyAssigned {
            get {
                return ResourceManager.GetString("MessageKeyStrokeAlreadyAssigned", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The shortcut {0} is reserved and cannot be reassigned..
        /// </summary>
        internal static string MessageKeyStrokeReserved {
            get {
                return ResourceManager.GetString("MessageKeyStrokeReserved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The global tool for {0} is already assigned to {1}. You will not be able to use the global shortcut for {1} whenever this tool is active. Do you still wish to assign this mouse button?.
        /// </summary>
        internal static string MessageMouseButtonActiveToolAssignmentConflict {
            get {
                return ResourceManager.GetString("MessageMouseButtonActiveToolAssignmentConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The global tool for {0} is already assigned to {1}. Do you wish to reassign the mouse button shortcut?.
        /// </summary>
        internal static string MessageMouseButtonGlobalToolAlreadyAssigned {
            get {
                return ResourceManager.GetString("MessageMouseButtonGlobalToolAlreadyAssigned", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are active tools for {0} (e.g. {1}). You will not be able to use this global shortcut whenever {1} is active. Do you still wish to assign this mouse button?.
        /// </summary>
        internal static string MessageMouseButtonGlobalToolAssignmentConflict {
            get {
                return ResourceManager.GetString("MessageMouseButtonGlobalToolAssignmentConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The default tool for {0} is already assigned to {1}. Do you wish to reassign the mouse button?.
        /// </summary>
        internal static string MessageMouseButtonInitialToolAlreadyAssigned {
            get {
                return ResourceManager.GetString("MessageMouseButtonInitialToolAlreadyAssigned", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No servers have been selected.  Please select at least one server and try again..
        /// </summary>
        internal static string MessageNoServersSelected {
            get {
                return ResourceManager.GetString("MessageNoServersSelected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Port must be between 1 and 65535..
        /// </summary>
        internal static string MessagePortInvalid {
            get {
                return ResourceManager.GetString("MessagePortInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The AE Title contains invalid characters..
        /// </summary>
        internal static string MessageServerAEInvalidCharacters {
            get {
                return ResourceManager.GetString("MessageServerAEInvalidCharacters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The AE Title must be between 1 and 16 characters..
        /// </summary>
        internal static string MessageServerAEInvalidLength {
            get {
                return ResourceManager.GetString("MessageServerAEInvalidLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Server Group Name cannot be empty..
        /// </summary>
        internal static string MessageServerGroupNameCannotBeEmpty {
            get {
                return ResourceManager.GetString("MessageServerGroupNameCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Server Name cannot be empty..
        /// </summary>
        internal static string MessageServerNameCannotBeEmpty {
            get {
                return ResourceManager.GetString("MessageServerNameCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Click for an explanation of study storage options..
        /// </summary>
        internal static string MessageStorageHelp {
            get {
                return ResourceManager.GetString("MessageStorageHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You do not have permission to view System Configuration..
        /// </summary>
        internal static string MessageSystemConfigurationNoPermission {
            get {
                return ResourceManager.GetString("MessageSystemConfigurationNoPermission", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to start the local service. See the logs for more details..
        /// </summary>
        internal static string MessageUnableToStartLocalService {
            get {
                return ResourceManager.GetString("MessageUnableToStartLocalService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to stop the local service. See the logs for more details..
        /// </summary>
        internal static string MessageUnableToStopLocalService {
            get {
                return ResourceManager.GetString("MessageUnableToStopLocalService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Window Configuration.
        /// </summary>
        internal static string MonitorConfiguration {
            get {
                return ResourceManager.GetString("MonitorConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to My Servers.
        /// </summary>
        internal static string MyServersTitle {
            get {
                return ResourceManager.GetString("MyServersTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to My Studies.
        /// </summary>
        internal static string MyStudiesTitle {
            get {
                return ResourceManager.GetString("MyStudiesTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to N/A.
        /// </summary>
        internal static string NotApplicable {
            get {
                return ResourceManager.GetString("NotApplicable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Context Menu (Image).
        /// </summary>
        internal static string PathContextMenuConfiguration {
            get {
                return ResourceManager.GetString("PathContextMenuConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Priors Servers.
        /// </summary>
        internal static string PriorsServersConfiguration {
            get {
                return ResourceManager.GetString("PriorsServersConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Publishing.
        /// </summary>
        internal static string PublishingConfiguration {
            get {
                return ResourceManager.GetString("PublishingConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DICOM Server.
        /// </summary>
        internal static string ServerConfiguration {
            get {
                return ResourceManager.GetString("ServerConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Study Storage.
        /// </summary>
        internal static string StorageConfiguration {
            get {
                return ResourceManager.GetString("StorageConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add New Server.
        /// </summary>
        internal static string TitleAddNewServer {
            get {
                return ResourceManager.GetString("TitleAddNewServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add New Server Group.
        /// </summary>
        internal static string TitleAddServerGroup {
            get {
                return ResourceManager.GetString("TitleAddServerGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Customize Menus and Toolbars.
        /// </summary>
        internal static string TitleCustomizeActionModels {
            get {
                return ResourceManager.GetString("TitleCustomizeActionModels", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Edit Server.
        /// </summary>
        internal static string TitleEditServer {
            get {
                return ResourceManager.GetString("TitleEditServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Edit Server Group.
        /// </summary>
        internal static string TitleEditServerGroup {
            get {
                return ResourceManager.GetString("TitleEditServerGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to My Servers.
        /// </summary>
        internal static string TitleMyServers {
            get {
                return ResourceManager.GetString("TitleMyServers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select File Store Folder.
        /// </summary>
        internal static string TitleSelectFileStore {
            get {
                return ResourceManager.GetString("TitleSelectFileStore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to System Configuration.
        /// </summary>
        internal static string TitleSharedConfiguration {
            get {
                return ResourceManager.GetString("TitleSharedConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add server.
        /// </summary>
        internal static string ToolbarAddServer {
            get {
                return ResourceManager.GetString("ToolbarAddServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add server group.
        /// </summary>
        internal static string ToolbarAddServerGroup {
            get {
                return ResourceManager.GetString("ToolbarAddServerGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete.
        /// </summary>
        internal static string ToolbarDelete {
            get {
                return ResourceManager.GetString("ToolbarDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Edit.
        /// </summary>
        internal static string ToolbarEdit {
            get {
                return ResourceManager.GetString("ToolbarEdit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Verify.
        /// </summary>
        internal static string ToolbarVerify {
            get {
                return ResourceManager.GetString("ToolbarVerify", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add server.
        /// </summary>
        internal static string TooltipAddServer {
            get {
                return ResourceManager.GetString("TooltipAddServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add server group.
        /// </summary>
        internal static string TooltipAddServerGroup {
            get {
                return ResourceManager.GetString("TooltipAddServerGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete server or server group.
        /// </summary>
        internal static string TooltipDelete {
            get {
                return ResourceManager.GetString("TooltipDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Edit server or server group.
        /// </summary>
        internal static string TooltipEdit {
            get {
                return ResourceManager.GetString("TooltipEdit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Verify server or server group.
        /// </summary>
        internal static string TooltipVerify {
            get {
                return ResourceManager.GetString("TooltipVerify", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The AE Title contains invalid characters..
        /// </summary>
        internal static string ValidationAETitleInvalidCharacters {
            get {
                return ResourceManager.GetString("ValidationAETitleInvalidCharacters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The AE Title must be between 1 and 16 characters..
        /// </summary>
        internal static string ValidationAETitleLengthIncorrect {
            get {
                return ResourceManager.GetString("ValidationAETitleLengthIncorrect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The local service must be started before the automatic study deletion behaviour can be changed.
        ///You can click the &quot;Start Local Service&quot; link now, or cancel your changes..
        /// </summary>
        internal static string ValidationCannotChangeDeletionRule {
            get {
                return ResourceManager.GetString("ValidationCannotChangeDeletionRule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified drive ({0}) does not exist..
        /// </summary>
        internal static string ValidationDriveDoesNotExist {
            get {
                return ResourceManager.GetString("ValidationDriveDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified path is invalid..
        /// </summary>
        internal static string ValidationDriveInvalid {
            get {
                return ResourceManager.GetString("ValidationDriveInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The local service must be stopped before the file store can be changed.
        ///You can click the &quot;Stop Local Service&quot; link now, or cancel your changes..
        /// </summary>
        internal static string ValidationMessageCannotChangeFileStore {
            get {
                return ResourceManager.GetString("ValidationMessageCannotChangeFileStore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Port must be between 1 and 65535..
        /// </summary>
        internal static string ValidationPortOutOfRange {
            get {
                return ResourceManager.GetString("ValidationPortOutOfRange", resourceCulture);
            }
        }
    }
}
