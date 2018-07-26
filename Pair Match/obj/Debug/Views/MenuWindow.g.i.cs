﻿#pragma checksum "..\..\..\Views\MenuWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C819B2FCA360D2A2BA27B189795C418511251CE9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PairMatch;
using PairMatch.Views;
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


namespace PairMatch.Views {
    
    
    /// <summary>
    /// MenuWindow
    /// </summary>
    public partial class MenuWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\Views\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem StandardGameMenuItem;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Views\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem CustomGameMenuItem;
        
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
            System.Uri resourceLocater = new System.Uri("/Pair Match;component/views/menuwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MenuWindow.xaml"
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
            
            #line 15 "..\..\..\Views\MenuWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.NewCommand_Executed);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 16 "..\..\..\Views\MenuWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.OpenCommand_Executed);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 17 "..\..\..\Views\MenuWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.SaveCommand_Executed);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 18 "..\..\..\Views\MenuWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.StatisticsCommand_Executed);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 19 "..\..\..\Views\MenuWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.ExitCommand_Executed);
            
            #line default
            #line hidden
            return;
            case 6:
            this.StandardGameMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 45 "..\..\..\Views\MenuWindow.xaml"
            this.StandardGameMenuItem.Checked += new System.Windows.RoutedEventHandler(this.OptionsMenuItem_Checked);
            
            #line default
            #line hidden
            
            #line 45 "..\..\..\Views\MenuWindow.xaml"
            this.StandardGameMenuItem.Unchecked += new System.Windows.RoutedEventHandler(this.OptionsMenuItem_Unchecked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CustomGameMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 51 "..\..\..\Views\MenuWindow.xaml"
            this.CustomGameMenuItem.Checked += new System.Windows.RoutedEventHandler(this.OptionsMenuItem_Checked);
            
            #line default
            #line hidden
            
            #line 51 "..\..\..\Views\MenuWindow.xaml"
            this.CustomGameMenuItem.Unchecked += new System.Windows.RoutedEventHandler(this.OptionsMenuItem_Unchecked);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 76 "..\..\..\Views\MenuWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AboutMenuItem_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

