﻿#pragma checksum "..\..\..\..\ApplicationPages\AddApplicationPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C322654DCF7E5EEE309390A0D50039948E0B79C8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LastPractical.ApplicationPages;
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


namespace LastPractical.ApplicationPages {
    
    
    /// <summary>
    /// AddApplicationPage
    /// </summary>
    public partial class AddApplicationPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\ApplicationPages\AddApplicationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox UserClietnComboBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\ApplicationPages\AddApplicationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox UserExecutorComboBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\ApplicationPages\AddApplicationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox StatusApplicationComboBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\ApplicationPages\AddApplicationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescriptionTextBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\ApplicationPages\AddApplicationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePicker1;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\ApplicationPages\AddApplicationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddApplicationButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.16.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LastPractical;component/applicationpages/addapplicationpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ApplicationPages\AddApplicationPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.16.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.UserClietnComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.UserExecutorComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.StatusApplicationComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.DescriptionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.datePicker1 = ((System.Windows.Controls.DatePicker)(target));
            
            #line 43 "..\..\..\..\ApplicationPages\AddApplicationPage.xaml"
            this.datePicker1.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.DatePicker1_OnSelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AddApplicationButton = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\ApplicationPages\AddApplicationPage.xaml"
            this.AddApplicationButton.Click += new System.Windows.RoutedEventHandler(this.AddApplicationButton_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

