﻿#pragma checksum "C:\Users\Maskarade\documents\visual studio 2015\Projects\DownloadManager\DownloadManager\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1059F9F7CF3D0A7194B20DAC4FE36283"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DownloadManager
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.ProgressBar = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 2:
                {
                    this.DownloadsTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.txtLink = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4:
                {
                    this.DownloadButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 52 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.DownloadButton).Click += this.Download_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.txtDownloadCompleted = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.btnOpenFile = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 68 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnOpenFile).Click += this.btnOpenFile_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.listBox = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                }
                break;
            case 8:
                {
                    this.BottomBar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 9:
                {
                    this.btnBrowser = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 88 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnBrowser).Click += this.Browser_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.btnSetting = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 95 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnSetting).Click += this.Settings_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

