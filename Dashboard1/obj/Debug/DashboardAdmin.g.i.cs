﻿#pragma checksum "..\..\DashboardAdmin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7367B8DB2FCE7D972C0DF541DCDB76C9257551C1"
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
using De.TorstenMandelkow.MetroChart;
using MaterialDesignThemes.Wpf;
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
    /// DashboardAdmin
    /// </summary>
    public partial class DashboardAdmin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 194 "..\..\DashboardAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BorderG1;
        
        #line default
        #line hidden
        
        
        #line 212 "..\..\DashboardAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BorderG2;
        
        #line default
        #line hidden
        
        
        #line 249 "..\..\DashboardAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDataEmployee;
        
        #line default
        #line hidden
        
        
        #line 256 "..\..\DashboardAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDataEmployee1;
        
        #line default
        #line hidden
        
        
        #line 263 "..\..\DashboardAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDepartment;
        
        #line default
        #line hidden
        
        
        #line 286 "..\..\DashboardAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridBarraTitulo;
        
        #line default
        #line hidden
        
        
        #line 294 "..\..\DashboardAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
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
            System.Uri resourceLocater = new System.Uri("/Dashboard1;component/dashboardadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DashboardAdmin.xaml"
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
            this.BorderG1 = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.BorderG2 = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.btnDataEmployee = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.btnDataEmployee1 = ((System.Windows.Controls.Button)(target));
            
            #line 256 "..\..\DashboardAdmin.xaml"
            this.btnDataEmployee1.Click += new System.Windows.RoutedEventHandler(this.BtnDataEmployee1_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnDepartment = ((System.Windows.Controls.Button)(target));
            
            #line 263 "..\..\DashboardAdmin.xaml"
            this.btnDepartment.Click += new System.Windows.RoutedEventHandler(this.BtnDepartment_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.GridBarraTitulo = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 294 "..\..\DashboardAdmin.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.BtnClose_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

