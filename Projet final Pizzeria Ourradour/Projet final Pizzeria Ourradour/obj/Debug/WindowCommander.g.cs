﻿#pragma checksum "..\..\WindowCommander.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5B9108B2F7D3003D85B13E491B8828C3B65C02D7A2E4CA7548C3E02FD3387980"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Projet_final_Pizzeria_Tetard_Ourradour;
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


namespace Projet_final_Pizzeria_Tetard_Ourradour {
    
    
    /// <summary>
    /// WindowCommander
    /// </summary>
    public partial class WindowCommander : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\WindowCommander.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Titre;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\WindowCommander.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BouttonMargarita;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\WindowCommander.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Sauvage;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\WindowCommander.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Reine;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\WindowCommander.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MyComboBox;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\WindowCommander.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelNotification;
        
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
            System.Uri resourceLocater = new System.Uri("/Projet final Pizzeria Tetard Ourradour;component/windowcommander.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowCommander.xaml"
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
            this.Titre = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            
            #line 19 "..\..\WindowCommander.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 20 "..\..\WindowCommander.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 21 "..\..\WindowCommander.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BouttonMargarita = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\WindowCommander.xaml"
            this.BouttonMargarita.Click += new System.Windows.RoutedEventHandler(this.CliqueBouttonMargarita);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Sauvage = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\WindowCommander.xaml"
            this.Sauvage.Click += new System.Windows.RoutedEventHandler(this.CliqueBouttonSauvage);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Reine = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\WindowCommander.xaml"
            this.Reine.Click += new System.Windows.RoutedEventHandler(this.CliqueBouttonReine);
            
            #line default
            #line hidden
            return;
            case 8:
            this.MyComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            
            #line 49 "..\..\WindowCommander.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 10:
            this.LabelNotification = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

