﻿#pragma checksum "..\..\..\..\ApplicationPages\UpdateApplicationWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DD7FF1C0433C87C371671C96F20E6F4B9E1C6649"
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
    /// UpdateApplicationWindow
    /// </summary>
    public partial class UpdateApplicationWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\ApplicationPages\UpdateApplicationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ApplicationId;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\ApplicationPages\UpdateApplicationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserExecutor;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\ApplicationPages\UpdateApplicationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StatusId;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\ApplicationPages\UpdateApplicationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox UserExecutorComboBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\ApplicationPages\UpdateApplicationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox StatusApplicationComboBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\ApplicationPages\UpdateApplicationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescriptionTextBox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\ApplicationPages\UpdateApplicationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateApplicationButton;
        
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
            System.Uri resourceLocater = new System.Uri("/LastPractical;component/applicationpages/updateapplicationwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ApplicationPages\UpdateApplicationWindow.xaml"
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
            
            #line 8 "..\..\..\..\ApplicationPages\UpdateApplicationWindow.xaml"
            ((LastPractical.ApplicationPages.UpdateApplicationWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UpdateApplicationWindow_OnLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ApplicationId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.UserExecutor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.StatusId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.UserExecutorComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.StatusApplicationComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.DescriptionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.UpdateApplicationButton = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\ApplicationPages\UpdateApplicationWindow.xaml"
            this.UpdateApplicationButton.Click += new System.Windows.RoutedEventHandler(this.UpdateApplicationButton_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

