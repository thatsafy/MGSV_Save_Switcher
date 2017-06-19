﻿#pragma checksum "..\..\Launcher.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "90C66060D1D521C5F67E42F8AB93F092"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MGSV_SaveSwitcher;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MGSV_SaveSwitcher {
    
    
    /// <summary>
    /// Launcher
    /// </summary>
    public partial class Launcher : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\Launcher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Hyperlink GitHubLink;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Launcher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image GitHubImage;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Launcher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Hyperlink TwitterLink;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Launcher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image TwitterImage;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Launcher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LaunchGameButton;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Launcher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SavesButton;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\Launcher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SettingsButton;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\Launcher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Hyperlink alertlink;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\Launcher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image alertimage;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\Launcher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UpdateText;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\Launcher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Version;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MGSV_SaveManager;component/launcher.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Launcher.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.GitHubLink = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 21 "..\..\Launcher.xaml"
            this.GitHubLink.RequestNavigate += new System.Windows.Navigation.RequestNavigateEventHandler(this.Hyperlink_RequestNavigate);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GitHubImage = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.TwitterLink = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 28 "..\..\Launcher.xaml"
            this.TwitterLink.RequestNavigate += new System.Windows.Navigation.RequestNavigateEventHandler(this.Hyperlink_RequestNavigate);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TwitterImage = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.LaunchGameButton = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\Launcher.xaml"
            this.LaunchGameButton.Click += new System.Windows.RoutedEventHandler(this.LaunchGame_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SavesButton = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\Launcher.xaml"
            this.SavesButton.Click += new System.Windows.RoutedEventHandler(this.Saves_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SettingsButton = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\Launcher.xaml"
            this.SettingsButton.Click += new System.Windows.RoutedEventHandler(this.LaunchSettings);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 50 "..\..\Launcher.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 58 "..\..\Launcher.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenSaves_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 59 "..\..\Launcher.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenConfigs_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.alertlink = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 69 "..\..\Launcher.xaml"
            this.alertlink.RequestNavigate += new System.Windows.Navigation.RequestNavigateEventHandler(this.Hyperlink_RequestNavigate);
            
            #line default
            #line hidden
            return;
            case 12:
            this.alertimage = ((System.Windows.Controls.Image)(target));
            return;
            case 13:
            this.UpdateText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 14:
            this.Version = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

