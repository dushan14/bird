﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace flyBird {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.0.1.0")]
    internal sealed partial class settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static settings defaultInstance = ((settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new settings())));
        
        public static settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("##")]
        public string controlPostfix {
            get {
                return ((string)(this["controlPostfix"]));
            }
            set {
                this["controlPostfix"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3661")]
        public int socketPort {
            get {
                return ((int)(this["socketPort"]));
            }
            set {
                this["socketPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("*+.")]
        public string controlPrefix {
            get {
                return ((string)(this["controlPrefix"]));
            }
            set {
                this["controlPrefix"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3662")]
        public int fileSharePort {
            get {
                return ((int)(this["fileSharePort"]));
            }
            set {
                this["fileSharePort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Output/Received")]
        public string outputFolder {
            get {
                return ((string)(this["outputFolder"]));
            }
            set {
                this["outputFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Output/Recorded")]
        public string audioPath {
            get {
                return ((string)(this["audioPath"]));
            }
            set {
                this["audioPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Output/Received")]
        public string audioInPath {
            get {
                return ((string)(this["audioInPath"]));
            }
            set {
                this["audioInPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Contacts")]
        public string contactPictures {
            get {
                return ((string)(this["contactPictures"]));
            }
            set {
                this["contactPictures"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("flyBirdWiFi")]
        public string hotspotName {
            get {
                return ((string)(this["hotspotName"]));
            }
            set {
                this["hotspotName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("123456789")]
        public string hotsportPassword {
            get {
                return ((string)(this["hotsportPassword"]));
            }
            set {
                this["hotsportPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("encryptKeyDefault123")]
        public string encryptKey {
            get {
                return ((string)(this["encryptKey"]));
            }
            set {
                this["encryptKey"] = value;
            }
        }
    }
}
