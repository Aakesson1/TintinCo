﻿#pragma checksum "..\..\..\..\Views\AddPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CA278AEE94D157DA8B4001B2AABE37F76DC3D225"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using TintinCo_.Views;


namespace TintinCo_.Views {
    
    
    /// <summary>
    /// AddComic
    /// </summary>
    public partial class AddComic : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\Views\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Titletb;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Views\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ReleaseYeartb;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Views\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Amounttb;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Views\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox QualityColortb;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Views\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Pricetb;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Views\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Descriptiontb;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Views\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Addbtn;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Views\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Requesttb;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Views\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Backbtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TintinCo.;component/views/addpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\AddPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Titletb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.ReleaseYeartb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Amounttb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.QualityColortb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Pricetb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Descriptiontb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Addbtn = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\Views\AddPage.xaml"
            this.Addbtn.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Requesttb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.Backbtn = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\Views\AddPage.xaml"
            this.Backbtn.Click += new System.Windows.RoutedEventHandler(this.Backbtn_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
