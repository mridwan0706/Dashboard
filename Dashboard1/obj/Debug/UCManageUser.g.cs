﻿#pragma checksum "..\..\UCManageUser.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FF2D8FD10B9EA76B3489A7AB958E10F67A227129"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Dashboard1;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Dashboard1 {
    
    
    /// <summary>
    /// UCManageUser
    /// </summary>
    public partial class UCManageUser : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\UCManageUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnaddUser;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\UCManageUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gridUser;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\UCManageUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label countUser;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\UCManageUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IDbox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\UCManageUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox userNamebox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\UCManageUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbRoleUser;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\UCManageUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Passbox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\UCManageUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
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
            System.Uri resourceLocater = new System.Uri("/Dashboard1;component/ucmanageuser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UCManageUser.xaml"
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
            this.btnaddUser = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\UCManageUser.xaml"
            this.btnaddUser.Click += new System.Windows.RoutedEventHandler(this.BtnaddUser_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gridUser = ((System.Windows.Controls.DataGrid)(target));
            
            #line 27 "..\..\UCManageUser.xaml"
            this.gridUser.Loaded += new System.Windows.RoutedEventHandler(this.GridUser_Loaded);
            
            #line default
            #line hidden
            
            #line 27 "..\..\UCManageUser.xaml"
            this.gridUser.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.GridUser_SelectedCellsChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.countUser = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.IDbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.userNamebox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.cmbRoleUser = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.Passbox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 8:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\UCManageUser.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.BtnDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

