﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50215.312
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="SSRS_Viewer_RVC.Properties.Settings.get_Default():SSRS_Viewer_RVC.Properties.Sett" +
    "ings")]

namespace SSRS_Viewer_RVC.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = new Settings();
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost/ReportServer/ReportService2005.asmx")]
        public string SSRS_Viewer_RVC_SSRSWebService_ReportingService2005 {
            get {
                return ((string)(this["SSRS_Viewer_RVC_SSRSWebService_ReportingService2005"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost/ReportServer/ReportService2005.asmx")]
        public string SRS_Viewer_Control_SSRSWebService_ReportingService2005 {
            get {
                return ((string)(this["SRS_Viewer_Control_SSRSWebService_ReportingService2005"]));
            }
        }
    }
}
